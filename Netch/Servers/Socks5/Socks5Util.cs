using System.Text;
using Netch.Interfaces;
using Netch.Models;

namespace Netch.Servers;

public class Socks5Util : IServerUtil
{
    public ushort Priority { get; } = 0;

    public string TypeName { get; } = "SOCKS";

    public string FullName { get; } = "SOCKS";

    public string ShortName { get; } = "SOCKS";

    public string[] UriScheme { get; } = { "socks5", "socks", "socks4", "socks4a" };

    public Type ServerType { get; } = typeof(Socks5Server);

    public void Edit(Server s)
    {
        new Socks5Form((Socks5Server)s).ShowDialog();
    }

    public void Create()
    {
        new Socks5Form().ShowDialog();
    }

    public string GetShareLink(Server s)
    {
        var server = (Socks5Server)s;
        var scheme = server.Version switch
        {
            "4a" => "socks4a",
            "4" => "socks4",
            _ => "socks5"
        };

        bool hasAuth = !string.IsNullOrWhiteSpace(server.Username) || !string.IsNullOrWhiteSpace(server.Password);
        string connStr = hasAuth
            ? $"{server.Username}:{server.Password}@{server.Hostname}:{server.Port}"
            : $"{server.Hostname}:{server.Port}";

        string base64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(connStr));
        string link = $"{scheme}://{base64}";
        if (!string.IsNullOrWhiteSpace(server.Remark))
        {
            link += $"#{server.Remark}";
        }

        return link;
    }

    public IServerController GetController()
    {
        return new Socks5Controller();
    }

    public IEnumerable<Server> ParseUri(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            throw new FormatException("Empty link");

        text = text.Trim();

        // 1. Check legacy Telegram format: tg://socks? or https://t.me/socks?
        if (text.StartsWith("tg://socks?", StringComparison.OrdinalIgnoreCase) ||
            text.StartsWith("https://t.me/socks?", StringComparison.OrdinalIgnoreCase))
        {
            return ParseTelegramUri(text);
        }

        // 2. Identify protocol scheme and version
        string version = "5";
        string stripped = text;

        if (text.StartsWith("socks5://", StringComparison.OrdinalIgnoreCase))
        {
            version = "5";
            stripped = text.Substring("socks5://".Length);
        }
        else if (text.StartsWith("socks4a://", StringComparison.OrdinalIgnoreCase))
        {
            version = "4a";
            stripped = text.Substring("socks4a://".Length);
        }
        else if (text.StartsWith("socks4://", StringComparison.OrdinalIgnoreCase))
        {
            version = "4";
            stripped = text.Substring("socks4://".Length);
        }
        else if (text.StartsWith("socks://", StringComparison.OrdinalIgnoreCase))
        {
            version = "5";
            stripped = text.Substring("socks://".Length);
        }
        else
        {
            int schemeIdx = text.IndexOf("://", StringComparison.Ordinal);
            if (schemeIdx != -1)
                stripped = text.Substring(schemeIdx + 3);
        }

        // 3. Extract Remark (Fragment after #)
        string remark = string.Empty;
        int hashIdx = stripped.IndexOf('#');
        if (hashIdx != -1)
        {
            remark = Uri.UnescapeDataString(stripped.Substring(hashIdx + 1).Trim());
            stripped = stripped.Substring(0, hashIdx);
        }

        // Strip any query if present
        int queryIdx = stripped.IndexOf('?');
        if (queryIdx != -1)
        {
            var query = stripped.Substring(queryIdx + 1);
            stripped = stripped.Substring(0, queryIdx);
            if (string.IsNullOrEmpty(remark))
            {
                var queryParams = Utils.ShareLink.ParseParam(query);
                if (queryParams.TryGetValue("remarks", out var r) || queryParams.TryGetValue("remark", out r))
                    remark = Uri.UnescapeDataString(r);
            }
        }
        stripped = stripped.Trim().TrimEnd('/');

        // 4. Parse payload
        string username = string.Empty;
        string password = string.Empty;
        string hostPort = stripped;

        int atIdx = stripped.IndexOf('@');
        if (atIdx != -1)
        {
            // Variant: userinfo@host:port (userinfo may be Base64 or plaintext)
            string userinfo = stripped.Substring(0, atIdx);
            hostPort = stripped.Substring(atIdx + 1);

            ParseUserInfo(userinfo, out username, out password);
        }
        else
        {
            // No '@' present in stripped.
            // Check if stripped is Base64 encoded (entire connection string Base64)
            if (TryBase64Decode(stripped, out string decoded))
            {
                int innerHash = decoded.IndexOf('#');
                if (innerHash != -1)
                {
                    if (string.IsNullOrEmpty(remark))
                        remark = Uri.UnescapeDataString(decoded.Substring(innerHash + 1).Trim());
                    decoded = decoded.Substring(0, innerHash).Trim();
                }

                int decodedAt = decoded.IndexOf('@');
                if (decodedAt != -1)
                {
                    string userinfo = decoded.Substring(0, decodedAt);
                    hostPort = decoded.Substring(decodedAt + 1);
                    ParseUserInfo(userinfo, out username, out password);
                }
                else
                {
                    hostPort = decoded;
                }
            }
            else
            {
                hostPort = stripped;
            }
        }

        // 5. Parse host and port
        ParseHostPort(hostPort, out string hostname, out ushort port);

        var server = new Socks5Server
        {
            Hostname = hostname,
            Port = port,
            Version = version,
            Remark = remark
        };

        if (!string.IsNullOrEmpty(username))
            server.Username = username;
        if (!string.IsNullOrEmpty(password))
            server.Password = password;

        return new[] { server };
    }

    private static void ParseUserInfo(string userinfo, out string username, out string password)
    {
        username = string.Empty;
        password = string.Empty;

        if (TryBase64Decode(userinfo, out string decoded) && decoded.Contains(':'))
        {
            userinfo = decoded;
        }

        int colon = userinfo.IndexOf(':');
        if (colon != -1)
        {
            username = Uri.UnescapeDataString(userinfo.Substring(0, colon));
            password = Uri.UnescapeDataString(userinfo.Substring(colon + 1));
        }
        else
        {
            username = Uri.UnescapeDataString(userinfo);
        }
    }

    private static void ParseHostPort(string hostPort, out string hostname, out ushort port)
    {
        hostPort = hostPort.Trim();

        // IPv6 address with brackets: [::1]:1080 or [2001:db8::1]:1080
        if (hostPort.StartsWith("["))
        {
            int closeBracket = hostPort.IndexOf(']');
            if (closeBracket == -1)
                throw new FormatException($"Invalid IPv6 host in: {hostPort}");

            hostname = hostPort.Substring(1, closeBracket - 1);
            int colonAfter = hostPort.IndexOf(':', closeBracket);
            if (colonAfter != -1 && ushort.TryParse(hostPort.Substring(colonAfter + 1), out ushort p))
            {
                port = p;
            }
            else
            {
                port = 1080;
            }
            return;
        }

        int lastColon = hostPort.LastIndexOf(':');
        if (lastColon != -1 && ushort.TryParse(hostPort.Substring(lastColon + 1), out ushort parsedPort))
        {
            hostname = hostPort.Substring(0, lastColon).Trim();
            port = parsedPort;
        }
        else
        {
            hostname = hostPort;
            port = 1080;
        }

        if (string.IsNullOrWhiteSpace(hostname))
            throw new FormatException($"Missing hostname in: {hostPort}");
    }

    private static bool TryBase64Decode(string input, out string result)
    {
        result = string.Empty;
        if (string.IsNullOrWhiteSpace(input))
            return false;

        string sanitized = input.Trim().Replace("-", "+").Replace("_", "/");
        int mod4 = sanitized.Length % 4;
        if (mod4 != 0)
            sanitized += new string('=', 4 - mod4);

        try
        {
            byte[] bytes = Convert.FromBase64String(sanitized);
            result = Encoding.UTF8.GetString(bytes);

            if (result.Any(c => char.IsControl(c) && c != '\r' && c != '\n' && c != '\t'))
                return false;

            return true;
        }
        catch
        {
            return false;
        }
    }

    private static IEnumerable<Server> ParseTelegramUri(string text)
    {
        var dict = text.Replace("tg://socks?", "", StringComparison.OrdinalIgnoreCase)
            .Replace("https://t.me/socks?", "", StringComparison.OrdinalIgnoreCase)
            .Split('&')
            .Select(str => str.Split('='))
            .Where(splited => splited.Length >= 2)
            .ToDictionary(splited => splited[0].ToLowerInvariant(), splited => Uri.UnescapeDataString(splited[1]));

        if (!dict.ContainsKey("server") || !dict.ContainsKey("port"))
            throw new FormatException("Telegram socks link missing server or port parameter");

        var data = new Socks5Server
        {
            Hostname = dict["server"],
            Port = ushort.Parse(dict["port"]),
            Version = "5"
        };

        if (dict.TryGetValue("user", out var user) && !string.IsNullOrWhiteSpace(user))
            data.Username = user;

        if (dict.TryGetValue("pass", out var pass) && !string.IsNullOrWhiteSpace(pass))
            data.Password = pass;

        return new[] { data };
    }

    public bool CheckServer(Server s)
    {
        return true;
    }
}
using System.Reflection;
using Netch.Interfaces;

namespace Netch.Utils;

public static class ServerHelper
{
    static ServerHelper()
    {
        var serversUtilsTypes = Assembly.GetExecutingAssembly()
            .GetExportedTypes()
            .Where(type => type.GetInterfaces().Contains(typeof(IServerUtil)));

        ServerUtilDictionary = serversUtilsTypes.Select(t => (IServerUtil)Activator.CreateInstance(t)!).ToDictionary(util => util.TypeName);
    }

    public static Dictionary<string, IServerUtil> ServerUtilDictionary { get; }

    public static IServerUtil GetUtilByTypeName(string typeName)
    {
        var util = ServerUtilDictionary.Values.FirstOrDefault(i =>
            i.TypeName.Equals(typeName, StringComparison.OrdinalIgnoreCase) ||
            i.FullName.Equals(typeName, StringComparison.OrdinalIgnoreCase) ||
            i.ShortName.Equals(typeName, StringComparison.OrdinalIgnoreCase) ||
            (typeName.Equals("Socks5", StringComparison.OrdinalIgnoreCase) && i.TypeName.Equals("SOCKS", StringComparison.OrdinalIgnoreCase)));

        return util ?? throw new NotSupportedException($"Specified server type '{typeName}' is not supported.");
    }

    public static IServerUtil? GetUtilByUriScheme(string scheme)
    {
        return ServerUtilDictionary.Values.FirstOrDefault(i => i.UriScheme.Any(s => s.Equals(scheme, StringComparison.OrdinalIgnoreCase)));
    }

    public static Type GetTypeByTypeName(string typeName)
    {
        return GetUtilByTypeName(typeName).ServerType;
    }
}
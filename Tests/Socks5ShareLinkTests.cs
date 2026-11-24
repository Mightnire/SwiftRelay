using Microsoft.VisualStudio.TestTools.UnitTesting;
using Netch.Servers;
using Netch.Utils;

namespace Tests;

[TestClass]
public class Socks5ShareLinkTests
{
    private readonly Socks5Util _util = new();

    [TestMethod]
    public void TestExport_OptionB_WithAuth()
    {
        var server = new Socks5Server("192.168.1.100", 1080, "username", "password")
        {
            Remark = "测试节点",
            Version = "5"
        };

        string link = _util.GetShareLink(server);
        Assert.IsTrue(link.StartsWith("socks5://"), $"Expected socks5:// prefix but got {link}");
        Assert.IsTrue(link.EndsWith("#测试节点"), $"Expected #测试节点 suffix but got {link}");

        // The base64 part is: username:password@192.168.1.100:1080
        // Base64 of that is: dXNlcm5hbWU6cGFzc3dvcmRAMTkyLjE2OC4xLjEwMDoxMDgw
        Assert.AreEqual("socks5://dXNlcm5hbWU6cGFzc3dvcmRAMTkyLjE2OC4xLjEwMDoxMDgw#测试节点", link);
    }

    [TestMethod]
    public void TestExport_OptionB_NoAuth()
    {
        var server = new Socks5Server("127.0.0.1", 7890)
        {
            Remark = "本地无密",
            Version = "5"
        };

        string link = _util.GetShareLink(server);
        // Base64 of "127.0.0.1:7890" is "MTI3LjAuMC4xOjc4OTA="
        Assert.AreEqual("socks5://MTI3LjAuMC4xOjc4OTA=#本地无密", link);
    }

    [TestMethod]
    public void TestExport_Socks4_Socks4a_Prefixes()
    {
        var server4 = new Socks5Server("10.0.0.1", 1080)
        {
            Version = "4",
            Remark = "S4"
        };
        Assert.IsTrue(_util.GetShareLink(server4).StartsWith("socks4://"));

        var server4a = new Socks5Server("10.0.0.2", 1080)
        {
            Version = "4a",
            Remark = "S4a"
        };
        Assert.IsTrue(_util.GetShareLink(server4a).StartsWith("socks4a://"));
    }

    [TestMethod]
    public void TestImport_VariantA_FullBase64()
    {
        // Variant A: socks5://dXNlcm5hbWU6cGFzc3dvcmRAMTkyLjE2OC4xLjEwMDoxMDgw#节点备注
        string link = "socks5://dXNlcm5hbWU6cGFzc3dvcmRAMTkyLjE2OC4xLjEwMDoxMDgw#节点备注";
        var list = _util.ParseUri(link).Cast<Socks5Server>().ToList();

        Assert.AreEqual(1, list.Count);
        var s = list[0];
        Assert.AreEqual("192.168.1.100", s.Hostname);
        Assert.AreEqual((ushort)1080, s.Port);
        Assert.AreEqual("username", s.Username);
        Assert.AreEqual("password", s.Password);
        Assert.AreEqual("节点备注", s.Remark);
        Assert.AreEqual("5", s.Version);
    }

    [TestMethod]
    public void TestImport_VariantB_UserPassBase64Only()
    {
        // Variant B: socks5://dXNlcm5hbWU6cGFzc3dvcmQ=@192.168.1.100:1080#节点备注
        string link = "socks5://dXNlcm5hbWU6cGFzc3dvcmQ=@192.168.1.100:1080#节点备注";
        var list = _util.ParseUri(link).Cast<Socks5Server>().ToList();

        Assert.AreEqual(1, list.Count);
        var s = list[0];
        Assert.AreEqual("192.168.1.100", s.Hostname);
        Assert.AreEqual((ushort)1080, s.Port);
        Assert.AreEqual("username", s.Username);
        Assert.AreEqual("password", s.Password);
        Assert.AreEqual("节点备注", s.Remark);
    }

    [TestMethod]
    public void TestImport_VariantC_Plaintext()
    {
        // Plaintext: socks5://admin:secret@proxy.domain.com:8080#明文测试
        string link = "socks5://admin:secret@proxy.domain.com:8080#明文测试";
        var list = _util.ParseUri(link).Cast<Socks5Server>().ToList();

        Assert.AreEqual(1, list.Count);
        var s = list[0];
        Assert.AreEqual("proxy.domain.com", s.Hostname);
        Assert.AreEqual((ushort)8080, s.Port);
        Assert.AreEqual("admin", s.Username);
        Assert.AreEqual("secret", s.Password);
        Assert.AreEqual("明文测试", s.Remark);
    }

    [TestMethod]
    public void TestImport_Socks4_Socks4a_Versions()
    {
        string link4 = "socks4://192.168.1.50:1080#S4测试";
        var s4 = _util.ParseUri(link4).Cast<Socks5Server>().First();
        Assert.AreEqual("4", s4.Version);
        Assert.AreEqual("192.168.1.50", s4.Hostname);

        string link4a = "socks4a://192.168.1.60:1080#S4a测试";
        var s4a = _util.ParseUri(link4a).Cast<Socks5Server>().First();
        Assert.AreEqual("4a", s4a.Version);
        Assert.AreEqual("192.168.1.60", s4a.Hostname);
    }

    [TestMethod]
    public void TestImport_IPv6_Host()
    {
        // IPv6 host
        string link = "socks5://dXNlcjpwYXNz@[2001:db8::1]:1080#IPv6节点";
        var list = _util.ParseUri(link).Cast<Socks5Server>().ToList();

        Assert.AreEqual(1, list.Count);
        var s = list[0];
        Assert.AreEqual("2001:db8::1", s.Hostname);
        Assert.AreEqual((ushort)1080, s.Port);
        Assert.AreEqual("user", s.Username);
        Assert.AreEqual("pass", s.Password);
        Assert.AreEqual("IPv6节点", s.Remark);
    }

    [TestMethod]
    public void TestImport_TelegramFormat_Compatibility()
    {
        string tgLink = "https://t.me/socks?server=1.1.1.1&port=443&user=tguser&pass=tgpass";
        var list = _util.ParseUri(tgLink).Cast<Socks5Server>().ToList();

        Assert.AreEqual(1, list.Count);
        var s = list[0];
        Assert.AreEqual("1.1.1.1", s.Hostname);
        Assert.AreEqual((ushort)443, s.Port);
        Assert.AreEqual("tguser", s.Username);
        Assert.AreEqual("tgpass", s.Password);
    }

    [TestMethod]
    public void TestShareLink_ParseText_Integration()
    {
        string multiLine = @"
socks5://dXNlcm5hbWU6cGFzc3dvcmRAMTkyLjE2OC4xLjEwMDoxMDgw#整体Base64
socks5://dXNlcm5hbWU6cGFzc3dvcmQ=@192.168.1.101:1080#账号密码Base64
socks4://192.168.1.102:1080#S4节点
https://t.me/socks?server=1.1.1.1&port=443
";
        var servers = ShareLink.ParseText(multiLine);
        Assert.AreEqual(4, servers.Count);
    }
}

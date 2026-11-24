using Microsoft.VisualStudio.TestTools.UnitTesting;
using Netch.Services;

namespace Tests;

[TestClass]
public class BinIntegrityTests
{
    [TestMethod]
    public void TestParseChecksumContent_VariousFormats()
    {
        var sample = @"
# This is a comment
9840946762fa8c2673738bbbbab22bb720bde931f6dea327eb58e689babc37dc *GeoLite2-Country.mmdb
f0519b24f076f52f12353d955ef89863963b5988130233673f2f4a4445e842cc  nfapi.dll
4af6f672119f4f13e33b8914630eedea97d299b5c92c2105a4015dd0ca6e933e nfdriver.sys
38b55c28aadfb3221557437fc4460451af344a509b604b83503c92913eb99ba3 *stun.txt
";
        var dict = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        BinIntegrityService.ParseChecksumContent(sample, dict);

        Assert.AreEqual(3, dict.Count);
        Assert.IsTrue(dict.ContainsKey("GeoLite2-Country.mmdb"));
        Assert.AreEqual("9840946762fa8c2673738bbbbab22bb720bde931f6dea327eb58e689babc37dc", dict["geolite2-country.mmdb"]);
        Assert.IsTrue(dict.ContainsKey("nfapi.dll"));
        Assert.AreEqual("f0519b24f076f52f12353d955ef89863963b5988130233673f2f4a4445e842cc", dict["nfapi.dll"]);
        Assert.IsTrue(dict.ContainsKey("nfdriver.sys"));
        Assert.AreEqual("4af6f672119f4f13e33b8914630eedea97d299b5c92c2105a4015dd0ca6e933e", dict["nfdriver.sys"]);
        Assert.IsFalse(dict.ContainsKey("stun.txt"), "stun.txt should be excluded from integrity validation");
    }

    [TestMethod]
    public void TestLoadExpectedHashes_FindsCoreFiles()
    {
        var hashes = BinIntegrityService.LoadExpectedHashes();
        Assert.IsTrue(hashes.Count >= 9, $"Expected at least 9 checksum entries, got {hashes.Count}");
        Assert.IsTrue(hashes.ContainsKey("Redirector.bin"), "Should contain Redirector.bin");
        Assert.IsTrue(hashes.ContainsKey("RouteHelper.bin"), "Should contain RouteHelper.bin");
        Assert.IsTrue(hashes.ContainsKey("tun2socks.bin"), "Should contain tun2socks.bin");
        Assert.IsTrue(hashes.ContainsKey("pcap2socks.exe"), "Should contain pcap2socks.exe");
        Assert.IsFalse(hashes.ContainsKey("stun.txt"), "stun.txt should not be present in expected hashes");
    }
}

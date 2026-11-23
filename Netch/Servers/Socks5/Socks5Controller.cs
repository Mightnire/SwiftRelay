using Netch.Interfaces;
using Netch.Models;

namespace Netch.Servers;

public class Socks5Controller : IServerController
{
    public string Name => "Socks5";

    public ushort? Socks5LocalPort { get; set; }

    public string? LocalAddress { get; set; }

    public Task<Socks5Server> StartAsync(Server s)
    {
        return Task.FromResult((Socks5Server)s);
    }

    public Task StopAsync()
    {
        return Task.CompletedTask;
    }
}

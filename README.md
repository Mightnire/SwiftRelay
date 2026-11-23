<p align="center">
  <img src="Netch/Resources/Netch.png" width="128" alt="SwiftRelay Logo" />
</p>

<div align="center">

# SwiftRelay
A lightweight, pure Socks5 proxy and game routing client for Windows.

[![](https://img.shields.io/github/v/release/Mightnire/SwiftRelay?style=flat-square)](https://github.com/Mightnire/SwiftRelay/releases)
[![](https://img.shields.io/github/license/Mightnire/SwiftRelay?style=flat-square)](LICENSE)

</div>

---

## 🌟 Overview

**SwiftRelay** is a dedicated game and process network routing utility focused exclusively on standard **Socks5** proxies. Refactored and streamlined from Netch:

- **Pure & Lightweight**: Completely stripped of all circumvention/GFW protocols (Shadowsocks, SSR, VMess, VLESS, Trojan, WireGuard, etc.) and unnecessary subscription logic.
- **Process & Game Traffic Interception**: Seamlessly proxy individual game processes and applications without modifying system-wide proxy settings.
- **High Performance**: Native network redirection drivers ensuring ultra-low overhead, FullCone NAT support, and stable game latency.

## 🚀 Modes

- **ProcessMode** (`NetFilter`): Intercepts traffic at the socket level for selected processes and executables. Ideal for game acceleration.
- **TunMode** (`WinTUN`): Creates a virtual network adapter to route IP traffic.
- **ShareMode** (`pcap2socks`): Shares your proxy to other devices in the local network (such as consoles like Switch / PS5).

## 📦 Supported Protocol

- **Socks5** (Supports IP/Domain target, Port, and optional Username / Password authentication)

## 🛠️ Building from Source

### Prerequisites

- Windows 10 (Build 17763+) or Windows 11
- [.NET SDK 6.0+](https://dotnet.microsoft.com/download)
- MinGW-w64 (GCC/G++ 11+) or Visual Studio MSBuild with C++ toolchain

### Build Commands

```powershell
# Run the build script
.\build.ps1 -Configuration Release -OutputPath release
```

The output single-file executable `SwiftRelay.exe` and its supporting native drivers/binaries will be placed in the `release/` directory.

## 📄 License

SwiftRelay is licensed under the [GPLv3](LICENSE) license.

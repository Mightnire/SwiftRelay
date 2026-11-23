> [!CAUTION]
> #### Mightnire (https://github.com/Mightnire) and its SwiftRelay series of products, developed based on the source code of Netch (https://github.com/netchx/netch), are not affiliated with, or authorized, endorsed, or licensed in any way by any game publishers or network operators, their affiliates, or subsidiaries.
>
> #### SwiftRelay functions solely as a local network traffic router and standard Socks (Socks5 / Socks4a / Socks4) relay utility. It does not include any built-in network nodes or acceleration routes, and all node configurations used within the software are manually entered by the user. SwiftRelay cannot and does not inspect, verify, or guarantee the source, security, stability, or compliance of the nodes entered by the user, nor does it make any warranties regarding their legality; users are solely responsible for ensuring that the network access services and node configurations they use comply with applicable local laws, regulations, and relevant terms of service.
>
> #### SwiftRelay is only compatible with a limited number of applications and online games. The terms of service of certain online platforms, software, or games explicitly prohibit the use of unauthorized traffic routing or network acceleration tools; forced use may result in account restrictions, suspensions, or permanent bans. Furthermore, compatible programs may still exhibit some defects, including, but not limited to, partial or all traffic of the target program failing to be proxied and resulting in a direct connection, latency fluctuations, packet loss, connection drops, system driver compatibility issues, etc., which may affect how the programs perform. Users must review the terms of service of the target platform, software, or game prior to use, and assume full responsibility for any account penalties or losses incurred.
>
> #### The SwiftRelay name and icon were generated with the assistance of Gemini and are used in this project by Mightnire (https://github.com/Mightnire).
>
> #### Windows is a registered trademark of Microsoft Corporation. All other third-party software, drivers, and game titles mentioned are registered trademarks of their respective owners.
>
> #### The above statements are subject to change by Mightnire (https://github.com/Mightnire) without notice.

<p align="center">
  <img src="Netch/Resources/Netch.png" width="128" alt="SwiftRelay Logo" />
</p>

<div align="center">

# SwiftRelay
A lightweight, pure Socks proxy and game routing client for Windows.

[![](https://img.shields.io/github/v/release/Mightnire/SwiftRelay?style=flat-square)](https://github.com/Mightnire/SwiftRelay/releases)
[![](https://img.shields.io/github/license/Mightnire/SwiftRelay?style=flat-square)](LICENSE)

[English](README_EN.md) | [简体中文](README.md)

</div>

---

## 🌟 Overview

**SwiftRelay** is a dedicated game and process network routing utility focused exclusively on standard **Socks (Socks5 / Socks4a / Socks4)** proxies:

- **Pure & Dedicated**: Focused solely on standard Socks proxy relays, offering a clean, streamlined, and lightweight local routing environment without unnecessary overhead.
- **Process & Game Traffic Interception**: Seamlessly proxy individual game processes and applications without modifying system-wide proxy settings.
- **High Performance**: Native network redirection drivers ensuring ultra-low overhead, FullCone NAT support, and stable game latency.

## 🚀 Modes

- **ProcessMode** (`NetFilter`): Intercepts traffic at the socket level for selected processes and executables. Ideal for game acceleration.
- **TunMode** (`WinTUN`): Creates a virtual network adapter to route IP traffic.
- **ShareMode** (`pcap2socks`): Shares your proxy to other devices in the local network (such as consoles like Switch / PS5).

## 📦 Supported Protocols

- **Socks5** (Full standard Socks5 proxy support, including target address/domain, port, and optional username/password authentication)
- **Socks4a** (Supports remote domain name resolution via proxy)
- **Socks4** (Standard Socks4 proxy support based on IPv4 addresses)

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

## 🙏 Acknowledgments

This project is modified from [Netch](https://github.com/netchx/netch), originally created by [AmazingDM](https://github.com/AmazingDM). The upstream code baseline is at commit [`9d99eb1`](https://github.com/netchx/netch/tree/9d99eb1c5a2acbf2a34f2600f94242601019a300). Special thanks to AmazingDM and the open-source community for their contributions.

## 📄 License

SwiftRelay is licensed under the [GPLv3](LICENSE) license.

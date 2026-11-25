> [!CAUTION]
> #### Mightnire (https://github.com/Mightnire) and its SwiftRelay series of products, developed based on the source code of Netch (https://github.com/netchx/netch), are not affiliated with, or authorized, endorsed, or licensed in any way by any game publishers or network operators, their affiliates, or subsidiaries.
>
> #### SwiftRelay is a local network forwarding utility supporting standard Socks (Socks5 / Socks4a / Socks4) only. It does not include any built-in servers or acceleration routes, and all server configurations used in the software are manually entered by the user. SwiftRelay cannot and does not inspect, verify, or guarantee the source, security, stability, or compliance of user-entered servers, nor does it make any warranties regarding their legality.
>
> #### SwiftRelay is only compatible with a limited number of applications and online games. The terms of service of certain online platforms, software, or games[^1] explicitly prohibit the use of unauthorized traffic routing or network acceleration tools; forced use may result in account restrictions, suspensions, or permanent bans. Furthermore, compatible programs may still exhibit some defects, including, but not limited to, partial or all traffic of the target program failing to be proxied and resulting in a direct connection, latency fluctuations, packet loss, connection drops, system driver compatibility issues, etc., which may affect how the programs perform.
>
> #### The SwiftRelay name and icon were generated with the assistance of Gemini and are used in this project by Mightnire (https://github.com/Mightnire).
>
> #### Windows is a registered trademark of Microsoft Corporation. All other third-party software, drivers, and game titles mentioned are registered trademarks of their respective owners.
>
> #### The above statements are subject to change by Mightnire (https://github.com/Mightnire) without notice.

<p align="center">
  <img src="Netch/Resources/SwiftRelay.png" width="128" alt="SwiftRelay Logo" />
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

- `Socks5`
- `Socks4a`
- `Socks4`

## Usage

### 1. Basic Workflow
1. **Add a server**: Use **Server → Import Servers From Clipboard** or **Add [...] Server...** to enter your Socks server.
2. **Pick a mode**: Select a Process or TUN mode from **Mode** (or save/switch up to 4 quick profiles at the bottom).
3. **Start**: Click **Start**. Process Mode automatically installs the `netfilter2` kernel driver on first run; you can remove it later via **Options → Uninstall NetFilter Service**.
4. **Customize built-in rules**: Built-in `.txt` modes are read-only; adjust rules in the editor and click **Save As...** to save an editable custom `.json` copy under `mode\Custom\`.

### 2. Multi-Mode Selector & Mode Groups
Click the multi-select icon next to Mode (or **Mode → Multi-Mode Selector / Group Manager...**):
- **Search, sort & preview**: Filter modes by name or process, click the **Select** column to group checked modes, preview handle/bypass rules on the right, and click **Edit Mode** to adjust individual modes directly.
- **Combine or save**: Check two or more process modes and click **Apply** to use them together temporarily, or **Save as Mode Group...** to keep the combined group for one-click reuse.

## 💻 Runtime Requirements & Downloads

SwiftRelay provides two different release packages:

| Edition | File | Archive Size | Description |
| :--- | :--- | :--- | :--- |
| **Self-Contained** | `SwiftRelay.7z` | ~33 MB | **Ready to use out-of-the-box**. Bundles the complete .NET runtime. Recommended if you do not want to install extra runtimes. |
| **Framework-Dependent** | `SwiftRelay-Framework-Dependent.7z` | ~7.5 MB | **Ultra-lightweight**. Excludes the bundled runtime to drastically reduce download size. **Requires** the .NET 6.0 Desktop Runtime to be installed on your system. |

### Required Runtimes (For Framework-Dependent Edition)

If you download the **Framework-Dependent** edition, make sure the following runtime libraries are installed on your Windows machine:

1. **[.NET Desktop Runtime 6.0 (x64)](https://aka.ms/dotnet/6.0/windowsdesktop-runtime-win-x64.exe)** (Required)
   - Direct Installer Download: [windowsdesktop-runtime-6.0.*-win-x64.exe](https://aka.ms/dotnet/6.0/windowsdesktop-runtime-win-x64.exe)
   - Microsoft Official Page: [Microsoft .NET 6.0 Download Center](https://dotnet.microsoft.com/download/dotnet/6.0)
   > [!IMPORTANT]
   > Make sure to install the **.NET Desktop Runtime (x64)**. The standard .NET Runtime or ASP.NET Core Runtime does not include Windows Forms / Desktop UI components.

2. **[Microsoft Visual C++ 2015-2022 Redistributable (x64)](https://aka.ms/vs/17/release/vc_redist.x64.exe)** (Required)
   - Direct Installer Download: [vc_redist.x64.exe](https://aka.ms/vs/17/release/vc_redist.x64.exe)
   > [!NOTE]
   > SwiftRelay's native core redirection drivers (NetFilter), WinTUN, and routing helpers are written in native C++ and require the 64-bit VC++ redistributable. Most gaming PCs already have this installed.

## 🛠️ Building from Source

### Prerequisites

- Windows 10 (Build 17763+) or Windows 11
- [.NET SDK 6.0+](https://dotnet.microsoft.com/download)
- MinGW-w64 (GCC/G++ 11+) or Visual Studio MSBuild with C++ toolchain

### Build Commands

Run the build script in PowerShell:

```powershell
# 1. Build Self-Contained edition (bundled runtime, outputs to release/ directory)
.\build.ps1 -Configuration Release -OutputPath release -SelfContained $True

# 2. Build Framework-Dependent edition (lightweight, outputs to release-framework-dependent/ directory)
.\build.ps1 -Configuration Release -OutputPath release-framework-dependent -SelfContained $False
```

The output single-file executable `SwiftRelay.exe` and its supporting native drivers/binaries will be placed in the specified output directory.

## 🙏 Acknowledgments

This project is modified from [Netch](https://github.com/netchx/netch), originally created by [AmazingDM](https://github.com/AmazingDM). The upstream code baseline is at commit [`9d99eb1`](https://github.com/netchx/netch/tree/9d99eb1c5a2acbf2a34f2600f94242601019a300). Special thanks to AmazingDM and the open-source community for their contributions.

## 📄 License

SwiftRelay is licensed under the [GPLv3](LICENSE) license.

[^1]: Example: [Honkai: Star Rail Terms of Service](https://sr.mihoyo.com/terms/user#:~:text=%E7%BD%91%E7%BB%9C%E5%8A%A0%E9%80%9F%E5%99%A8)

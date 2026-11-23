<p align="center">
  <img src="Netch/Resources/Netch.png" width="128" alt="SwiftRelay 图标" />
</p>

<div align="center">

# SwiftRelay
专为 Windows 设计的轻量级纯 Socks5 游戏进程分流与代理路由工具

[![](https://img.shields.io/github/v/release/Mightnire/SwiftRelay?style=flat-square)](https://github.com/Mightnire/SwiftRelay/releases)
[![](https://img.shields.io/github/license/Mightnire/SwiftRelay?style=flat-square)](LICENSE)

[English](README.md) | [简体中文](README_CN.md)

</div>

---

> [!IMPORTANT]
> ### ⚠️ 免责声明 (Disclaimer)
>
> 1. **仅供技术学习与合规使用**：本项目为开源软件，仅供网络技术研究、协议学习以及合规的本地网络优化（例如游戏玩家通过自建合法私有 Socks5 中继进行游戏联机网络延迟优化与分流）。
> 2. **坚决剥离翻墙功能**：本项目已**彻底、永久移除了所有涉及突破网络审查、绕过国家防火墙（GFW）的非标及混淆代理协议**（包括但不限于 Shadowsocks、ShadowsocksR、VMess、VLESS、Trojan、WireGuard 等）以及订阅下载模块，**仅保留通用的标准 Socks5 协议**。
> 3. **遵守法律法规**：任何个人或组织使用本软件时，必须严格遵守所在国家与地区的法律法规。严禁将本工具用于任何侵犯他人权益、危害网络安全或从事非法跨境传输等违法违规活动。
> 4. **免责条款**：使用者须对其使用行为承担全部直接及连带法律责任。作者及贡献者对因使用、分发或修改本软件所产生的任何直接、间接损失或法律后果概不负责。

---

## 🌟 项目简介

**SwiftRelay** 是基于开源项目 Netch 进行深度精简与现代化重构的 Windows 网络分流客户端，专精于标准的 **Socks5** 协议转发与游戏进程加速：

- **纯粹精简**：彻底剥离了一切不合规的特定翻墙协议与繁杂的订阅功能，还原为轻便干练的网络工具。
- **进程级精确分流**：无需修改系统全局代理，支持针对特定的游戏、应用程序执行套接字（Socket）级流量捕获与路由。
- **超低开销与高性能**：内置原生底层网络重定向驱动，支持 FullCone NAT（依赖服务端网络支持），保障联机游戏低延迟与稳定性。

## 🚀 运行模式说明

- **进程模式** (`ProcessMode`，基于 NetFilter)：
  在驱动层精准拦截并代理指定进程（如特定游戏 exe）的网络流量，不影响浏览器与其它日常软件运行，是游戏网络优化的理想模式。
- **虚拟网卡模式** (`TunMode`，基于 WinTUN)：
  创建高性能虚拟网络适配器，接管特定 IP 段或网段的流量路由。
- **局域网共享模式** (`ShareMode`，基于 pcap2socks)：
  将本机代理网络共享给局域网内的其它设备（如 Switch、PS5、Xbox 等游戏主机加速）。

## 📦 支持协议

- **Socks5**（支持目标服务器地址/域名、端口，以及可选的用户名/密码身份验证）

## 🛠️ 源码编译指南

### 编译环境要求

- 操作系统：Windows 10（版本 17763+）或 Windows 11
- [.NET SDK 6.0+](https://dotnet.microsoft.com/download)
- MinGW-w64（GCC/G++ 11+）或安装了 C++ 编译套件的 Visual Studio / MSBuild

### 编译与打包步骤

在项目根目录下通过 PowerShell 运行打包脚本：

```powershell
# 运行打包脚本生成发布文件
.\build.ps1 -Configuration Release -OutputPath release
```

打包完成后，单文件可执行程序 `SwiftRelay.exe` 及其所依赖的驱动与原生动态库将输出在 `release/` 目录下。

## 📄 开源许可证

SwiftRelay 基于 [GPLv3](LICENSE) 许可证开源。

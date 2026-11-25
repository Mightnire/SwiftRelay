> [!CAUTION]
> #### 在此声明 [Mightnire](https://github.com/Mightnire) 和其在 [Netch](https://github.com/netchx/netch) 源代码基础上开发的 SwiftRelay 系列产品，并不和任何游戏发行商或网络运营商的相关企业有任何关系，亦未取得其产品或网络服务的使用权、授权或专利权。
>
> #### SwiftRelay 是一个本地网络转发工具，本身不包括任何网络节点或加速线路，软件内使用的所有节点配置均由用户自行手动输入。SwiftRelay 不能也无法对用户输入节点的来源、安全性、稳定性及合规性进行审查或验证，亦不对其合法性作任何担保。
>
> #### SwiftRelay 只和有限数量的应用程序及联机游戏兼容。部分在线平台、软件或游戏的服务条款<sup>[[1]](#ref-1)</sup>明确禁止使用未经授权的流量转发或网络加速工具，强行使用可能会导致账号受限、冻结甚至永久封禁。此外，即便在兼容的程序或游戏中运行，仍可能存在一些缺陷，包括且不只限于以下影响正常使用的地方：目标程序的部分或全部流量未被成功代理而直接连接、延迟波动、数据包丢失、连接中断、系统驱动兼容异常等等。
>
> #### SwiftRelay 名称及图标由 Gemini 辅助生成，并用于 [Mightnire](https://github.com/Mightnire) 的本项目中。
>
> #### Windows 是 Microsoft Corporation 的注册商标。其他提及的第三方软件、驱动程序及游戏名称均为其各自所有者的注册商标。
>
> #### [Mightnire](https://github.com/Mightnire) 可以在不通知用户的情况下改变以上的声明。

<p align="center">
  <img src="Netch/Resources/SwiftRelay.png" width="128" alt="SwiftRelay 图标" />
</p>

<div align="center">

# SwiftRelay
专为 Windows 设计的轻量级纯 Socks 游戏进程分流与网络路由工具

[![](https://img.shields.io/github/v/release/Mightnire/SwiftRelay?style=flat-square)](https://github.com/Mightnire/SwiftRelay/releases)
[![](https://img.shields.io/github/license/Mightnire/SwiftRelay?style=flat-square)](LICENSE)

[简体中文](README.md) | [English](README_EN.md)

</div>

---

## 项目简介

**SwiftRelay** 是一款专为 Windows 设计的轻量级网络分流与游戏加速工具，专注基于标准 **Socks (Socks5 / Socks4a / Socks4)** 协议的进程级流量调度与网络路由：

- **轻量专精**：专精于标准 Socks 代理中继，提供干净、纯粹、无多余负担的本地网络转发环境。
- **进程级精确分流**：无需修改系统全局代理，支持针对特定的游戏、应用程序执行套接字（Socket）级流量捕获与路由。
- **超低开销与高性能**：内置原生底层网络重定向驱动，支持 FullCone NAT（依赖服务端网络支持），保障联机游戏低延迟与稳定性。

## 运行模式说明

- **进程模式** (`ProcessMode`，基于 NetFilter)：
  在驱动层精准拦截并代理指定进程（如特定游戏 exe）的网络流量，不影响浏览器与其它日常软件运行，是游戏网络优化的理想模式。
- **虚拟网卡模式** (`TunMode`，基于 WinTUN)：
  创建高性能虚拟网络适配器，接管特定 IP 段或网段的流量路由。
- **局域网共享模式** (`ShareMode`，基于 pcap2socks)：
  将本机代理网络共享给局域网内的其它设备（如 Switch、PS5、Xbox 等游戏主机加速）。

## 支持协议

- `Socks5`
- `Socks4a`
- `Socks4`

## 使用指南

### 1. 日常使用
1. **添加节点**：点击顶部菜单 **服务器 → 从剪贴板导入服务器** 或 **添加 [...] 服务器...** 填入你的 Socks 节点（可点击主界面测速按钮测试延迟）。
2. **选择模式**：在 **模式** 下拉框选择内置或自定义规则；也可以在主界面填写“配置名”，配合底部最多 4 个快捷配置按钮一键保存和切换。
3. **启动与停止**：点击右下角 **启动** 即可开始转发流量；首次使用进程模式会自动安装 `netfilter2` 内核驱动，如果以后彻底不用了，可在 **选项 → 卸载 NetFilter 服务** 里清理。
4. **编辑与另存为**：内置 `.txt` 模式为只读；打开编辑器修改规则或选项后，点击 **“另存为...”** 即可保存成可编辑的自定义 `.json` 副本（保存在 `mode\Custom\` 下）。

### 2. 特色功能：多模式选择器与模式组
点击模式栏右侧的多选图标，或通过 **模式 → 多模式选择器 / 模式组管理...** 打开：
- **搜索与筛选**：支持按模式名称、文件名或进程名关键词实时检索；点击表头“选择”列可快速把已勾选项排到前面，点击任意行可在右侧实时预览协议开关、加速进程与分流规则。
- **直接修改单条模式**：选中任意单个模式后点 **“编辑模式”**，可直接打开进程模式编辑器查看或调整（内置模式可通过 **“另存为...”** 存成自定义副本并自动加入列表）。
- **临时合并 / 存为模式组**：勾选多个进程模式后：
  - 点 **“应用临时组合”** 可把选中模式的规则与协议设置合并后直接生效；
  - 点 **“另存为模式组...”** 可将这套组合持久保存下来，之后直接在主界面下拉框里选中即可。

## 运行环境与安装说明

SwiftRelay 发布页面提供两种版本供您选择：

| 版本 | 文件名 | 压缩包体积 | 说明 |
| :--- | :--- | :--- | :--- |
| **独立版 (Self-Contained)** | `SwiftRelay.7z` | 约 33 MB | **开箱即用**。内置完整 .NET 运行时，解压后双击即可运行，适合不希望在系统中安装额外运行库的用户。 |
| **依赖运行库版 (Framework-Dependent)** | `SwiftRelay-Framework-Dependent.7z` | 约 7.5 MB | **极简轻量**。移除了内置运行时，大幅减少下载体积与磁盘占用。运行前**必须**确保系统中已安装所需的桌面运行时。 |

### 运行库下载（使用“依赖运行库版”必须安装）

如果使用**依赖运行库版**，请在启动前下载并安装以下运行库：

#### 1. [.NET Desktop Runtime 6.0 (x64) 桌面运行时](https://aka.ms/dotnet/6.0/windowsdesktop-runtime-win-x64.exe)（必须）
- 官方直链下载：[windowsdesktop-runtime-6.0.*-win-x64.exe](https://aka.ms/dotnet/6.0/windowsdesktop-runtime-win-x64.exe)
- 微软官方总览页：[Microsoft .NET 6.0 下载中心](https://dotnet.microsoft.com/download/dotnet/6.0)

> [!IMPORTANT]
> 请务必选择 **.NET Desktop Runtime（桌面运行时）x64** 版本。普通的 .NET Runtime 或 ASP.NET Core Runtime 不包含 Windows 桌面图形界面组件。

#### 2. [Microsoft Visual C++ 2015-2022 Redistributable (x64)](https://aka.ms/vs/17/release/vc_redist.x64.exe)（必须）
- 官方直链下载：[vc_redist.x64.exe](https://aka.ms/vs/17/release/vc_redist.x64.exe)

> [!NOTE]
> SwiftRelay 的流量重定向驱动（NetFilter）、WinTUN 以及底层路由辅助模块由原生 C++ 编写，需要 64 位 VC++ 运行库支持。大多数游戏电脑通常已预装此运行库，如遇到闪退或提示缺少 DLL，请安装此包。

## 源码编译指南

### 编译环境要求

- 操作系统：Windows 10（版本 17763+）或 Windows 11
- [.NET SDK 6.0+](https://dotnet.microsoft.com/download)
- MinGW-w64（GCC/G++ 11+）或安装了 C++ 编译套件的 Visual Studio / MSBuild

### 编译与打包步骤

在项目根目录下通过 PowerShell 运行打包脚本：

```powershell
# 1. 编译生成独立版（Self-Contained，内置运行环境，输出至 release/ 目录）
.\build.ps1 -Configuration Release -OutputPath release -SelfContained $True

# 2. 编译生成依赖运行库版（Framework-Dependent，需安装.NET 6桌面运行时，输出至 release-framework-dependent/ 目录）
.\build.ps1 -Configuration Release -OutputPath release-framework-dependent -SelfContained $False
```

打包完成后，单文件可执行程序 `SwiftRelay.exe` 及其所依赖的驱动与原生动态库将输出在指定的输出目录下。

## 鸣谢

本项目基于 [AmazingDM](https://github.com/AmazingDM) 发起的开源项目 [Netch](https://github.com/netchx/netch) 修改而来，上游代码截止到 commit [`9d99eb1`](https://github.com/netchx/netch/tree/9d99eb1c5a2acbf2a34f2600f94242601019a300)。在此特别感谢原作者 AmazingDM 和开源社区的付出与贡献。

## 开源许可证

SwiftRelay 基于 [GPLv3](LICENSE) 许可证开源。

---

<a id="ref-1"></a>[1] [《米哈游游戏使用许可及服务协议》](https://webstatic.mihoyo.com/upload/static-resource/2022/12/08/1da4a577c63ebcc06c942573a85de0c4_6176837470568754622.pdf#:~:text=%E7%BD%91%E7%BB%9C%E5%8A%A0%E9%80%9F%E5%99%A8)（[Steam](https://store.steampowered.com/eula/1668940_eula_0#:~:text=%E7%BD%91%E7%BB%9C%E5%8A%A0%E9%80%9F%E5%99%A8)）

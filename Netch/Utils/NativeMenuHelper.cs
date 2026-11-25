using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Netch.Utils;

/// <summary>
/// Manages genuine Win32 native <c>HMENU</c> menu bars and popup context menus
/// so Windows 10 and Windows 11 render menus using native OS visual styles.
/// </summary>
public sealed class NativeMenuHelper : IDisposable
{
    public const int WM_COMMAND = 0x0111;

    private const uint CmdIdBase = 0x5000;
    private const uint MIIM_STATE = 0x00000001;
    private const uint MIIM_ID = 0x00000002;
    private const uint MIIM_SUBMENU = 0x00000004;
    private const uint MIIM_FTYPE = 0x00000100;
    private const uint MIIM_STRING = 0x00000040;
    private const uint MFT_STRING = 0x00000000;
    private const uint MFT_RIGHTJUSTIFY = 0x00004000;
    private const uint MFS_ENABLED = 0x00000000;
    private const uint MFS_DISABLED = 0x00000003;
    private const uint MF_BYCOMMAND = 0x00000000;
    private const uint MF_ENABLED = 0x00000000;
    private const uint MF_GRAYED = 0x00000001;
    private const uint TPM_LEFTALIGN = 0x0000;
    private const uint TPM_RIGHTBUTTON = 0x0002;
    private const uint TPM_RETURNCMD = 0x0100;

    private readonly Dictionary<uint, Action> _commands = new();
    private IntPtr _mainMenuHandle;
    private uint _nextId = CmdIdBase;

    public uint ServerMenuId { get; private set; }
    public uint ModeMenuId { get; private set; }
    public uint UninstallServiceItemId { get; private set; }
    public uint NewVersionItemId { get; private set; }

    public sealed record ServerAddEntry(string FullName, Action OnClick);

    public sealed class MenuSpec
    {
        public bool CoreIdleEnabled { get; init; } = true;
        public Action OnImportServersFromClipboard { get; init; } = null!;
        public IReadOnlyList<ServerAddEntry> ServerAddItems { get; init; } = Array.Empty<ServerAddEntry>();
        public Action OnCreateProcessMode { get; init; } = null!;
        public Action OnCreateRouteTableMode { get; init; } = null!;
        public Action OnMultiMode { get; init; } = null!;
        public Action OnReloadModes { get; init; } = null!;
        public Action OnOpenDirectory { get; init; } = null!;
        public Action OnShowHideConsole { get; init; } = null!;
        public Action OnCleanDnsCache { get; init; } = null!;
        public Action OnVerifyBinFiles { get; init; } = null!;
        public Action OnUninstallService { get; init; } = null!;
        public Action OnRemoveFirewallRules { get; init; } = null!;
        public Action OnCheckForUpdates { get; init; } = null!;
        public Action OnFaq { get; init; } = null!;
        public Action OnExit { get; init; } = null!;
        public string VersionText { get; init; } = string.Empty;
        public Action OnVersionClick { get; init; } = null!;
        public bool NewVersionVisible { get; init; }
        public bool NewVersionEnabled { get; init; } = true;
        public string NewVersionText { get; init; } = string.Empty;
        public Action OnNewVersionClick { get; init; } = null!;
        public Action OnAboutClick { get; init; } = null!;
    }

    public void AttachOrRebuild(Form owner, MenuSpec spec)
    {
        if (!owner.IsHandleCreated)
            return;

        _commands.Clear();
        _nextId = CmdIdBase;
        NewVersionItemId = 0;

        var hMain = CreateMenu();
        if (hMain == IntPtr.Zero)
            return;

        // Server popup
        var hServer = CreatePopupMenu();
        AppendItem(hServer, i18N.Translate("Import Servers From Clipboard"), spec.OnImportServersFromClipboard);
        foreach (var entry in spec.ServerAddItems)
        {
            AppendItem(hServer, i18N.TranslateFormat("Add {0} Server...", entry.FullName), entry.OnClick);
        }
        ServerMenuId = AppendSubMenu(hMain, i18N.Translate("Server"), hServer, enabled: spec.CoreIdleEnabled);

        // Mode popup
        var hMode = CreatePopupMenu();
        AppendItem(hMode, i18N.Translate("Create Process Mode..."), spec.OnCreateProcessMode);
        AppendItem(hMode, i18N.Translate("Create Route Table Rule..."), spec.OnCreateRouteTableMode);
        AppendItem(hMode, i18N.Translate("Multi-Mode Selector / Group Manager..."), spec.OnMultiMode);
        AppendItem(hMode, i18N.Translate("Reload Modes"), spec.OnReloadModes);
        ModeMenuId = AppendSubMenu(hMain, i18N.Translate("Mode"), hMode, enabled: spec.CoreIdleEnabled);

        // Options popup
        var hOptions = CreatePopupMenu();
        AppendItem(hOptions, i18N.Translate("Open Directory"), spec.OnOpenDirectory);
        AppendItem(hOptions, i18N.Translate("Show/Hide Console"), spec.OnShowHideConsole);
        AppendItem(hOptions, i18N.Translate("Clean DNS Cache"), spec.OnCleanDnsCache);
        AppendItem(hOptions, i18N.Translate("Verify Core Files Integrity"), spec.OnVerifyBinFiles);
        UninstallServiceItemId = AppendItem(hOptions, i18N.TranslateFormat("Uninstall {0}", "NetFilter Service"), spec.OnUninstallService, enabled: spec.CoreIdleEnabled);
        AppendItem(hOptions, i18N.Translate("Remove SwiftRelay Firewall Rules"), spec.OnRemoveFirewallRules);
        AppendSubMenu(hMain, i18N.Translate("Options"), hOptions);

        // Help popup
        var hHelp = CreatePopupMenu();
        AppendItem(hHelp, i18N.Translate("Check for update"), spec.OnCheckForUpdates);
        AppendItem(hHelp, i18N.Translate("FAQ"), spec.OnFaq);
        AppendSubMenu(hMain, i18N.Translate("Help"), hHelp);

        // Top-level Exit
        AppendItem(hMain, i18N.Translate("Exit"), spec.OnExit);

        // Right-justified items: [Version] [NewVersion?] [About]
        AppendItem(hMain, spec.VersionText, spec.OnVersionClick, rightJustify: true);
        if (spec.NewVersionVisible)
        {
            NewVersionItemId = AppendItem(hMain, spec.NewVersionText, spec.OnNewVersionClick, enabled: spec.NewVersionEnabled);
        }
        AppendItem(hMain, i18N.Translate("About"), spec.OnAboutClick);

        var oldMenu = _mainMenuHandle;
        _mainMenuHandle = hMain;
        SetMenu(owner.Handle, hMain);
        DrawMenuBar(owner.Handle);

        if (oldMenu != IntPtr.Zero)
            DestroyMenu(oldMenu);
    }

    public void SetCoreIdleEnabled(Form owner, bool enabled)
    {
        if (!owner.IsHandleCreated || _mainMenuHandle == IntPtr.Zero)
            return;

        var flag = MF_BYCOMMAND | (enabled ? MF_ENABLED : MF_GRAYED);
        if (ServerMenuId != 0)
            EnableMenuItem(_mainMenuHandle, ServerMenuId, flag);
        if (ModeMenuId != 0)
            EnableMenuItem(_mainMenuHandle, ModeMenuId, flag);
        if (UninstallServiceItemId != 0)
            EnableMenuItem(_mainMenuHandle, UninstallServiceItemId, flag);

        DrawMenuBar(owner.Handle);
    }

    public void UpdateNewVersionItemText(Form owner, string text, bool enabled)
    {
        if (!owner.IsHandleCreated || _mainMenuHandle == IntPtr.Zero || NewVersionItemId == 0)
            return;

        var mii = new MENUITEMINFOW
        {
            cbSize = (uint)Marshal.SizeOf<MENUITEMINFOW>(),
            fMask = MIIM_STRING | MIIM_STATE,
            fState = enabled ? MFS_ENABLED : MFS_DISABLED,
            dwTypeData = text
        };
        SetMenuItemInfo(_mainMenuHandle, NewVersionItemId, false, ref mii);
        DrawMenuBar(owner.Handle);
    }

    public bool TryExecuteCommand(Form owner, ref Message m)
    {
        if (m.Msg != WM_COMMAND || m.LParam != IntPtr.Zero)
            return false;

        var hiWord = (int)(((long)m.WParam >> 16) & 0xFFFF);
        if (hiWord != 0)
            return false;

        var cmdId = (uint)((long)m.WParam & 0xFFFF);
        if (!_commands.TryGetValue(cmdId, out var action))
            return false;

        // Dispatch after WndProc returns so modal dialogs and async handlers run outside the menu loop.
        owner.BeginInvoke(action);
        m.Result = IntPtr.Zero;
        return true;
    }

    public static void ShowTrayContextMenu(Form owner, Action onShowMain, Action onExit)
    {
        if (!owner.IsHandleCreated)
            return;

        var hPopup = CreatePopupMenu();
        if (hPopup == IntPtr.Zero)
            return;

        try
        {
            const uint idShow = 1;
            const uint idExit = 2;

            InsertCommand(hPopup, idShow, i18N.Translate("Show"), enabled: true, rightJustify: false);
            InsertCommand(hPopup, idExit, i18N.Translate("Exit"), enabled: true, rightJustify: false);

            SetForegroundWindow(owner.Handle);
            GetCursorPos(out var pt);
            var selected = TrackPopupMenuEx(hPopup, TPM_LEFTALIGN | TPM_RIGHTBUTTON | TPM_RETURNCMD, pt.X, pt.Y, owner.Handle, IntPtr.Zero);
            if (selected == idShow)
                owner.BeginInvoke(onShowMain);
            else if (selected == idExit)
                owner.BeginInvoke(onExit);
        }
        finally
        {
            DestroyMenu(hPopup);
        }
    }

    public void DetachAndDispose(IntPtr ownerHandle)
    {
        _commands.Clear();
        if (_mainMenuHandle == IntPtr.Zero)
            return;

        if (ownerHandle != IntPtr.Zero)
            SetMenu(ownerHandle, IntPtr.Zero);

        DestroyMenu(_mainMenuHandle);
        _mainMenuHandle = IntPtr.Zero;
    }

    public void Dispose()
    {
        _commands.Clear();
        if (_mainMenuHandle != IntPtr.Zero)
        {
            DestroyMenu(_mainMenuHandle);
            _mainMenuHandle = IntPtr.Zero;
        }
    }

    private uint AppendItem(IntPtr hMenu, string text, Action onClick, bool enabled = true, bool rightJustify = false)
    {
        var id = _nextId++;
        _commands[id] = onClick;
        InsertCommand(hMenu, id, text, enabled, rightJustify);
        return id;
    }

    private uint AppendSubMenu(IntPtr hMenu, string text, IntPtr hSubMenu, bool enabled = true)
    {
        var id = _nextId++;
        var mii = new MENUITEMINFOW
        {
            cbSize = (uint)Marshal.SizeOf<MENUITEMINFOW>(),
            fMask = MIIM_ID | MIIM_SUBMENU | MIIM_STRING | MIIM_STATE | MIIM_FTYPE,
            fType = MFT_STRING,
            fState = enabled ? MFS_ENABLED : MFS_DISABLED,
            wID = id,
            hSubMenu = hSubMenu,
            dwTypeData = text
        };
        InsertMenuItem(hMenu, uint.MaxValue, true, ref mii);
        return id;
    }

    private static void InsertCommand(IntPtr hMenu, uint id, string text, bool enabled, bool rightJustify)
    {
        var mii = new MENUITEMINFOW
        {
            cbSize = (uint)Marshal.SizeOf<MENUITEMINFOW>(),
            fMask = MIIM_ID | MIIM_STRING | MIIM_STATE | MIIM_FTYPE,
            fType = MFT_STRING | (rightJustify ? MFT_RIGHTJUSTIFY : 0),
            fState = enabled ? MFS_ENABLED : MFS_DISABLED,
            wID = id,
            dwTypeData = text
        };
        InsertMenuItem(hMenu, uint.MaxValue, true, ref mii);
    }

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    private struct MENUITEMINFOW
    {
        public uint cbSize;
        public uint fMask;
        public uint fType;
        public uint fState;
        public uint wID;
        public IntPtr hSubMenu;
        public IntPtr hbmpChecked;
        public IntPtr hbmpUnchecked;
        public IntPtr dwItemData;
        [MarshalAs(UnmanagedType.LPWStr)]
        public string? dwTypeData;
        public uint cch;
        public IntPtr hbmpItem;
    }

    [DllImport("user32.dll", SetLastError = true)]
    private static extern IntPtr CreateMenu();

    [DllImport("user32.dll", SetLastError = true)]
    private static extern IntPtr CreatePopupMenu();

    [DllImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool DestroyMenu(IntPtr hMenu);

    [DllImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool SetMenu(IntPtr hWnd, IntPtr hMenu);

    [DllImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool DrawMenuBar(IntPtr hWnd);

    [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool InsertMenuItem(IntPtr hMenu, uint item, [MarshalAs(UnmanagedType.Bool)] bool fByPosition, ref MENUITEMINFOW lpmii);

    [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool SetMenuItemInfo(IntPtr hMenu, uint item, [MarshalAs(UnmanagedType.Bool)] bool fByPosition, ref MENUITEMINFOW lpmii);

    [DllImport("user32.dll", SetLastError = true)]
    private static extern int EnableMenuItem(IntPtr hMenu, uint uIDEnableItem, uint uEnable);

    [DllImport("user32.dll", SetLastError = true)]
    private static extern uint TrackPopupMenuEx(IntPtr hMenu, uint uFlags, int x, int y, IntPtr hwnd, IntPtr lptpm);

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool SetForegroundWindow(IntPtr hWnd);

    [DllImport("user32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool GetCursorPos(out Point lpPoint);
}

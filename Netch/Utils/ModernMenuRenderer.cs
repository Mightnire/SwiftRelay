using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Netch.Utils;

/// <summary>
/// Clean, flat Windows 11-style renderer for <see cref="MenuStrip"/> and <see cref="ContextMenuStrip"/>.
/// </summary>
public sealed class ModernMenuRenderer : ToolStripProfessionalRenderer
{
    private static readonly Color BarBackColor = Color.FromArgb(249, 250, 251);
    private static readonly Color BarBottomBorderColor = Color.FromArgb(228, 231, 235);
    private static readonly Color DropDownBackColor = Color.White;
    private static readonly Color DropDownBorderColor = Color.FromArgb(218, 221, 226);
    private static readonly Color HoverFillColor = Color.FromArgb(232, 240, 254);
    private static readonly Color PressedFillColor = Color.FromArgb(219, 232, 253);
    private static readonly Color SeparatorColor = Color.FromArgb(232, 234, 237);
    private static readonly Color TextNormalColor = Color.FromArgb(32, 33, 36);
    private static readonly Color TextDisabledColor = Color.FromArgb(154, 160, 166);

    public ModernMenuRenderer() : base(new ModernMenuColorTable())
    {
        RoundedEdges = false;
    }

    public static void Apply(MenuStrip menuStrip, ContextMenuStrip? contextMenu = null, Func<int, int>? scale = null)
    {
        scale ??= v => v;
        var renderer = new ModernMenuRenderer();

        menuStrip.Renderer = renderer;
        menuStrip.BackColor = BarBackColor;
        menuStrip.Padding = new Padding(scale(6), scale(3), scale(6), scale(3));

        foreach (ToolStripItem item in menuStrip.Items)
        {
            if (item is ToolStripMenuItem menuItem)
            {
                menuItem.Padding = new Padding(scale(6), scale(3), scale(6), scale(3));
                ConfigureDropDown(menuItem.DropDown, scale);
            }
            else if (item is ToolStripButton btn)
            {
                btn.Padding = new Padding(scale(6), scale(3), scale(6), scale(3));
            }
        }

        if (contextMenu != null)
        {
            contextMenu.Renderer = renderer;
            ConfigureDropDown(contextMenu, scale);
        }
    }

    public static void ConfigureDropDown(ToolStripDropDown dropDown, Func<int, int>? scale = null)
    {
        scale ??= v => v;
        if (dropDown is ToolStripDropDownMenu menu)
        {
            menu.ShowImageMargin = false;
            menu.ShowCheckMargin = false;
        }

        dropDown.BackColor = DropDownBackColor;
        dropDown.Padding = new Padding(scale(4));

        foreach (ToolStripItem sub in dropDown.Items)
        {
            sub.Padding = new Padding(scale(8), scale(5), scale(14), scale(5));
            if (sub is ToolStripMenuItem subMenu && subMenu.HasDropDownItems)
                ConfigureDropDown(subMenu.DropDown, scale);
        }
    }

    protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
    {
        if (e.ToolStrip is MenuStrip)
        {
            using var pen = new Pen(BarBottomBorderColor);
            e.Graphics.DrawLine(pen, 0, e.ToolStrip.Height - 1, e.ToolStrip.Width, e.ToolStrip.Height - 1);
            return;
        }

        if (e.ToolStrip is ToolStripDropDown)
        {
            using var pen = new Pen(DropDownBorderColor);
            var rect = new Rectangle(0, 0, e.ToolStrip.Width - 1, e.ToolStrip.Height - 1);
            e.Graphics.DrawRectangle(pen, rect);
            return;
        }

        base.OnRenderToolStripBorder(e);
    }

    protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
    {
        if (!e.Item.Enabled)
            return;

        var isOpen = e.Item is ToolStripMenuItem mi && mi.DropDown.Visible;
        if (!e.Item.Selected && !isOpen)
            return;

        var bounds = new Rectangle(Point.Empty, e.Item.Size);
        if (e.ToolStrip is ToolStripDropDown)
            bounds.Inflate(-2, -1);
        else
            bounds.Inflate(-1, -1);

        if (bounds.Width <= 0 || bounds.Height <= 0)
            return;

        var fillColor = isOpen || e.Item.Pressed ? PressedFillColor : HoverFillColor;
        var prevMode = e.Graphics.SmoothingMode;
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        using var path = CreateRoundedRect(bounds, 4);
        using var brush = new SolidBrush(fillColor);
        e.Graphics.FillPath(brush, path);
        e.Graphics.SmoothingMode = prevMode;
    }

    protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
    {
        if (!e.Item.Enabled || (!e.Item.Selected && !e.Item.Pressed))
            return;

        var bounds = new Rectangle(Point.Empty, e.Item.Size);
        bounds.Inflate(-1, -1);
        if (bounds.Width <= 0 || bounds.Height <= 0)
            return;

        var prevMode = e.Graphics.SmoothingMode;
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        using var path = CreateRoundedRect(bounds, 4);
        using var brush = new SolidBrush(e.Item.Pressed ? PressedFillColor : HoverFillColor);
        e.Graphics.FillPath(brush, path);
        e.Graphics.SmoothingMode = prevMode;
    }

    protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
    {
        var y = e.Item.Height / 2;
        using var pen = new Pen(SeparatorColor);
        e.Graphics.DrawLine(pen, 8, y, e.Item.Width - 8, y);
    }

    protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
    {
        if (e.Item is not ToolStripLabel)
            e.TextColor = e.Item.Enabled ? TextNormalColor : TextDisabledColor;

        base.OnRenderItemText(e);
    }

    private static GraphicsPath CreateRoundedRect(Rectangle bounds, int radius)
    {
        var d = radius * 2;
        var path = new GraphicsPath();
        path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
        path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
        path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
        path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
        path.CloseFigure();
        return path;
    }

    private sealed class ModernMenuColorTable : ProfessionalColorTable
    {
        public ModernMenuColorTable()
        {
            UseSystemColors = false;
        }

        public override Color MenuStripGradientBegin => BarBackColor;
        public override Color MenuStripGradientEnd => BarBackColor;
        public override Color ToolStripDropDownBackground => DropDownBackColor;
        public override Color MenuBorder => DropDownBorderColor;
        public override Color MenuItemBorder => Color.Transparent;
        public override Color MenuItemSelected => HoverFillColor;
        public override Color MenuItemSelectedGradientBegin => HoverFillColor;
        public override Color MenuItemSelectedGradientEnd => HoverFillColor;
        public override Color MenuItemPressedGradientBegin => PressedFillColor;
        public override Color MenuItemPressedGradientEnd => PressedFillColor;
        public override Color ImageMarginGradientBegin => DropDownBackColor;
        public override Color ImageMarginGradientMiddle => DropDownBackColor;
        public override Color ImageMarginGradientEnd => DropDownBackColor;
        public override Color SeparatorDark => SeparatorColor;
        public override Color SeparatorLight => Color.Transparent;
    }
}

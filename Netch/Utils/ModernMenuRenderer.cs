using System.Drawing;
using System.Windows.Forms;

namespace Netch.Utils;

/// <summary>
/// Windows 10/11 native-style flat renderer for <see cref="MenuStrip"/> and <see cref="ContextMenuStrip"/>.
/// </summary>
public sealed class ModernMenuRenderer : ToolStripProfessionalRenderer
{
    private static readonly Color BarBackColor = Color.White;
    private static readonly Color DropDownBackColor = Color.FromArgb(242, 242, 242);
    private static readonly Color DropDownBorderColor = Color.FromArgb(204, 204, 204);
    private static readonly Color BarHoverFillColor = Color.FromArgb(229, 243, 255);
    private static readonly Color BarHoverBorderColor = Color.FromArgb(204, 232, 255);
    private static readonly Color BarOpenFillColor = Color.FromArgb(204, 232, 255);
    private static readonly Color BarOpenBorderColor = Color.FromArgb(153, 209, 255);
    private static readonly Color DropDownHoverFillColor = Color.FromArgb(145, 201, 247);
    private static readonly Color SeparatorColor = Color.FromArgb(215, 215, 215);
    private static readonly Color TextNormalColor = Color.Black;
    private static readonly Color TextDisabledColor = Color.FromArgb(109, 109, 109);

    public ModernMenuRenderer() : base(new SystemMenuColorTable())
    {
        RoundedEdges = false;
    }

    public static void Apply(MenuStrip menuStrip, ContextMenuStrip? contextMenu = null, Func<int, int>? scale = null)
    {
        scale ??= v => v;
        var renderer = new ModernMenuRenderer();

        menuStrip.Renderer = renderer;
        menuStrip.BackColor = BarBackColor;
        menuStrip.Padding = new Padding(scale(4), scale(2), scale(4), scale(2));

        foreach (ToolStripItem item in menuStrip.Items)
        {
            if (item is ToolStripMenuItem menuItem)
            {
                menuItem.Padding = new Padding(scale(6), scale(2), scale(6), scale(2));
                ConfigureDropDown(menuItem.DropDown, scale);
            }
            else if (item is ToolStripButton btn)
            {
                btn.Padding = new Padding(scale(6), scale(2), scale(6), scale(2));
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
        dropDown.Padding = new Padding(scale(2));

        foreach (ToolStripItem sub in dropDown.Items)
        {
            sub.Padding = new Padding(scale(8), scale(4), scale(14), scale(4));
            if (sub is ToolStripMenuItem subMenu && subMenu.HasDropDownItems)
                ConfigureDropDown(subMenu.DropDown, scale);
        }
    }

    protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
    {
        if (e.ToolStrip is MenuStrip)
            return;

        if (e.ToolStrip is ToolStripDropDown)
        {
            using var pen = new Pen(DropDownBorderColor);
            e.Graphics.DrawRectangle(pen, 0, 0, e.ToolStrip.Width - 1, e.ToolStrip.Height - 1);
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

        if (e.ToolStrip is ToolStripDropDown)
        {
            var rect = new Rectangle(1, 0, e.Item.Width - 2, e.Item.Height);
            if (rect.Width <= 0 || rect.Height <= 0)
                return;

            using var brush = new SolidBrush(DropDownHoverFillColor);
            e.Graphics.FillRectangle(brush, rect);
            return;
        }

        var barRect = new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height - 1);
        if (barRect.Width <= 0 || barRect.Height <= 0)
            return;

        var fill = isOpen || e.Item.Pressed ? BarOpenFillColor : BarHoverFillColor;
        var border = isOpen || e.Item.Pressed ? BarOpenBorderColor : BarHoverBorderColor;
        using var barBrush = new SolidBrush(fill);
        using var barPen = new Pen(border);
        e.Graphics.FillRectangle(barBrush, barRect);
        e.Graphics.DrawRectangle(barPen, barRect);
    }

    protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
    {
        if (!e.Item.Enabled || (!e.Item.Selected && !e.Item.Pressed))
            return;

        var rect = new Rectangle(0, 0, e.Item.Width - 1, e.Item.Height - 1);
        if (rect.Width <= 0 || rect.Height <= 0)
            return;

        var fill = e.Item.Pressed ? BarOpenFillColor : BarHoverFillColor;
        var border = e.Item.Pressed ? BarOpenBorderColor : BarHoverBorderColor;
        using var brush = new SolidBrush(fill);
        using var pen = new Pen(border);
        e.Graphics.FillRectangle(brush, rect);
        e.Graphics.DrawRectangle(pen, rect);
    }

    protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
    {
        var y = e.Item.Height / 2;
        using var pen = new Pen(SeparatorColor);
        e.Graphics.DrawLine(pen, 6, y, e.Item.Width - 6, y);
    }

    protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
    {
        if (e.Item is not ToolStripLabel)
            e.TextColor = e.Item.Enabled ? TextNormalColor : TextDisabledColor;

        base.OnRenderItemText(e);
    }

    private sealed class SystemMenuColorTable : ProfessionalColorTable
    {
        public SystemMenuColorTable()
        {
            UseSystemColors = false;
        }

        public override Color MenuStripGradientBegin => BarBackColor;
        public override Color MenuStripGradientEnd => BarBackColor;
        public override Color ToolStripDropDownBackground => DropDownBackColor;
        public override Color MenuBorder => DropDownBorderColor;
        public override Color MenuItemBorder => Color.Transparent;
        public override Color MenuItemSelected => DropDownHoverFillColor;
        public override Color MenuItemSelectedGradientBegin => DropDownHoverFillColor;
        public override Color MenuItemSelectedGradientEnd => DropDownHoverFillColor;
        public override Color MenuItemPressedGradientBegin => BarOpenFillColor;
        public override Color MenuItemPressedGradientEnd => BarOpenFillColor;
        public override Color ImageMarginGradientBegin => DropDownBackColor;
        public override Color ImageMarginGradientMiddle => DropDownBackColor;
        public override Color ImageMarginGradientEnd => DropDownBackColor;
        public override Color SeparatorDark => SeparatorColor;
        public override Color SeparatorLight => Color.Transparent;
    }
}

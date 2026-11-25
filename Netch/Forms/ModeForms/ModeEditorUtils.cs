using System.Text;
using Netch.Models.Modes;
using Netch.Services;
using Netch.Utils;

namespace Netch.Forms.ModeForms;

public static class ModeEditorUtils
{
    public const string ReadOnlyModeHintKey = "Built-in (.txt) mode is read-only; use Save As... to create a custom copy.";

    public static string ToSafeFileName(string text)
    {
        var fileName = new StringBuilder(text);
        foreach (var c in Path.GetInvalidFileNameChars())
            fileName.Replace(c, '_');

        return fileName.ToString();
    }

    public static string GetCustomModeRelativePath(string name)
    {
        if (name == string.Empty)
            return string.Empty;

        var safeFileName = ToSafeFileName(name);
        var relativePath = $"Custom\\{safeFileName}.json";
        return relativePath;
    }

    public static string SuggestUniqueCustomRemark(string baseRemark)
    {
        var seed = string.IsNullOrWhiteSpace(baseRemark) ? "Custom Mode" : baseRemark.Trim();
        var candidate = seed;
        var index = 1;
        while (File.Exists(ModeService.Instance.GetFullPath(GetCustomModeRelativePath(candidate))))
        {
            candidate = index == 1 ? $"{seed} (Custom)" : $"{seed} (Custom {index})";
            index++;
        }

        return candidate;
    }

    public static bool TryPromptSaveAsPath(IWin32Window owner, string baseRemark, out string remark, out string fullPath)
    {
        remark = string.Empty;
        fullPath = string.Empty;

        var suggested = SuggestUniqueCustomRemark(baseRemark);
        var input = InputDialog.Show(
            i18N.Translate("Save As"),
            i18N.Translate("Please enter a mode remark"),
            suggested,
            owner);

        if (input == null)
            return false;

        remark = input.Trim();
        if (string.IsNullOrWhiteSpace(remark))
        {
            MessageBoxX.Show(i18N.Translate("Please enter a mode remark"), owner: owner);
            return false;
        }

        var relativePath = GetCustomModeRelativePath(remark);
        fullPath = ModeService.Instance.GetFullPath(relativePath);
        if (File.Exists(fullPath))
        {
            MessageBoxX.Show(i18N.Translate("File already exists.\n Please Change the filename"), owner: owner);
            return false;
        }

        return true;
    }

    public static void SaveNewMode(Mode newMode, IWin32Window? owner = null)
    {
        ModeService.Instance.Add(newMode);
        MessageBoxX.Show(i18N.Translate("Mode added successfully"), owner: owner);
        if (Global.MainForm != null)
            Global.MainForm.ModeComboBox.SelectedItem = newMode;
    }

    public static bool SaveFormMode(Form owner, Mode mode, bool isCreateMode, string relativePath)
    {
        if (isCreateMode)
        {
            var fullName = ModeService.Instance.GetFullPath(relativePath);
            if (File.Exists(fullName))
            {
                MessageBoxX.Show(i18N.Translate("File already exists.\n Please Change the filename"), owner: owner);
                return false;
            }

            mode.FullName = fullName;
            SaveNewMode(mode, owner);
        }
        else
        {
            mode.WriteFile();
            MessageBoxX.Show(i18N.Translate("Mode updated successfully"), owner: owner);
            if (Global.MainForm != null)
                Global.MainForm.ModeComboBox.SelectedItem = mode;
        }

        return true;
    }
}
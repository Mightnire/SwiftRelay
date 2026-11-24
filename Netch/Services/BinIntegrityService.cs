using System.Security.Cryptography;
using Netch.Utils;

namespace Netch.Services;

public static class BinIntegrityService
{
    public const string ChecksumsFileName = "checksums.sha256";
    private const string EmbeddedResourceSuffix = "checksums.sha256";

    /// <summary>
    /// Loads the expected SHA-256 hashes for core binaries.
    /// Prefers the tamper-proof embedded assembly manifest,
    /// falling back to the on-disk checksums.sha256 file if present.
    /// </summary>
    public static Dictionary<string, string> LoadExpectedHashes()
    {
        var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        // 1. Try embedded manifest resource in assembly
        var asm = typeof(BinIntegrityService).Assembly;
        var resourceName = asm.GetManifestResourceNames()
            .FirstOrDefault(n => n.EndsWith(EmbeddedResourceSuffix, StringComparison.OrdinalIgnoreCase));

        if (resourceName != null)
        {
            try
            {
                using var stream = asm.GetManifestResourceStream(resourceName);
                if (stream != null)
                {
                    using var reader = new StreamReader(stream);
                    ParseChecksumContent(reader.ReadToEnd(), result);
                    if (result.Count > 0)
                        return result;
                }
            }
            catch (Exception ex)
            {
                Log.Warning(ex, "Failed to read embedded checksum manifest");
            }
        }

        // 2. Fall back to bin/checksums.sha256 on disk
        var binChecksumPath = Path.Combine(Global.NetchDir, "bin", ChecksumsFileName);
        if (File.Exists(binChecksumPath))
        {
            try
            {
                var content = File.ReadAllText(binChecksumPath);
                ParseChecksumContent(content, result);
                if (result.Count > 0)
                    return result;
            }
            catch (Exception ex)
            {
                Log.Warning(ex, "Failed to read bin/checksums.sha256 file");
            }
        }

        // 3. Fall back to root checksums.sha256
        var rootChecksumPath = Path.Combine(Global.NetchDir, ChecksumsFileName);
        if (File.Exists(rootChecksumPath))
        {
            try
            {
                var content = File.ReadAllText(rootChecksumPath);
                ParseChecksumContent(content, result);
            }
            catch (Exception ex)
            {
                Log.Warning(ex, "Failed to read root checksums.sha256 file");
            }
        }

        return result;
    }

    /// <summary>
    /// Parses sha256sum formatted manifest content into filename-to-hash dictionary.
    /// </summary>
    public static void ParseChecksumContent(string content, Dictionary<string, string> target)
    {
        var lines = content.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var rawLine in lines)
        {
            var line = rawLine.Trim();
            if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#"))
                continue;

            // Formats: "<hash> *<filename>" or "<hash>  <filename>" or "<hash> <filename>"
            var spaceIdx = line.IndexOfAny(new[] { ' ', '\t' });
            if (spaceIdx <= 0)
                continue;

            var hash = line[..spaceIdx].Trim().ToLowerInvariant();
            var fileName = line[spaceIdx..].Trim().TrimStart('*').Trim();

            if (!string.IsNullOrEmpty(fileName) && !string.IsNullOrEmpty(hash))
            {
                target[fileName] = hash;
            }
        }
    }

    /// <summary>
    /// Validates integrity of all core files in the bin directory against expected SHA-256 hashes.
    /// </summary>
    public static async Task<(bool Success, List<string> Errors)> ValidateIntegrityAsync()
    {
        var expected = LoadExpectedHashes();
        var errors = new List<string>();

        if (expected.Count == 0)
        {
            Log.Warning("No expected checksums found for bin directory validation");
            return (true, errors);
        }

        var binDir = Path.Combine(Global.NetchDir, "bin");

        foreach (var (fileName, expectedHash) in expected)
        {
            var filePath = Path.Combine(binDir, fileName);
            if (!File.Exists(filePath))
            {
                errors.Add(i18N.TranslateFormat("Missing file: {0}", fileName));
                continue;
            }

            var actualHash = await Utils.Utils.Sha256CheckSumAsync(filePath);
            if (!string.Equals(actualHash, expectedHash, StringComparison.OrdinalIgnoreCase))
            {
                errors.Add(i18N.TranslateFormat("Modified file: {0}", fileName));
            }
        }

        return (errors.Count == 0, errors);
    }

    /// <summary>
    /// Checks bin integrity and prompts the user if files were modified or missing.
    /// Returns true if valid or user chooses to continue; false if user aborts.
    /// </summary>
    public static bool CheckBinFiles(IWin32Window? owner = null, bool silentIfValid = true)
    {
        var (success, errors) = ValidateIntegrityAsync().GetAwaiter().GetResult();

        if (success)
        {
            Log.Information("Bin directory file integrity check passed");
            if (!silentIfValid)
            {
                MessageBox.Show(
                    owner,
                    i18N.Translate("All core files in bin directory passed integrity verification."),
                    i18N.Translate("Verification Passed"),
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            return true;
        }

        Log.Warning("Bin directory file integrity check failed:\n{Errors}", string.Join("\n", errors));

        var errorList = string.Join("\n", errors.Take(8));
        if (errors.Count > 8)
            errorList += $"\n... ({errors.Count - 8} more)";

        var warningMessage = i18N.TranslateFormat(
            "The following files in the bin directory have been modified, replaced, or are missing:\n\n{0}\n\nRunning modified binary files may pose security risks or cause system instability.\nDo you want to continue running anyway?",
            errorList);

#if DEBUG
        if (silentIfValid)
        {
            Log.Debug("DEBUG mode: skipping security prompt for bin integrity");
            return true;
        }
#endif

        var result = MessageBox.Show(
            owner,
            warningMessage,
            i18N.Translate("Security Warning"),
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning,
            MessageBoxDefaultButton.Button2);

        return result == DialogResult.Yes;
    }
}

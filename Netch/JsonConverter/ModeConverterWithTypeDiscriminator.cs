using System.Text.Json;
using System.Text.Json.Serialization;
using Netch.Models.Modes;
using Netch.Models.Modes.ProcessMode;
using Netch.Models.Modes.ShareMode;
using Netch.Models.Modes.TunMode;

namespace Netch.JsonConverter;

public class ModeConverterWithTypeDiscriminator : JsonConverter<Mode>
{
    public override Mode? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var jsonElement = JsonSerializer.Deserialize<JsonElement>(ref reader);

        var modeTypePropertyName = JsonNamingPolicy.CamelCase.ConvertName(nameof(Mode.Type));
        if (!jsonElement.TryGetProperty(modeTypePropertyName, out var modeTypeToken))
            throw new JsonException();

        var modeTypeEnum = modeTypeToken.ValueKind switch
        {
            JsonValueKind.Number => (ModeType)modeTypeToken.GetInt32(),
            JsonValueKind.String => Enum.Parse<ModeType>(modeTypeToken.GetString()!),
            _ => throw new JsonException()
        };

        var isComposite = jsonElement.TryGetProperty("subModes", out _) || jsonElement.TryGetProperty("SubModes", out _);

        var modeType = modeTypeEnum switch
        {
            ModeType.ProcessMode => isComposite ? typeof(CompositeMode) : typeof(Redirector),
            ModeType.TunMode => typeof(TunMode),
            ModeType.ShareMode => typeof(ShareMode),
            _ => throw new ArgumentOutOfRangeException()
        };

        var mode = (Mode?)jsonElement.Deserialize(modeType, options);
        if (mode is CompositeMode composite)
        {
            composite.ResolveAndMerge();
        }

        return mode;
    }

    public override void Write(Utf8JsonWriter writer, Mode value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize<object>(writer, value, options);
    }
}
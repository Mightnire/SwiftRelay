using Netch.Utils;

namespace Netch.Models;

internal class TagItem<T>
{
    private readonly Func<string> _textFunc;

    public TagItem(T value, string text)
    {
        _textFunc = () => i18N.Translate(text);
        Value = value;
    }

    public TagItem(T value, Func<string> textFunc)
    {
        _textFunc = textFunc;
        Value = value;
    }

    public string Text => _textFunc();

    public T Value { get; }
}
using System.Text.RegularExpressions;
using Godot;

namespace Blokoto.addons.Godot_CSharp_Translation_Parser;

[Tool]
public partial class CSharpParser : EditorTranslationParserPlugin
{
    private string _pattern = @"(?!.*//).*Translate\(""(.*?)\""\)";
    
    public override Godot.Collections.Array<string[]> _ParseFile(string path)
    {
        Godot.Collections.Array<string[]> strings = [];
        using var file = FileAccess.Open(path, FileAccess.ModeFlags.Read);
        string text = file.GetAsText();
        const RegexOptions options = RegexOptions.Multiline;
        var matches = Regex.Matches(text, _pattern, options);
        foreach (Match m in matches)
        {
            strings.Add([m.Groups[1].Value]);
        }
        return strings;
    }

    public override string[] _GetRecognizedExtensions()
    {
        return ["cs"];
    }
}
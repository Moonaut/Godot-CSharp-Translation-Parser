#if TOOLS
using Godot;

namespace Blokoto.addons.Godot_CSharp_Translation_Parser;

[Tool]
public partial class CSharpParserPlugin : EditorPlugin
{
    private EditorTranslationParserPlugin parser = new CSharpParser();

    public override void _EnterTree()
    {
        AddTranslationParserPlugin(parser);
    }

    public override void _ExitTree()
    {
        RemoveTranslationParserPlugin(parser);
    }
}
#endif

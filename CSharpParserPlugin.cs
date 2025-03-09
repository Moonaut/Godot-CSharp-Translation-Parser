#if TOOLS
using Godot;
using System;
using AngelSwordSurvivors.Core;

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

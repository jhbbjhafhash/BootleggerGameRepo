using UnrealBuildTool;

public class BootleggerGame2EditorTarget : TargetRules
{
	public BootleggerGame2EditorTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Editor;
		ExtraModuleNames.Add("BootleggerGame2");
	}
}

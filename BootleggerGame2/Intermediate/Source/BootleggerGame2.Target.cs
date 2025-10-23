using UnrealBuildTool;

public class BootleggerGame2Target : TargetRules
{
	public BootleggerGame2Target(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Game;
		ExtraModuleNames.Add("BootleggerGame2");
	}
}

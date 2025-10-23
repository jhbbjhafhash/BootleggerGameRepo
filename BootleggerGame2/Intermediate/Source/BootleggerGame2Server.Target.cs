using UnrealBuildTool;

public class BootleggerGame2ServerTarget : TargetRules
{
	public BootleggerGame2ServerTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Server;
		ExtraModuleNames.Add("BootleggerGame2");
	}
}

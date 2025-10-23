using UnrealBuildTool;

public class BootleggerGame2ClientTarget : TargetRules
{
	public BootleggerGame2ClientTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.Latest;
		IncludeOrderVersion = EngineIncludeOrderVersion.Latest;
		Type = TargetType.Client;
		ExtraModuleNames.Add("BootleggerGame2");
	}
}

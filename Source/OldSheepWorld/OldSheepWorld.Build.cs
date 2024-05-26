// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class OldSheepWorld : ModuleRules
{
	public OldSheepWorld(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "EnhancedInput" });
	}
}

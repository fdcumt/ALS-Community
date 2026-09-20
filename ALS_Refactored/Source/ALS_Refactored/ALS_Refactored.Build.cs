// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ALS_Refactored : ModuleRules
{
	public ALS_Refactored(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "EnhancedInput" });
	}
}

// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class StarSphere : ModuleRules
{
	public StarSphere(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });
	}
}

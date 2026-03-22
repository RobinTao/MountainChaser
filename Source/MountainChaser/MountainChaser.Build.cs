// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class MountainChaser : ModuleRules
{
	public MountainChaser(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"MountainChaser",
			"MountainChaser/Variant_Platforming",
			"MountainChaser/Variant_Platforming/Animation",
			"MountainChaser/Variant_Combat",
			"MountainChaser/Variant_Combat/AI",
			"MountainChaser/Variant_Combat/Animation",
			"MountainChaser/Variant_Combat/Gameplay",
			"MountainChaser/Variant_Combat/Interfaces",
			"MountainChaser/Variant_Combat/UI",
			"MountainChaser/Variant_SideScrolling",
			"MountainChaser/Variant_SideScrolling/AI",
			"MountainChaser/Variant_SideScrolling/Gameplay",
			"MountainChaser/Variant_SideScrolling/Interfaces",
			"MountainChaser/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}

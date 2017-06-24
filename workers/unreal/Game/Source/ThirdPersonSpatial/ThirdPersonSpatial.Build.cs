// Copyright 1998-2017 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ThirdPersonSpatial : ModuleRules
{
	public ThirdPersonSpatial(TargetInfo Target)
	{
		var SpatialOS = new SpatialOSModule(this, Target, this.GetType().Name);
		SpatialOS.SetupSpatialOS();
		SpatialOS.GenerateCode();

		PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });
	}
}

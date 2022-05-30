// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class Grab_OpenDoor_Cycle2Target : TargetRules
{
	public Grab_OpenDoor_Cycle2Target( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "Grab_OpenDoor_Cycle2" } );
	}
}

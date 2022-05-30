// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class Grab_OpenDoor_Cycle2EditorTarget : TargetRules
{
	public Grab_OpenDoor_Cycle2EditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V2;
		ExtraModuleNames.AddRange( new string[] { "Grab_OpenDoor_Cycle2" } );
	}
}

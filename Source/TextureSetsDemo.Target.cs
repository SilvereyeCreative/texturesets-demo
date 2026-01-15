// Copyright (c) 2025 Electronic Arts. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class TextureSetsDemoTarget : TargetRules
{
	public TextureSetsDemoTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.V6;
		IncludeOrderVersion = EngineIncludeOrderVersion.Unreal5_7;
		ExtraModuleNames.Add("TextureSetsDemo");
	}
}

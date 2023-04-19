// Copyright Sam Bonifacio. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class NFTServerTarget : TargetRules
{
	public NFTServerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Server;
		DefaultBuildSettings = BuildSettingsVersion.V2;

		ExtraModuleNames.AddRange( new string[] { "NFT" } );
        	DisablePlugins.Add("AutoSettings");
    }
}

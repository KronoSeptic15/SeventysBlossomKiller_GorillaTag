using System;
using BepInEx;
using UnityEngine;
using Utilla;

namespace Piss{
	[ModdedGamemode]
	[BepInDependency("org.legoandmars.gorillatag.utilla", "1.5.0")]
	[BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
	public class Plugin : BaseUnityPlugin{
		bool inRoom;
		void Update(){
			if (inRoom){
				GameObject cherryBlossoms = GameObject.Find("Cherry Blossoms (2)");
				if (cherryBlossoms != null){
					Destroy(cherryBlossoms);
				}
			}
		}
		[ModdedGamemodeJoin]
		public void OnJoin(string gamemode){
			inRoom = true;
		}
		[ModdedGamemodeLeave]
		public void OnLeave(string gamemode){
			inRoom = false;
		}
	}
}

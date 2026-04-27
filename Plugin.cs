using System;
using System.Collections.Generic;
using BepInEx;
using UnityEngine;
using GorillaNetworking;

namespace TopTroops
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        public static List<string> topTroops = new List<string>();

        void OnEnable()
        {
            HarmonyPatches.ApplyHarmonyPatches();
        }

        void OnDisable()
        {
            HarmonyPatches.RemoveHarmonyPatches();
        }
    }
}

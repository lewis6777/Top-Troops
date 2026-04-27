using HarmonyLib;
using System.Collections.Generic;

namespace TopTroops.Patches
{
    [HarmonyPatch(typeof(GorillaNetworking.GorillaComputer))]
    [HarmonyPatch("OnReturnCurrentVersion")]
    class GetTopTroops
    {
        static void Postfix(GorillaNetworking.GorillaComputer __instance)
        {
            var field = AccessTools.Field(typeof(GorillaNetworking.GorillaComputer), "topTroops");
            var value = field.GetValue(__instance) as List<string>;
            if (value == null) return;
            Plugin.topTroops = new List<string>(value);
        }
    }
}
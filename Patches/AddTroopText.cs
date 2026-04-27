using HarmonyLib;

namespace TopTroops.Patches
{
    [HarmonyPatch(typeof(GorillaNetworking.GorillaComputer), "TroopScreen")]
    class AddTroopText
    {
        static void Postfix(GorillaNetworking.GorillaComputer __instance)
        {
            var field = AccessTools.Field(__instance.GetType(), "screenText");
            var screenText = field.GetValue(__instance);

            var appendMethod = screenText.GetType().GetMethod("Append", new[] { typeof(string) });

            appendMethod.Invoke(screenText, new object[] { $"\nTOP TROOPS: {string.Join(" ", Plugin.topTroops)}" });
        }
    }
}

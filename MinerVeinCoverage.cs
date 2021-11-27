using HarmonyLib;

namespace MinerVeinCoverage
{
    [HarmonyPatch(typeof(UIMinerWindow))]
    [HarmonyPatch("_OnUpdate")]
    static class Patch_UIMinerWindow__OnUpdate
    {
        static void Postfix(UIMinerWindow __instance)
        {
            if (__instance.minerId == 0 || __instance.factory == null)
            {
                __instance._Close();
            }
            else
            {
                MinerComponent minerComponent = __instance.factorySystem.minerPool[__instance.minerId];
                if (minerComponent.id != __instance.minerId)
                {
                    __instance._Close();
                }
                else
                {
                    if (minerComponent.type == EMinerType.Vein)
                    {
                        var speed = (30.0f * GameMain.data.history.miningSpeedScale) * (minerComponent.veinCount * 1.0f);
                        __instance.coverText.text = $"{"覆盖矿".Translate()}{minerComponent.veinCount}{"个矿脉".Translate()} ({speed:F1} / min)";
                    }
                }
            }
        }
    }
}
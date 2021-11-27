using BepInEx;
using HarmonyLib;

namespace MinerVeinCoverage
{
    [BepInPlugin(ModGuid, ModName, ModVersion)]
    [BepInProcess("DSPGAME.exe")]
    public class MainPlugin : BaseUnityPlugin
    {
        public const string ModGuid = "com.enriquein.plugins.minerveincoverage";
        public const string ModName = "MinerVeinCoverage";
        public const string ModVersion = "1.1.0";

        public void Awake()
        {
            var harmony = new Harmony("com.enriquein.plugins.minerveincoverage.patch");
            harmony.PatchAll(typeof(Patch_UIMinerWindow__OnUpdate));
        }
    }
}

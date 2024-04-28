using BepInEx;
using BepInEx.Configuration;
using HarmonyLib;

namespace MinerVeinCoverage
{
    [BepInPlugin(ModGuid, ModName, ModVersion)]
    [BepInProcess("DSPGAME.exe")]
    public class MainPlugin : BaseUnityPlugin
    {
        public const string ModGuid = "com.enriquein.plugins.minerveincoverage";
        public const string ModName = "MinerVeinCoverage";
        public const string ModVersion = "1.4.3";

        public static ConfigEntry<bool> DisplayAsPerSecond { get; set; }

        public void Awake()
        {
            DisplayAsPerSecond = Config.Bind<bool>("Display", "DisplayAsPerSecond", false, "Set to \"true\" to show the production as \"per second\" (default is \"per minute\").");
            var harmony = new Harmony("com.enriquein.plugins.minerveincoverage.patch");
            harmony.PatchAll(typeof(Patch_UIMinerWindow__OnUpdate));
            harmony.PatchAll(typeof(Patch_UIVeinCollectorPanel__OnUpdate));
        }
    }
}

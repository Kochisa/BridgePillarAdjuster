using BridgePillarAdjuster.Systems;
using HarmonyLib;

namespace BridgePillarAdjuster.Patches
{
	/*
    [HarmonyPatch]
    class BridgePillarAdjusterPatches
    {
        [HarmonyPatch(typeof(Game.Prefabs.NetInitializeSystem), "OnUpdate")]
        [HarmonyPostfix]
        public static void NetInitializeSystem_OnUpdate(Game.Prefabs.NetInitializeSystem __instance)
        {
            __instance.World.GetOrCreateSystemManaged<NetCompositionDataFixSystem>().Update();
        }
    }
    */
}

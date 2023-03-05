using HarmonyLib;
using SandBox.Missions.MissionLogics.Arena;
using TaleWorlds.Engine;
using TaleWorlds.MountAndBlade;

namespace BluntTournamentWeapons
{
    [HarmonyPatch(typeof(Mission))]
    public class BluntTournamentWeaponsMission
    {
        private static bool Prepare(Mission __instance) => __instance != null && __instance.HasMissionBehavior<ArenaAgentStateDeciderLogic>();

        // Disable melee blood splatters in tournaments and practice fights.
        [HarmonyPostfix]
        [HarmonyPatch("MeleeHitCallback")]
        internal static void Postfix1(ref HitParticleResultData hitParticleResultData)
        {
            hitParticleResultData.StartHitParticleIndex = ParticleSystemManager.GetRuntimeIdByName("psys_game_sweat_sword_enter");
            hitParticleResultData.ContinueHitParticleIndex = ParticleSystemManager.GetRuntimeIdByName("psys_game_sweat_sword_enter");
            hitParticleResultData.EndHitParticleIndex = ParticleSystemManager.GetRuntimeIdByName("psys_game_sweat_sword_enter");
        }

        // Disable missile blood splatters in tournaments and practice fights.
        [HarmonyPostfix]
        [HarmonyPatch("MissileHitCallback")]
        internal static void Postfix2(ref int extraHitParticleIndex) => extraHitParticleIndex = -1;
    }
}

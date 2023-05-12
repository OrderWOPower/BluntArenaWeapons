﻿using SandBox.Missions.MissionLogics.Arena;
using TaleWorlds.Engine;
using TaleWorlds.MountAndBlade;

namespace BluntArenaWeapons
{
    public class BluntArenaWeaponsMission
    {
        // Disable melee blood splatters in the arena.
        internal static void Postfix1(Mission __instance, ref HitParticleResultData hitParticleResultData)
        {
            if (__instance.HasMissionBehavior<ArenaAgentStateDeciderLogic>())
            {
                hitParticleResultData.StartHitParticleIndex = ParticleSystemManager.GetRuntimeIdByName("psys_game_sweat_sword_enter");
                hitParticleResultData.ContinueHitParticleIndex = ParticleSystemManager.GetRuntimeIdByName("psys_game_sweat_sword_enter");
                hitParticleResultData.EndHitParticleIndex = ParticleSystemManager.GetRuntimeIdByName("psys_game_sweat_sword_enter");
            }
        }

        // Disable missile blood splatters in the arena.
        internal static void Postfix2(Mission __instance, ref int extraHitParticleIndex)
        {
            if (__instance.HasMissionBehavior<ArenaAgentStateDeciderLogic>())
            {
                extraHitParticleIndex = -1;
            }
        }
    }
}

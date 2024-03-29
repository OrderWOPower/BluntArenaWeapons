﻿using HarmonyLib;
using SandBox.GameComponents;
using SandBox.Missions.MissionLogics.Arena;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace BluntArenaWeapons
{
    [HarmonyPatch(typeof(SandboxAgentApplyDamageModel), "DecideMissileWeaponFlags")]
    public class BluntArenaWeaponsDamageModel
    {
        public static void Postfix(ref WeaponFlags missileWeaponFlags)
        {
            if (Mission.Current.HasMissionBehavior<ArenaAgentStateDeciderLogic>())
            {
                // Disable missiles sticking to targets in the arena.
                missileWeaponFlags &= ~WeaponFlags.AmmoSticksWhenShot;
            }
        }
    }
}

using HarmonyLib;
using SandBox.GameComponents;
using SandBox.Missions.MissionLogics.Arena;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace BluntTournamentWeapons
{
    [HarmonyPatch(typeof(SandboxAgentApplyDamageModel), "DecideMissileWeaponFlags")]
    public class BluntTournamentWeaponsDamageModel
    {
        // Disable missiles sticking to targets in tournaments and practice fights.
        public static void Postfix(ref WeaponFlags missileWeaponFlags)
        {
            if (Mission.Current.HasMissionBehavior<ArenaAgentStateDeciderLogic>())
            {
                missileWeaponFlags &= ~WeaponFlags.AmmoSticksWhenShot;
            }
        }
    }
}

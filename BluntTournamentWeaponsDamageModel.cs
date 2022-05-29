using SandBox.GameComponents;
using SandBox.Missions.MissionLogics.Arena;
using SandBox.Tournaments.MissionLogics;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace BluntTournamentWeapons
{
    public class BluntTournamentWeaponsDamageModel : SandboxAgentApplyDamageModel
    {
        // Disable missiles sticking to targets in tournaments and practice fights.
        public override void DecideMissileWeaponFlags(Agent attackerAgent, MissionWeapon missileWeapon, ref WeaponFlags missileWeaponFlags)
        {
            if (Mission.Current.HasMissionBehavior<TournamentBehavior>() || Mission.Current.HasMissionBehavior<ArenaPracticeFightMissionController>())
            {
                missileWeaponFlags &= ~WeaponFlags.AmmoSticksWhenShot;
            }
        }
    }
}

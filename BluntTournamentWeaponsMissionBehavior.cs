using HarmonyLib;
using SandBox.Missions.MissionLogics.Arena;
using TaleWorlds.MountAndBlade;

namespace BluntTournamentWeapons
{
    public class BluntTournamentWeaponsMissionBehavior : MissionBehavior
    {
        public override MissionBehaviorType BehaviorType => MissionBehaviorType.Other;

        public override void AfterStart()
        {
            if (Mission.HasMissionBehavior<ArenaAgentStateDeciderLogic>())
            {
                BluntTournamentWeaponsSubModule.HarmonyInstance.Patch(AccessTools.Method(typeof(Mission), "MeleeHitCallback"), postfix: new HarmonyMethod(AccessTools.Method(typeof(BluntTournamentWeaponsMission), "Postfix1")));
                BluntTournamentWeaponsSubModule.HarmonyInstance.Patch(AccessTools.Method(typeof(Mission), "MissileHitCallback"), postfix: new HarmonyMethod(AccessTools.Method(typeof(BluntTournamentWeaponsMission), "Postfix2")));
            }
        }

        protected override void OnEndMission()
        {
            if (Mission.HasMissionBehavior<ArenaAgentStateDeciderLogic>())
            {
                BluntTournamentWeaponsSubModule.HarmonyInstance.Unpatch(AccessTools.Method(typeof(Mission), "MeleeHitCallback"), AccessTools.Method(typeof(BluntTournamentWeaponsMission), "Postfix1"));
                BluntTournamentWeaponsSubModule.HarmonyInstance.Unpatch(AccessTools.Method(typeof(Mission), "MissileHitCallback"), AccessTools.Method(typeof(BluntTournamentWeaponsMission), "Postfix2"));
            }
        }
    }
}

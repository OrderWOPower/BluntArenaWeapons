using HarmonyLib;
using SandBox.Missions.MissionLogics.Arena;
using TaleWorlds.MountAndBlade;

namespace BluntArenaWeapons
{
    public class BluntArenaWeaponsMissionBehavior : MissionBehavior
    {
        public override MissionBehaviorType BehaviorType => MissionBehaviorType.Other;

        public override void AfterStart()
        {
            if (Mission.HasMissionBehavior<ArenaAgentStateDeciderLogic>())
            {
                Harmony harmony = BluntArenaWeaponsSubModule.HarmonyInstance;
                harmony.Patch(AccessTools.Method(typeof(Mission), "MeleeHitCallback"), postfix: new HarmonyMethod(AccessTools.Method(typeof(BluntArenaWeaponsMission), "Postfix1")));
                harmony.Patch(AccessTools.Method(typeof(Mission), "MissileHitCallback"), postfix: new HarmonyMethod(AccessTools.Method(typeof(BluntArenaWeaponsMission), "Postfix2")));
                harmony.Patch(AccessTools.Method(AccessTools.TypeByName("RBMCombat.Utilities"), "RBMComputeDamage"), postfix: new HarmonyMethod(AccessTools.Method(typeof(BluntArenaWeaponsUtilities), "Postfix")));
            }
        }

        protected override void OnEndMission()
        {
            if (Mission.HasMissionBehavior<ArenaAgentStateDeciderLogic>())
            {
                Harmony harmony = BluntArenaWeaponsSubModule.HarmonyInstance;
                harmony.Unpatch(AccessTools.Method(typeof(Mission), "MeleeHitCallback"), AccessTools.Method(typeof(BluntArenaWeaponsMission), "Postfix1"));
                harmony.Unpatch(AccessTools.Method(typeof(Mission), "MissileHitCallback"), AccessTools.Method(typeof(BluntArenaWeaponsMission), "Postfix2"));
                harmony.Unpatch(AccessTools.Method(AccessTools.TypeByName("RBMCombat.Utilities"), "RBMComputeDamage"), AccessTools.Method(typeof(BluntArenaWeaponsUtilities), "Postfix"));
            }
        }
    }
}

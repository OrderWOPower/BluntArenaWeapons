using HarmonyLib;
using TaleWorlds.MountAndBlade;

namespace BluntArenaWeapons
{
    // This mod makes weapons in the arena blunt.
    public class BluntArenaWeaponsSubModule : MBSubModuleBase
    {
        public static Harmony HarmonyInstance { get; set; }

        protected override void OnSubModuleLoad()
        {
            HarmonyInstance = new Harmony("mod.bannerlord.bluntarenaweapons");
            HarmonyInstance.PatchAll();
        }

        public override void OnBeforeMissionBehaviorInitialize(Mission mission) => mission.AddMissionBehavior(new BluntArenaWeaponsMissionBehavior());
    }
}

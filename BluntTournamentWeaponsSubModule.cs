using HarmonyLib;
using TaleWorlds.MountAndBlade;

namespace BluntTournamentWeapons
{
    // This mod makes tournament participants use blunt weapons.
    public class BluntTournamentWeaponsSubModule : MBSubModuleBase
    {
        public static Harmony HarmonyInstance { get; set; }

        protected override void OnSubModuleLoad()
        {
            HarmonyInstance = new Harmony("mod.bannerlord.blunttournamentweapons");
            HarmonyInstance.PatchAll();
        }

        public override void OnBeforeMissionBehaviorInitialize(Mission mission) => mission.AddMissionBehavior(new BluntTournamentWeaponsMissionBehavior());
    }
}

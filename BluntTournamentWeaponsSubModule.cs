using HarmonyLib;
using TaleWorlds.MountAndBlade;

namespace BluntTournamentWeapons
{
    // This mod makes tournament participants use blunt weapons.
    public class BluntTournamentWeaponsSubModule : MBSubModuleBase
    {
        protected override void OnSubModuleLoad() => new Harmony("mod.bannerlord.blunttournamentweapons").PatchAll();
    }
}

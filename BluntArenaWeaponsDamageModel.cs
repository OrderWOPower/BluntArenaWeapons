using HarmonyLib;
using SandBox.GameComponents;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;

namespace BluntArenaWeapons
{
    [HarmonyPatch(typeof(SandboxAgentApplyDamageModel), "DecideMissileWeaponFlags")]
    public class BluntArenaWeaponsDamageModel
    {
        public static void Postfix(ref WeaponFlags missileWeaponFlags)
        {
            if (CampaignMission.Current.Location?.StringId == "arena")
            {
                // Disable missiles sticking to targets in the arena.
                missileWeaponFlags &= ~WeaponFlags.AmmoSticksWhenShot;
            }
        }
    }
}

using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace BluntArenaWeapons
{
    // This mod makes weapons in the arena blunt.
    public class BluntArenaWeaponsSubModule : MBSubModuleBase
    {
        private Harmony _harmony;

        protected override void OnSubModuleLoad()
        {
            _harmony = new Harmony("mod.bannerlord.bluntarenaweapons");
            _harmony.PatchAll();
        }

        protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
        {
            if (game.GameType is Campaign)
            {
                _harmony.Patch(AccessTools.Method(typeof(Mission), "MeleeHitCallback"), postfix: new HarmonyMethod(AccessTools.Method(typeof(BluntArenaWeaponsMission), "Postfix1")));
                _harmony.Patch(AccessTools.Method(typeof(Mission), "MissileHitCallback"), postfix: new HarmonyMethod(AccessTools.Method(typeof(BluntArenaWeaponsMission), "Postfix2")));
                _harmony.Patch(AccessTools.Method(AccessTools.TypeByName("RBMCombat.Utilities"), "RBMComputeDamage"), postfix: new HarmonyMethod(AccessTools.Method(typeof(BluntArenaWeaponsUtilities), "Postfix")));
            }
        }

        public override void OnGameEnd(Game game)
        {
            if (game.GameType is Campaign)
            {
                _harmony.Unpatch(AccessTools.Method(typeof(Mission), "MeleeHitCallback"), AccessTools.Method(typeof(BluntArenaWeaponsMission), "Postfix1"));
                _harmony.Unpatch(AccessTools.Method(typeof(Mission), "MissileHitCallback"), AccessTools.Method(typeof(BluntArenaWeaponsMission), "Postfix2"));
                _harmony.Unpatch(AccessTools.Method(AccessTools.TypeByName("RBMCombat.Utilities"), "RBMComputeDamage"), AccessTools.Method(typeof(BluntArenaWeaponsUtilities), "Postfix"));
            }
        }
    }
}

using HarmonyLib;
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace BluntTournamentWeapons
{
    // This mod makes tournament participants use blunt weapons.
    public class BluntTournamentWeaponsSubModule : MBSubModuleBase
    {
        protected override void OnSubModuleLoad() => new Harmony("mod.bannerlord.blunttournamentweapons").PatchAll();

        protected override void OnGameStart(Game game, IGameStarter gameStarter)
        {
            if (game.GameType is Campaign)
            {
                CampaignGameStarter campaignStarter = (CampaignGameStarter)gameStarter;
                campaignStarter.AddModel(new BluntTournamentWeaponsDamageModel());
            }
        }
    }
}

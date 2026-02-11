using TaleWorlds.CampaignSystem;
using TaleWorlds.Engine;
using TaleWorlds.MountAndBlade;

namespace BluntArenaWeapons
{
    public class BluntArenaWeaponsMission
    {
        internal static void Postfix1(ref HitParticleResultData hitParticleResultData)
        {
            if (CampaignMission.Current.Location?.StringId == "arena")
            {
                // Disable melee blood splatters in the arena.
                hitParticleResultData.StartHitParticleIndex = ParticleSystemManager.GetRuntimeIdByName("psys_game_sweat_sword_enter");
                hitParticleResultData.ContinueHitParticleIndex = ParticleSystemManager.GetRuntimeIdByName("psys_game_sweat_sword_enter");
                hitParticleResultData.EndHitParticleIndex = ParticleSystemManager.GetRuntimeIdByName("psys_game_sweat_sword_enter");
            }
        }

        internal static void Postfix2(ref int extraHitParticleIndex)
        {
            if (CampaignMission.Current.Location?.StringId == "arena")
            {
                // Disable missile blood splatters in the arena.
                extraHitParticleIndex = -1;
            }
        }
    }
}

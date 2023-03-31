using TaleWorlds.Engine;
using TaleWorlds.MountAndBlade;

namespace BluntArenaWeapons
{
    public class BluntArenaWeaponsMission
    {
        // Disable melee blood splatters in the arena.
        internal static void Postfix1(ref HitParticleResultData hitParticleResultData)
        {
            hitParticleResultData.StartHitParticleIndex = ParticleSystemManager.GetRuntimeIdByName("psys_game_sweat_sword_enter");
            hitParticleResultData.ContinueHitParticleIndex = ParticleSystemManager.GetRuntimeIdByName("psys_game_sweat_sword_enter");
            hitParticleResultData.EndHitParticleIndex = ParticleSystemManager.GetRuntimeIdByName("psys_game_sweat_sword_enter");
        }

        // Disable missile blood splatters in the arena.
        internal static void Postfix2(ref int extraHitParticleIndex) => extraHitParticleIndex = -1;
    }
}

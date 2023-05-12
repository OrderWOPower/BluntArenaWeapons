using TaleWorlds.Core;

namespace BluntArenaWeapons
{
    public class BluntArenaWeaponsUtilities
    {
        public static void Postfix(ref float __result, string weaponType, DamageTypes damageType)
        {
            if (damageType == DamageTypes.Blunt)
            {
                if (weaponType == "OneHandedSword" || weaponType == "OneHandedPolearm" || weaponType == "TwoHandedPolearm")
                {
                    __result *= 4;
                }
                else if (weaponType == "Javelin")
                {
                    __result *= 2;
                }
            }
        }
    }
}

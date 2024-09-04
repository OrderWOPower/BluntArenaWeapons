using HarmonyLib;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace BluntArenaWeapons
{
    [HarmonyPatch(typeof(MissionCombatMechanicsHelper), "ComputeBlowDamage")]
    public class BluntArenaWeaponsCombatMechanicsHelper
    {
        public static void Postfix(WeaponComponentData attackerWeapon, DamageTypes damageType, ref int inflictedDamage)
        {
            if (attackerWeapon != null && damageType == DamageTypes.Blunt)
            {
                WeaponClass weaponClass = attackerWeapon.WeaponClass;

                if (weaponClass == WeaponClass.OneHandedSword || weaponClass == WeaponClass.Javelin)
                {
                    inflictedDamage *= 2;
                }
                else if (weaponClass == WeaponClass.OneHandedPolearm || weaponClass == WeaponClass.TwoHandedPolearm)
                {
                    inflictedDamage *= 8;
                }
            }
        }
    }
}

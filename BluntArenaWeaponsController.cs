using HarmonyLib;
using SandBox.Tournaments.MissionLogics;
using TaleWorlds.CampaignSystem.TournamentGames;
using TaleWorlds.Core;
using TaleWorlds.ObjectSystem;

namespace BluntArenaWeapons
{
    [HarmonyPatch(typeof(TournamentFightMissionController), "PrepareForMatch")]
    public class BluntArenaWeaponsController
    {
        [HarmonyPriority(Priority.Last)]
        public static void Postfix(TournamentMatch ____match)
        {
            foreach (TournamentTeam team in ____match.Teams)
            {
                foreach (TournamentParticipant participant in team.Participants)
                {
                    for (EquipmentIndex index = EquipmentIndex.WeaponItemBeginSlot; index < EquipmentIndex.ExtraWeaponSlot; index++)
                    {
                        Equipment matchEquipment = participant.MatchEquipment;
                        MBObjectManager objectManager = Game.Current.ObjectManager;

                        if (matchEquipment[index].Item?.Type == ItemObject.ItemTypeEnum.Arrows)
                        {
                            matchEquipment.AddEquipmentToSlotWithoutAgent(index, new EquipmentElement(objectManager.GetObject<ItemObject>("blunt_arrows")));
                        }

                        if (matchEquipment[index].Item?.Type == ItemObject.ItemTypeEnum.Bolts)
                        {
                            matchEquipment.AddEquipmentToSlotWithoutAgent(index, new EquipmentElement(objectManager.GetObject<ItemObject>("blunt_bolts")));
                        }

                        if (matchEquipment[index].Item?.Type == ItemObject.ItemTypeEnum.OneHandedWeapon)
                        {
                            matchEquipment.AddEquipmentToSlotWithoutAgent(index, new EquipmentElement(objectManager.GetObject<ItemObject>("wooden_sword_t1")));
                        }

                        if (matchEquipment[index].Item?.Type == ItemObject.ItemTypeEnum.TwoHandedWeapon)
                        {
                            matchEquipment.AddEquipmentToSlotWithoutAgent(index, new EquipmentElement(objectManager.GetObject<ItemObject>("peasant_maul_t1_2")));
                        }
                    }
                }
            }
        }
    }
}

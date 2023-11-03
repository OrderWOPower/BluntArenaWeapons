using HarmonyLib;
using SandBox.Tournaments.MissionLogics;
using System.Linq;
using TaleWorlds.CampaignSystem.TournamentGames;
using TaleWorlds.Core;
using TaleWorlds.ObjectSystem;

namespace BluntArenaWeapons
{
    [HarmonyPatch(typeof(TournamentFightMissionController), "PrepareForMatch")]
    public class BluntArenaWeaponsController
    {
        [HarmonyAfter(new string[] { "com.rbmcombat" })]
        public static void Postfix(TournamentMatch ____match)
        {
            foreach (TournamentParticipant participant in ____match.Teams.SelectMany(team => team.Participants))
            {
                for (EquipmentIndex index = EquipmentIndex.WeaponItemBeginSlot; index < EquipmentIndex.ExtraWeaponSlot; index++)
                {
                    Equipment matchEquipment = participant.MatchEquipment;
                    MBObjectManager objectManager = Game.Current.ObjectManager;

                    switch (matchEquipment[index].Item?.Type)
                    {
                        case ItemObject.ItemTypeEnum.Arrows:
                            matchEquipment.AddEquipmentToSlotWithoutAgent(index, new EquipmentElement(objectManager.GetObject<ItemObject>("blunt_arrows")));

                            break;
                        case ItemObject.ItemTypeEnum.Bolts:
                            matchEquipment.AddEquipmentToSlotWithoutAgent(index, new EquipmentElement(objectManager.GetObject<ItemObject>("blunt_bolts")));

                            break;
                        case ItemObject.ItemTypeEnum.OneHandedWeapon:
                            matchEquipment.AddEquipmentToSlotWithoutAgent(index, new EquipmentElement(objectManager.GetObject<ItemObject>("wooden_sword_t1")));

                            break;
                        case ItemObject.ItemTypeEnum.TwoHandedWeapon:
                            matchEquipment.AddEquipmentToSlotWithoutAgent(index, new EquipmentElement(objectManager.GetObject<ItemObject>("peasant_maul_t1_2")));

                            break;
                    }
                }
            }
        }
    }
}

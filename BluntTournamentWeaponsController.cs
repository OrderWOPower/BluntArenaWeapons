using HarmonyLib;
using SandBox.Tournaments.MissionLogics;
using TaleWorlds.CampaignSystem.TournamentGames;
using TaleWorlds.Core;

namespace BluntTournamentWeapons
{
    [HarmonyPatch(typeof(TournamentFightMissionController), "PrepareForMatch")]
    public class BluntTournamentWeaponsController
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
                        if (participant.MatchEquipment[index].Item?.Type == ItemObject.ItemTypeEnum.Arrows)
                        {
                            participant.MatchEquipment.AddEquipmentToSlotWithoutAgent(index, new EquipmentElement(Game.Current.ObjectManager.GetObject<ItemObject>("blunt_arrows")));
                        }
                        if (participant.MatchEquipment[index].Item?.Type == ItemObject.ItemTypeEnum.Bolts)
                        {
                            participant.MatchEquipment.AddEquipmentToSlotWithoutAgent(index, new EquipmentElement(Game.Current.ObjectManager.GetObject<ItemObject>("blunt_bolts")));
                        }
                        if (participant.MatchEquipment[index].Item?.Type == ItemObject.ItemTypeEnum.OneHandedWeapon)
                        {
                            participant.MatchEquipment.AddEquipmentToSlotWithoutAgent(index, new EquipmentElement(Game.Current.ObjectManager.GetObject<ItemObject>("wooden_sword_t1")));
                        }
                        if (participant.MatchEquipment[index].Item?.Type == ItemObject.ItemTypeEnum.TwoHandedWeapon)
                        {
                            participant.MatchEquipment.AddEquipmentToSlotWithoutAgent(index, new EquipmentElement(Game.Current.ObjectManager.GetObject<ItemObject>("peasant_maul_t1_2")));
                        }
                    }
                }
            }
        }
    }
}

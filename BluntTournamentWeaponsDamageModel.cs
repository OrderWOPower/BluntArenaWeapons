using SandBox.Missions.MissionLogics.Arena;
using SandBox.Tournaments.MissionLogics;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;
using TaleWorlds.MountAndBlade.ComponentInterfaces;

namespace BluntTournamentWeapons
{
    public class BluntTournamentWeaponsDamageModel : AgentApplyDamageModel
    {
        private readonly AgentApplyDamageModel _model;

        public BluntTournamentWeaponsDamageModel(AgentApplyDamageModel model) => _model = model;

        // Disable missiles sticking to targets in tournaments and practice fights.
        public override void DecideMissileWeaponFlags(Agent attackerAgent, MissionWeapon missileWeapon, ref WeaponFlags missileWeaponFlags)
        {
            if (Mission.Current.HasMissionBehavior<TournamentBehavior>() || Mission.Current.HasMissionBehavior<ArenaPracticeFightMissionController>())
            {
                missileWeaponFlags &= ~WeaponFlags.AmmoSticksWhenShot;
            }
        }

        public override void CalculateCollisionStunMultipliers(Agent attackerAgent, Agent defenderAgent, bool isAlternativeAttack, CombatCollisionResult collisionResult, WeaponComponentData attackerWeapon, WeaponComponentData defenderWeapon, out float attackerStunMultiplier, out float defenderStunMultiplier) => _model.CalculateCollisionStunMultipliers(attackerAgent, defenderAgent, isAlternativeAttack, collisionResult, attackerWeapon, defenderWeapon, out attackerStunMultiplier, out defenderStunMultiplier);

        public override float CalculateDamage(in AttackInformation attackInformation, in AttackCollisionData collisionData, in MissionWeapon weapon, float baseDamage) => _model.CalculateDamage(attackInformation, collisionData, weapon, baseDamage);

        public override float CalculatePassiveAttackDamage(BasicCharacterObject attackerCharacter, in AttackCollisionData collisionData, float baseDamage) => _model.CalculatePassiveAttackDamage(attackerCharacter, collisionData, baseDamage);

        public override float CalculateShieldDamage(in AttackInformation attackInformation, float baseDamage) => _model.CalculateShieldDamage(attackInformation, baseDamage);

        public override float CalculateStaggerThresholdMultiplier(Agent defenderAgent) => _model.CalculateStaggerThresholdMultiplier(defenderAgent);

        public override bool CanWeaponDismount(Agent attackerAgent, WeaponComponentData attackerWeapon, in Blow blow, in AttackCollisionData collisionData) => _model.CanWeaponDismount(attackerAgent, attackerWeapon, blow, collisionData);

        public override bool CanWeaponIgnoreFriendlyFireChecks(WeaponComponentData weapon) => _model.CanWeaponIgnoreFriendlyFireChecks(weapon);

        public override bool CanWeaponKnockback(Agent attackerAgent, WeaponComponentData attackerWeapon, in Blow blow, in AttackCollisionData collisionData) => _model.CanWeaponKnockback(attackerAgent, attackerWeapon, blow, collisionData);

        public override bool CanWeaponKnockDown(Agent attackerAgent, Agent victimAgent, WeaponComponentData attackerWeapon, in Blow blow, in AttackCollisionData collisionData) => _model.CanWeaponKnockDown(attackerAgent, victimAgent, attackerWeapon, blow, collisionData);

        public override bool DecideAgentDismountedByBlow(Agent attackerAgent, Agent victimAgent, in AttackCollisionData collisionData, WeaponComponentData attackerWeapon, in Blow blow) => _model.DecideAgentDismountedByBlow(attackerAgent, victimAgent, collisionData, attackerWeapon, blow);

        public override bool DecideAgentKnockedBackByBlow(Agent attackerAgent, Agent victimAgent, in AttackCollisionData collisionData, WeaponComponentData attackerWeapon, in Blow blow) => _model.DecideAgentKnockedBackByBlow(attackerAgent, victimAgent, collisionData, attackerWeapon, blow);

        public override bool DecideAgentKnockedDownByBlow(Agent attackerAgent, Agent victimAgent, in AttackCollisionData collisionData, WeaponComponentData attackerWeapon, in Blow blow) => _model.DecideAgentKnockedDownByBlow(attackerAgent, victimAgent, collisionData, attackerWeapon, blow);

        public override bool DecideAgentShrugOffBlow(Agent victimAgent, AttackCollisionData collisionData, in Blow blow) => _model.DecideAgentShrugOffBlow(victimAgent, collisionData, blow);

        public override bool DecideCrushedThrough(Agent attackerAgent, Agent defenderAgent, float totalAttackEnergy, Agent.UsageDirection attackDirection, StrikeType strikeType, WeaponComponentData defendItem, bool isPassiveUsageHit) => _model.DecideCrushedThrough(attackerAgent, defenderAgent, totalAttackEnergy, attackDirection, strikeType, defendItem, isPassiveUsageHit);

        public override bool DecideMountRearedByBlow(Agent attackerAgent, Agent victimAgent, in AttackCollisionData collisionData, WeaponComponentData attackerWeapon, in Blow blow) => _model.DecideMountRearedByBlow(attackerAgent, victimAgent, collisionData, attackerWeapon, blow);

        public override MeleeCollisionReaction DecidePassiveAttackCollisionReaction(Agent attacker, Agent defender, bool isFatalHit) => _model.DecidePassiveAttackCollisionReaction(attacker, defender, isFatalHit);

        public override float GetDamageMultiplierForBodyPart(BoneBodyPartType bodyPart, DamageTypes type, bool isHuman) => _model.GetDamageMultiplierForBodyPart(bodyPart, type, isHuman);

        public override float GetDismountPenetration(Agent attackerAgent, WeaponComponentData attackerWeapon, in Blow blow, in AttackCollisionData collisionData) => _model.GetDismountPenetration(attackerAgent, attackerWeapon, blow, collisionData);

        public override float GetHorseChargePenetration() => _model.GetHorseChargePenetration();

        public override float GetKnockBackPenetration(Agent attackerAgent, WeaponComponentData attackerWeapon, in Blow blow, in AttackCollisionData collisionData) => _model.GetKnockBackPenetration(attackerAgent, attackerWeapon, blow, collisionData);

        public override float GetKnockDownPenetration(Agent attackerAgent, WeaponComponentData attackerWeapon, in Blow blow, in AttackCollisionData collisionData) => _model.GetKnockDownPenetration(attackerAgent, attackerWeapon, blow, collisionData);
    }
}

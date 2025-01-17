﻿namespace SolastaCommunityExpansion.CustomDefinitions
{
    public interface IOnAttackHitEffect
    {
        void OnAttackHit(
            GameLocationCharacter attacker,
            GameLocationCharacter defender,
            ActionModifier attackModifier,
            int attackRoll,
            int successDelta,
            bool ranged);
    }

    public delegate void OnAttackHitDelegate(
            GameLocationCharacter attacker,
            GameLocationCharacter defender,
            ActionModifier attackModifier,
            int attackRoll,
            int successDelta,
            bool ranged);

    /**
     * Before using this, please consider if FeatureDefinitionAdditionalDamage can cover the desired use case.
     * This has much greater flexibility, so there are cases where it is appropriate, but when possible it is
     * better for future maintainability of features to use the features provided by TA.
     */
    public class FeatureDefinitionOnAttackHitEffect : FeatureDefinition, IOnAttackHitEffect
    {
        private OnAttackHitDelegate onAttackHit;

        internal void SetOnAttackHitDelegate(OnAttackHitDelegate del)
        {
            onAttackHit = del;
        }

        public void OnAttackHit(
            GameLocationCharacter attacker,
            GameLocationCharacter defender,
            ActionModifier attackModifier,
            int attackRoll,
            int successDelta,
            bool ranged)
        {
            onAttackHit?.Invoke(attacker, defender, attackModifier, attackRoll, successDelta, ranged);
        }
    }
}

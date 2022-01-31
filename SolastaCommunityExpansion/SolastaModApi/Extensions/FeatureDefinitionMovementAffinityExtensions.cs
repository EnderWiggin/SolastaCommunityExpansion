using SolastaModApi.Infrastructure;
using AK.Wwise;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AddressableAssets;
using System;
using System.Text;
using TA.AI;
using TA;
using System.Collections.Generic;
using UnityEngine.Rendering.PostProcessing;
using  static  ActionDefinitions ;
using  static  TA . AI . DecisionPackageDefinition ;
using  static  TA . AI . DecisionDefinition ;
using  static  RuleDefinitions ;
using  static  BanterDefinitions ;
using  static  Gui ;
using  static  BestiaryDefinitions ;
using  static  CursorDefinitions ;
using  static  AnimationDefinitions ;
using  static  CharacterClassDefinition ;
using  static  CreditsGroupDefinition ;
using  static  CampaignDefinition ;
using  static  GraphicsCharacterDefinitions ;
using  static  GameCampaignDefinitions ;
using  static  TooltipDefinitions ;
using  static  BaseBlueprint ;
using  static  MorphotypeElementDefinition ;

namespace SolastaModApi.Extensions
{
    /// <summary>
    /// This helper extensions class was automatically generated.
    /// If you find a problem please report at https://github.com/SolastaMods/SolastaModApi/issues.
    /// </summary>
    [TargetType(typeof(FeatureDefinitionMovementAffinity))]
    public static partial class FeatureDefinitionMovementAffinityExtensions
    {
        public static T SetAdditionalDashTag<T>(this T entity, System.String value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("additionalDashTag", value);
            return entity;
        }

        public static T SetAdditionalFallThreshold<T>(this T entity, System.Int32 value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("additionalFallThreshold", value);
            return entity;
        }

        public static T SetAdditionalJumpCells<T>(this T entity, System.Int32 value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("additionalJumpCells", value);
            return entity;
        }

        public static T SetAppliesToAllModes<T>(this T entity, System.Boolean value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("appliesToAllModes", value);
            return entity;
        }

        public static T SetBaseSpeedAdditiveModifier<T>(this T entity, System.Int32 value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("baseSpeedAdditiveModifier", value);
            return entity;
        }

        public static T SetBaseSpeedMultiplicativeModifier<T>(this T entity, System.Single value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("baseSpeedMultiplicativeModifier", value);
            return entity;
        }

        public static T SetCanMoveOnWalls<T>(this T entity, System.Boolean value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("canMoveOnWalls", value);
            return entity;
        }

        public static T SetDisableClimb<T>(this T entity, System.Boolean value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("disableClimb", value);
            return entity;
        }

        public static T SetDisableDrop<T>(this T entity, System.Boolean value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("disableDrop", value);
            return entity;
        }

        public static T SetDisableJump<T>(this T entity, System.Boolean value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("disableJump", value);
            return entity;
        }

        public static T SetDisableVault<T>(this T entity, System.Boolean value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("disableVault", value);
            return entity;
        }

        public static T SetEncumbranceImmunity<T>(this T entity, System.Boolean value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("encumbranceImmunity", value);
            return entity;
        }

        public static T SetEnhancedJump<T>(this T entity, System.Boolean value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("enhancedJump", value);
            return entity;
        }

        public static T SetExpertClimber<T>(this T entity, System.Boolean value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("expertClimber", value);
            return entity;
        }

        public static T SetFastClimber<T>(this T entity, System.Boolean value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("fastClimber", value);
            return entity;
        }

        public static T SetForceMinimalBaseSpeed<T>(this T entity, System.Boolean value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("forceMinimalBaseSpeed", value);
            return entity;
        }

        public static T SetHeavyArmorImmunity<T>(this T entity, System.Boolean value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("heavyArmorImmunity", value);
            return entity;
        }

        public static T SetImmuneDifficultTerrain<T>(this T entity, System.Boolean value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("immuneDifficultTerrain", value);
            return entity;
        }

        public static T SetMinimalBaseSpeed<T>(this T entity, System.Int32 value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("minimalBaseSpeed", value);
            return entity;
        }

        public static T SetMinMaxMoves<T>(this T entity, System.Int32 value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("minMaxMoves", value);
            return entity;
        }

        public static T SetMoveMode<T>(this T entity, RuleDefinitions.MoveMode value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("moveMode", value);
            return entity;
        }

        public static T SetSituationalContext<T>(this T entity, RuleDefinitions.SituationalContext value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("situationalContext", value);
            return entity;
        }

        public static T SetSpeedAddBase<T>(this T entity, System.Boolean value)
            where T : FeatureDefinitionMovementAffinity
        {
            entity.SetField("speedAddBase", value);
            return entity;
        }
    }
}
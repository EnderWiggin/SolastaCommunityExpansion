﻿using System.Collections.Generic;
using SolastaModApi;
using SolastaCommunityExpansion.Builders;
using SolastaCommunityExpansion.Builders.Features;
using SolastaModApi.Extensions;
using static RuleDefinitions;
using static SolastaModApi.DatabaseHelper.CharacterSubclassDefinitions;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionSenses;
using static SolastaModApi.DatabaseHelper.SpellDefinitions;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionMovementAffinitys;
using static SolastaModApi.DatabaseHelper.SpellListDefinitions;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionMoveModes;
using static SolastaModApi.DatabaseHelper.FeatureDefinitionBonusCantripss;

namespace SolastaCommunityExpansion.Classes.Warlock.Subclasses
{
    public static class DHWarlockSubclassMoonLitPatron
    {
        public static CharacterSubclassDefinition Build()
        {

            SpellListDefinition MoonLitExpandedSpelllist = SpellListDefinitionBuilder
                .Create(SpellListPaladin, "MoonLitExpandedSpelllist", DefinitionBuilder.CENamespaceGuid)
                .SetGuiPresentation("MoonLitExpandedSpelllist", Category.Feature)
                .ClearSpells()
                .SetSpellsAtLevel(1, FaerieFire, Sleep)
                .SetSpellsAtLevel(2, MoonBeam, SeeInvisibility)
                .SetSpellsAtLevel(3, Daylight, HypnoticPattern)
                .SetSpellsAtLevel(4, GreaterInvisibility, DominateBeast)
                .SetSpellsAtLevel(5, DominatePerson, FlameStrike)
                .FinalizeSpells()
                .AddToDB();


            FeatureDefinitionMagicAffinity MoonLitExpandedSpelllistAfinity = FeatureDefinitionMagicAffinityBuilder
                .Create("MoonLitExpandedSpelllistAfinity", DefinitionBuilder.CENamespaceGuid)
                .SetGuiPresentation("MoonLitExpandedSpelllistAfinity", Category.Feature)
                .SetExtendedSpellList(MoonLitExpandedSpelllist)
                .AddToDB();

            var Unlit = new FeatureDefinitionLightAffinity.LightingEffectAndCondition
            {
                lightingState = LocationDefinitions.LightingState.Unlit,
                condition = DatabaseHelper.ConditionDefinitions.ConditionInvisible
            };
            var Dim = new FeatureDefinitionLightAffinity.LightingEffectAndCondition
            {
                lightingState = LocationDefinitions.LightingState.Dim,
                condition = DatabaseHelper.ConditionDefinitions.ConditionInvisible
            };
            var Darkness = new FeatureDefinitionLightAffinity.LightingEffectAndCondition
            {
                lightingState = LocationDefinitions.LightingState.Darkness,
                condition = DatabaseHelper.ConditionDefinitions.ConditionInvisible
            };


            FeatureDefinitionLightAffinity MoonLitLightAffinity = FeatureDefinitionLightAffinityBuilder
                .Create("MoonLitLightAffinity", DefinitionBuilder.CENamespaceGuid)
                .SetGuiPresentation("MoonLitLightAffinity", Category.Feature)
                .AddLightingEffectAndCondition(Unlit)
                .AddLightingEffectAndCondition(Dim)
                .AddLightingEffectAndCondition(Darkness)
                .AddToDB();

            // should probably be expanded to include a magicaffinty that has immunity to darkness spells as well
            FeatureDefinitionConditionAffinity MoonLitDarknessImmunity = FeatureDefinitionConditionAffinityBuilder
                .Create("MoonLitDarknessImmunity", DefinitionBuilder.CENamespaceGuid)
                .SetGuiPresentation("MoonLitDarknessImmunity", Category.Feature)
                .SetConditionAffinityType(ConditionAffinityType.Immunity)
                .SetConditionType(DatabaseHelper.ConditionDefinitions.ConditionDarkness)
                .AddToDB();

            FeatureDefinitionPower DarkMoon = FeatureDefinitionPowerBuilder
                .Create("MoonlitDarkMoon", DefinitionBuilder.CENamespaceGuid)
                .SetGuiPresentation(Category.Power)
                .Configure(
                       1,
                       UsesDetermination.ProficiencyBonus,
                       AttributeDefinitions.Charisma,
                       ActivationTime.Action,
                       1,
                       RechargeRate.LongRest,
                       false,
                       false,
                       AttributeDefinitions.Charisma,
                       DatabaseHelper.SpellDefinitions.Darkness.EffectDescription.Copy().SetDuration(DurationType.Minute, 1),
                       true)
                .AddToDB();

            FeatureDefinitionPower FullMoon = FeatureDefinitionPowerBuilder
                .Create("MoonlitFullMoon", DefinitionBuilder.CENamespaceGuid)
                .SetGuiPresentation(Category.Power)
                .Configure(
                       1,
                       UsesDetermination.ProficiencyBonus,
                       AttributeDefinitions.Charisma,
                       ActivationTime.Action,
                       1,
                       RechargeRate.LongRest,
                       false,
                       false,
                       AttributeDefinitions.Charisma,
                       Daylight.EffectDescription.Copy().SetDuration(DurationType.Minute,1),
                       true)
                .AddToDB();


            FeatureDefinitionPower DanceoftheNightSky = FeatureDefinitionPowerBuilder
                .Create("MoonlitDanceoftheNightSky", DefinitionBuilder.CENamespaceGuid)
                .SetGuiPresentation(Category.Power)
                .Configure(
                       1,
                       UsesDetermination.Fixed,
                       AttributeDefinitions.Charisma,
                       ActivationTime.Action,
                       1,
                       RechargeRate.LongRest,
                       false,
                       false,
                       AttributeDefinitions.Charisma,
                       Fly.EffectDescription.Copy(),
                       true)
                .AddToDB();
            DanceoftheNightSky.EffectDescription.SetTargetParameter ( 4);

            ConditionDefinition MoonTouchedCondition = ConditionDefinitionBuilder
                .Create(DatabaseHelper.ConditionDefinitions.ConditionLevitate, "MoonTouchedCondition", DefinitionBuilder.CENamespaceGuid)
                .SetGuiPresentation(Category.Condition)
                .SetConditionType(ConditionType.Neutral)
                .SetFeatures(MoveModeFly2)
                .SetFeatures(MovementAffinityConditionLevitate)
                .AddToDB();

            FeatureDefinitionPower MoonTouched = FeatureDefinitionPowerBuilder
                .Create("MoonlitMoonTouched", DefinitionBuilder.CENamespaceGuid)
                .SetGuiPresentation(Category.Power)
                .Configure(
                       1,
                       UsesDetermination.Fixed,
                       AttributeDefinitions.Charisma,
                       ActivationTime.Action,
                       1,
                       RechargeRate.LongRest,
                       false,
                       false,
                       AttributeDefinitions.Charisma,
                        new EffectDescriptionBuilder()
                                .SetDurationData(
                                     DurationType.Minute,
                                     1,
                                     TurnOccurenceType.EndOfTurn)
                                .SetTargetingData(
                                    Side.All,
                                    RangeType.Distance,
                                    12,
                                    TargetType.Cylinder,
                                    10,
                                    10,
                                    ActionDefinitions.ItemSelectionType.None)
                                .SetSavingThrowData(
                                    true,
                                    false,
                                    AttributeDefinitions.Dexterity,
                                    true,
                                    EffectDifficultyClassComputation.AbilityScoreAndProficiency,
                                    AttributeDefinitions.Dexterity,
                                    20,
                                    false,
                                    new List<SaveAffinityBySenseDescription>())
                                .AddEffectForm(new EffectFormBuilder()
                                    .SetConditionForm(
                                        MoonTouchedCondition,
                                        ConditionForm.ConditionOperation.Add,
                                        false,
                                        false,
                                        new List<ConditionDefinition>())
                                        .HasSavingThrow(EffectSavingThrowType.Negates)
                                    .Build())
                                .AddEffectForm(new EffectFormBuilder()
                                    .SetMotionForm(
                                        MotionForm.MotionType.Levitate,
                                        10)
                                    .HasSavingThrow(EffectSavingThrowType.Negates)
                                    .Build())
                                .SetRecurrentEffect(Entangle.EffectDescription.RecurrentEffect)
                                .Build()
                       ,
                       true)
                .AddToDB();



            SpellDefinition AtWillMoonbeam = SpellDefinitionBuilder
                .Create(MoonBeam, "MoonlitAtWillMoonbeam", DefinitionBuilder.CENamespaceGuid)
                .SetSpellLevel(0)
                .AddToDB();

            SpellDefinition AtWillFaerieFire = SpellDefinitionBuilder
                .Create(FaerieFire, "MoonlitAtWillFaerieFire", DefinitionBuilder.CENamespaceGuid)
                .SetSpellLevel(0)
                .AddToDB();

            FeatureDefinitionBonusCantrips MoonlitBonusCantrips = FeatureDefinitionBonusCantripsBuilder
                .Create(BonusCantripsDomainSun,"MoonlitBonusCantrips", DefinitionBuilder.CENamespaceGuid)
                .SetGuiPresentation("MoonlitBonusCantrips", Category.Feat)
                .ClearBonusCantrips()
                .AddBonusCantrip(AtWillMoonbeam)
                .AddBonusCantrip(AtWillFaerieFire)
                .AddToDB();
            /*
             Moonlit
            1
            Lunar Guide Expanded Spells or Moonlit Expanded Spells
            emit light (maybe indomitable light) + tempHP aura
            light affinity invisible in darkness/dim light
            6
            Cycles of the Moon
            Full Moon (cast daylight)
            Dark New (cast darkness)
            10
            Dance of the Night Sky (casting fly on 4 people)
            Moon touched (cast reverse gravity without expending a spell slot)
            14
            moonbeam , faerie fire- at will
             */

            return CharacterSubclassDefinitionBuilder
                .Create("MoonLit", DefinitionBuilder.CENamespaceGuid)
                .SetGuiPresentation("WarlockMoonLit", Category.Subclass, RangerShadowTamer.GuiPresentation.SpriteReference)
                .AddFeatureAtLevel(MoonLitExpandedSpelllistAfinity, 1)
                .AddFeatureAtLevel(MoonLitLightAffinity, 1)
                .AddFeatureAtLevel(SenseSuperiorDarkvision, 1)
              //  .AddFeatureAtLevel(ConditionAffinityBlindnessImmunity, 1)
                .AddFeatureAtLevel(MoonLitDarknessImmunity, 1)
                .AddFeatureAtLevel(FullMoon, 6)
                .AddFeatureAtLevel(DarkMoon, 6)
                // .AddFeatureAtLevel(, 6)
                .AddFeatureAtLevel(DanceoftheNightSky, 10)
                .AddFeatureAtLevel(MoonTouched, 10)
                .AddFeatureAtLevel(MoonlitBonusCantrips, 14)
                // .AddFeatureAtLevel(, 14)
                .AddToDB();
        }

    }
}


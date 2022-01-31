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
    [TargetType(typeof(SoundEffectDescription))]
    public static partial class SoundEffectDescriptionExtensions
    {
        public static T SetGuiPickBody<T>(this T entity, AK.Wwise.Event value)
            where T : SoundEffectDescription
        {
            entity.SetField("guiPickBody", value);
            return entity;
        }

        public static T SetGuiPickOther<T>(this T entity, AK.Wwise.Event value)
            where T : SoundEffectDescription
        {
            entity.SetField("guiPickOther", value);
            return entity;
        }

        public static T SetGuiStoreBody<T>(this T entity, AK.Wwise.Event value)
            where T : SoundEffectDescription
        {
            entity.SetField("guiStoreBody", value);
            return entity;
        }

        public static T SetGuiStoreOther<T>(this T entity, AK.Wwise.Event value)
            where T : SoundEffectDescription
        {
            entity.SetField("guiStoreOther", value);
            return entity;
        }

        public static T SetStartEvent<T>(this T entity, AK.Wwise.Event value)
            where T : SoundEffectDescription
        {
            entity.SetField("startEvent", value);
            return entity;
        }

        public static T SetStartSwitch<T>(this T entity, AK.Wwise.Switch value)
            where T : SoundEffectDescription
        {
            entity.SetField("startSwitch", value);
            return entity;
        }

        public static T SetStopEvent<T>(this T entity, AK.Wwise.Event value)
            where T : SoundEffectDescription
        {
            entity.SetField("stopEvent", value);
            return entity;
        }

        public static T SetStopSwitch<T>(this T entity, AK.Wwise.Switch value)
            where T : SoundEffectDescription
        {
            entity.SetField("stopSwitch", value);
            return entity;
        }
    }
}
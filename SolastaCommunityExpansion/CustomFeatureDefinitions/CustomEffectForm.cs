﻿using System.Collections.Generic;
using SolastaCommunityExpansion.Helpers;

namespace SolastaCommunityExpansion.CustomFeatureDefinitions
{
    /**
     * This adds the ability to do fully custom EffectForms. If possible you should use the standard EffectForms.
     * Damage and healing done through this CustomEffectForm will not trigger the proper events.
     */
    public abstract class CustomEffectForm : EffectForm
    {
        public CustomEffectForm()
        {
            this.FormType = (EffectFormType)ExtraEffectFormType.Custom;
        }

        public abstract void ApplyForm(
            RulesetImplementationDefinitions.ApplyFormsParams formsParams,
            bool retargeting,
            bool proxyOnly,
            bool forceSelfConditionOnly);

        public abstract void FillTags(Dictionary<string, TagsDefinitions.Criticity> tagsMap);
    }
}
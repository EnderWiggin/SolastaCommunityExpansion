﻿using System;
using SolastaModApi.Extensions;

namespace SolastaCommunityExpansion.Builders
{
    public class MonsterAttackDefinitionBuilder : DefinitionBuilder<MonsterAttackDefinition, MonsterAttackDefinitionBuilder>
    {
        #region Constructors
        protected MonsterAttackDefinitionBuilder(string name, Guid namespaceGuid) : base(name, namespaceGuid)
        {
        }

        protected MonsterAttackDefinitionBuilder(string name, string definitionGuid) : base(name, definitionGuid)
        {
        }

        protected MonsterAttackDefinitionBuilder(MonsterAttackDefinition original, string name, Guid namespaceGuid) : base(original, name, namespaceGuid)
        {
        }

        protected MonsterAttackDefinitionBuilder(MonsterAttackDefinition original, string name, string definitionGuid) : base(original, name, definitionGuid)
        {
        }
        #endregion

        public MonsterAttackDefinitionBuilder SetDamageBonusOfFirstDamageForm(int value)
        {
            var form = Definition.EffectDescription.GetFirstFormOfType(EffectForm.EffectFormType.Damage);
            form?.DamageForm.SetBonusDamage(value);
            return this;
        }
    }
}

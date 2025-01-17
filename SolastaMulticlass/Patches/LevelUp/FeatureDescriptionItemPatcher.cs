﻿using System.Collections.Generic;
using System.Reflection.Emit;
using HarmonyLib;
using SolastaMulticlass.Models;
using TMPro;

namespace SolastaMulticlass.Patches.LevelUp
{
    internal static class FeatureDescriptionItemPatcher
    {
        [HarmonyPatch(typeof(FeatureDescriptionItem), "Bind")]
        internal static class FeatureDescriptionItemBind
        {
            public static void DisableDropdownIfMulticlass(GuiDropdown choiceDropdown)
            {
                var characterBuildingService = ServiceRepository.GetService<ICharacterBuildingService>();
                var currentLocalHeroCharacter = characterBuildingService.CurrentLocalHeroCharacter;
                var isClassSelectionStage = LevelUpContext.IsClassSelectionStage(currentLocalHeroCharacter);
                var isMulticlass = LevelUpContext.IsMulticlass(currentLocalHeroCharacter);

                if (!(isClassSelectionStage && isMulticlass))
                {
                    return;
                }

                choiceDropdown.gameObject.SetActive(false);
            }

            internal static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
            {
                var setValueMethod = typeof(TMP_Dropdown).GetMethod("set_value");
                var choiceDropdownField = typeof(FeatureDescriptionItem).GetField("choiceDropdown", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                var disableDropdownIfMulticlassMethod = typeof(FeatureDescriptionItemBind).GetMethod("DisableDropdownIfMulticlass");

                foreach (var instruction in instructions)
                {
                    yield return instruction;

                    if (instruction.Calls(setValueMethod))
                    {
                        yield return new CodeInstruction(OpCodes.Ldarg_0);
                        yield return new CodeInstruction(OpCodes.Ldfld, choiceDropdownField);
                        yield return new CodeInstruction(OpCodes.Call, disableDropdownIfMulticlassMethod);
                    }
                }
            }
        }
    }
}

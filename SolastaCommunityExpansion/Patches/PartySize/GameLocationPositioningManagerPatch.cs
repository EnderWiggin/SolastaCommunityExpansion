﻿using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Reflection.Emit;

namespace SolastaDungeonMakerPro.Patches.PartySize
{
    // avoids a trace message when party greater than 4
    [HarmonyPatch(typeof(GameLocationPositioningManager), "CharacterMoved", new Type[] { typeof(GameLocationCharacter), typeof(TA.int3), typeof(TA.int3), typeof(RulesetActor.SizeParameters), typeof(RulesetActor.SizeParameters) })]
    [SuppressMessage("Minor Code Smell", "S101:Types should be named in PascalCase", Justification = "Patch")]
    internal static class GameLocationPositioningManager_CharacterMoved
    {
        internal static IEnumerable<CodeInstruction> Transpiler(IEnumerable<CodeInstruction> instructions)
        {
            var logErrorMethod = typeof(Trace).GetMethod("LogError", BindingFlags.Public | BindingFlags.Static, Type.DefaultBinder, new Type[1] { typeof(string) }, null);
            int found = 0;

            foreach (CodeInstruction instruction in instructions)
            {
                if (instruction.Calls(logErrorMethod) && ++found == 1)
                {
                    yield return new CodeInstruction(OpCodes.Pop);
                }
                else
                {
                    yield return instruction;
                }
            }
        }
    }
}
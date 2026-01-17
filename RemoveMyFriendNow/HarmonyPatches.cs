using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace RemoveMyFriendNow
{
    public class HarmonyPatches
    {
        [HarmonyPatch(typeof(FriendCard), "SetButtonState")]
        class DelayGoByeBye
        {
            static void Postfix(FriendCard __instance)
            {
                var buttvalue = AccessTools.Field(typeof(FriendCard), "_button");
                var button = buttvalue.GetValue(__instance) as GorillaPressableDelayButton;
                    if (button != null && button.delayTime > 0f)
                    {
                        button.delayTime = 0.10f;
                    }
                }
            }
        }
}

   


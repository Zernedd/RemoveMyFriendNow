using BepInEx;
using GorillaLocomotion;
using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
namespace RemoveMyFriendNow
{
    [BepInPlugin("com.Zern.removemyfriendnow", "Remove My Friend Now", "1.0.0")]
    public class MainClass : BaseUnityPlugin
    {
        void Awake()
        {
            Harmony harmony = new Harmony("com.Zern.RemoveFriends");
            harmony.PatchAll();
            GorillaTagger.OnPlayerSpawned(() =>
            {
                Debug.Log("Remove My Friend Now loaded and such");
            });
        }
    }
}

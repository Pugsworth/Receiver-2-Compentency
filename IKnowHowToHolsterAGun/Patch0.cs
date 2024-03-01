using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using HarmonyLib;

using Receiver2;

namespace IKnowHowToHolsterAGun
{
    [HarmonyPatch(typeof(Receiver2.LocalAimHandler), "AccidentallyPullTrigger")]
    internal class Patch0
    {
        static bool Prefix(Receiver2.LocalAimHandler __instance, GunScript gun, ref float odds)
        {
            return false;
        }
    }
}

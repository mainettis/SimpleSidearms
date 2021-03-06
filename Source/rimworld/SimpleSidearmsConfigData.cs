﻿using HugsLib.Utils;
using RimWorld.Planet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace SimpleSidearms.rimworld
{
    public class SimpleSidearmsConfigData : WorldComponent
    {
        public Dictionary<int, GoldfishModule> memories = new Dictionary<int, GoldfishModule>();


        public SimpleSidearmsConfigData(World world) : base(world)
        {
        }

        public override void ExposeData()
        {
            base.ExposeData();
            Scribe_Collections.Look<int, GoldfishModule>(ref memories, "memories", LookMode.Value, LookMode.Deep);
            if (Scribe.mode == LoadSaveMode.LoadingVars)
            {
                if (memories == null) 
                    memories = new Dictionary<int, GoldfishModule>();
            }
        }
    }
}

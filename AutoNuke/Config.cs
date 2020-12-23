﻿using Synapse.Config;
using System.ComponentModel;

namespace AutoNuke
{
    public class Config : AbstractConfigSection
    {
        [Description("How long until nuke goes off? (-1 = not), (IN SECONDS)")]
        public float AutoNukeTime { get; set; } = 600;
    }
}

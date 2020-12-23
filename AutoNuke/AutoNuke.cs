<<<<<<< HEAD
﻿using System.Collections.Generic;
=======
using System.Collections.Generic;
>>>>>>> 6d88ed2a59191871f913efdf0e1f601e56df60a3
using MEC;
using Synapse.Api.Plugin;

namespace AutoNuke
{
    [PluginInformation(
    Author = "TypicalIllusion",
    Description = "AutoNuke",
    LoadPriority = 0,
    Name = "AutoNuke",
    SynapseMajor = 2,
    SynapseMinor = 3,
<<<<<<< HEAD
    SynapsePatch = 1,
=======
    SynapsePatch = 0,
>>>>>>> 6d88ed2a59191871f913efdf0e1f601e56df60a3
    Version = "1.2.0"
)]
    class AutoNuke : AbstractPlugin
    {
        public static List<CoroutineHandle> Coroutine = new List<CoroutineHandle>();
        [Synapse.Api.Plugin.Config(section = "AutoNuke")]
        public static Config Config;
        public override void Load()
        {
            SynapseController.Server.Logger.Info("AutoNuke Loaded");
            new EventHandlers();
        }
    }
}

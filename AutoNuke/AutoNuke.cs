<<<<<<< HEAD
﻿using System.Collections.Generic;
using MEC;
=======
>>>>>>> 7b7ea67580596c0d9724639920c343d9a64ca741
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
    SynapsePatch = 0,
<<<<<<< HEAD
    Version = "1.2.0"
)]
    class AutoNuke : AbstractPlugin
    {
        public static List<CoroutineHandle> Coroutine = new List<CoroutineHandle>();
=======
    Version = "1.1.0"
)]
    class AutoNuke : AbstractPlugin
    {
>>>>>>> 7b7ea67580596c0d9724639920c343d9a64ca741
        [Synapse.Api.Plugin.Config(section = "AutoNuke")]
        public static Config Config;
        public override void Load()
        {
            SynapseController.Server.Logger.Info("AutoNuke Loaded");
            new EventHandlers();
        }
    }
}

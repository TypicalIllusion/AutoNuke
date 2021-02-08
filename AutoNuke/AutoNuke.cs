using System.Collections.Generic;
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
<<<<<<< HEAD
    SynapseMinor = 5,
    SynapsePatch = 0,
    Version = "1.3.0"
=======
    SynapseMinor = 4,
    SynapsePatch = 2,
    Version = "1.2.5"
>>>>>>> master
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

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
    SynapseMinor = 5,
    SynapsePatch = 3,
    Version = "1.3.5"
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

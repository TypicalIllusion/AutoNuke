﻿using Synapse.Api.Plugin;

namespace AutoNuke
{
    [PluginInformation(
    Author = "TypicalIllusion",
    Description = "AutoNuke",
    LoadPriority = 0,
    Name = "AutoNuke",
    SynapseMajor = 2,
    SynapseMinor = 2,
    SynapsePatch = 0,
    Version = "2.0.0"
)]
    class AutoNuke : AbstractPlugin
    {
        public static AutoNuke Singleton { get; private set; }
        [Synapse.Api.Plugin.Config(section = "AutoNuke")]
        public static Config Config;
        public override void Load()
        {
            Singleton = this;
            SynapseController.Server.Logger.Info("AutoNuke Loaded");
            new EventHandlers();
        }

        public override void ReloadConfigs()
        {

        }
    }
}

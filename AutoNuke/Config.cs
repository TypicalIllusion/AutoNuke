using Synapse.Config;
using System.ComponentModel;

namespace AutoNuke
{
    public class Config : AbstractConfigSection
    {
        [Description("How long until nuke goes off? (-1 = not), (in seconds)")]
        public float AutoNukeTime { get; set; } = 600;
        [Description("What is the broadcast message?")]
        public string AutoNukeMessage { get; set; } = "AutoNuke is going off!";
        [Description("Should AutoNuke be cancelable?")]
        public bool Cancelable { get; set; } = true;
    }
}

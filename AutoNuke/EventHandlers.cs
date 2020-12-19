using MEC;
using Synapse;
using Synapse.Api;
using System.Collections.Generic;

namespace AutoNuke
{
    class EventHandlers
    {
        public EventHandlers()
        {
            Server.Get.Events.Map.WarheadDetonationEvent += Map_WarheadDetonationEvent;
        }

        private void Map_WarheadDetonationEvent()
        {
            if (AutoNuke.Config.AutoNukeTime > -1)
            {
                Timing.RunCoroutine(AutoNukeDur(AutoNuke.Config.AutoNukeTime));
            }
        }
        private IEnumerator<float> AutoNukeDur(float duration)
        {
            yield return Timing.WaitForSeconds(AutoNuke.Config.AutoNukeTime);
            Map.Get.Nuke.StartDetonation();
            Map.Get.Nuke.InsidePanel.Locked = true;
        }
    }
}

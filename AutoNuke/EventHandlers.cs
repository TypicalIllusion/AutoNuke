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
            Server.Get.Events.Round.RoundStartEvent += Round_RoundStartEvent;
            Server.Get.Events.Round.RoundEndEvent += Round_RoundEndEvent;
        }

        private void Round_RoundStartEvent()
        {
            if (AutoNuke.Config.AutoNukeTime > -1 && !Map.Get.Nuke.Detonated)
            {
                Timing.RunCoroutine(AutoNukeDur(AutoNuke.Config.AutoNukeTime));
            }
        }
        private void Round_RoundEndEvent()
        {
            foreach (CoroutineHandle coroutine in AutoNuke.Coroutine)
                Timing.KillCoroutines(coroutine);
        }
        private IEnumerator<float> AutoNukeDur(float duration)
        {
            yield return Timing.WaitForSeconds(AutoNuke.Config.AutoNukeTime);
            Map.Get.Nuke.StartDetonation();
            Map.Get.Nuke.InsidePanel.Locked = true;
        }
    }
}

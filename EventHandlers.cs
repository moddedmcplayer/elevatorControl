using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.Events.EventArgs;

namespace elevatorControl
{
    public class EventHandlers
    {
        private Config cfg;

        public EventHandlers(Plugin plugin)
        {
            cfg = plugin.Config;
        }

        public void InteractingElevator(InteractingElevatorEventArgs ev)
        {
            ev.Lift.movingSpeed = cfg.ElevatorTime;
        }
    }
}

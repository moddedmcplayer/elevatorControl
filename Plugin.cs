using System;
using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;

namespace elevatorControl
{
    public class Plugin : Plugin<Config>
    {
        public override string Author { get; } = "moddedmcplayer";
        public override string Name { get; } = "elevatorControl";
        public override Version Version { get; } = new Version(0, 1, 0);
        public override Version RequiredExiledVersion { get; } = new Version(5, 0, 0);

        public EventHandlers EventHandler;

        public override void OnEnabled()
        {
            RegisterEvents(); 
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            UnRegisterEvents();
            base.OnDisabled();
        }

        private void RegisterEvents()
        {
            EventHandler = new EventHandlers(this);
            Player.InteractingElevator += EventHandler.InteractingElevator;
        }

        private void UnRegisterEvents()
        {
            Player.InteractingElevator -= EventHandler.InteractingElevator;
            EventHandler = null;
        }
    }
}

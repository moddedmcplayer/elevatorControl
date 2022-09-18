using System.ComponentModel;
using Exiled.API.Interfaces;

namespace elevatorControl
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("How long an elevator takes in seconds")]
        public float ElevatorTime { get; set; } = 6f;
    }
}

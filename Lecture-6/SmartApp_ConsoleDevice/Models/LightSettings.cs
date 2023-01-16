using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartApp_ConsoleDevice.Models
{
    internal class LightSettings : DeviceSettings
    {
        public bool LightState { get; set; } = false;
        public override string DeviceType { get; set; } = "light";
    }
}

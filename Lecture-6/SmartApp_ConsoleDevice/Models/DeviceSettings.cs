using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartApp_ConsoleDevice.Models
{
    internal class DeviceSettings
    {
        public string DeviceId { get; set; } = null!;
        public string ConnectionString { get; set; } = null!;
        public string DeviceName { get; set; } = null!;
        public virtual string DeviceType { get; set; } = null!;
        public string Location { get; set; } = null!;

    }
}

using Newtonsoft.Json;
using SmartApp_ConsoleDevice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartApp_ConsoleDevice.Handlers
{
    internal class DeviceConfigurationHandler
    {
        private LightSettings _settings;
        private string _filePath;

        public DeviceConfigurationHandler(string filePath)
        {
            _filePath = filePath;
            _settings = new LightSettings();
            GetConfigurationAsync().ConfigureAwait(true);
        }

        public LightSettings GetSettings() => _settings;
        public async Task SaveSettingsAsync(LightSettings settings)
        {
            _settings = settings;
            await SaveConfigurationAsync();
        }
        private async Task GetConfigurationAsync()
        {
            try
            {
                using var sr = new StreamReader(_filePath);
                _settings = JsonConvert.DeserializeObject<LightSettings>(await sr.ReadToEndAsync())!;
            }
            catch { }
        }
        private async Task SaveConfigurationAsync()
        {
            try
            {
                using var sw = new StreamWriter(_filePath);
                await sw.WriteLineAsync(JsonConvert.SerializeObject(_settings));
            }
            catch { }
        }
    }
}

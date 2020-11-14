using System;
using System.Threading.Tasks;
using WeatherApp.Models;
using WeatherApp.ViewModels;

namespace OpenWeatherAPI
{
    public class OpenWeatherService : ITemperatureService
    {
        private OpenWeatherProcessor owp;
        public TemperatureModel LastTemp = new TemperatureModel();

        public OpenWeatherService(string apiKey)
        {
            owp = OpenWeatherProcessor.Instance;
            owp.ApiKey = apiKey;
        }
        public async Task<TemperatureModel> GetTempAsync()
        {
            var result = await owp.GetCurrentWeatherAsync();

            long longDate = result.DateTime;
            LastTemp.DateTime.AddSeconds(longDate).ToLocalTime();
            LastTemp.Temperature = result.Main.Temperature;

            return LastTemp;
        }
    }
}

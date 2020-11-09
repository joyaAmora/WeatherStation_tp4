using System;
using System.Threading.Tasks;
using WeatherApp.Models;
using WeatherApp.ViewModels;

namespace OpenWeatherAPI
{
    public class OpenWeatherService : ITemperatureService
    {
        private OpenWeatherProcessor owp;
        public TemperatureModel LastTemp;

        public OpenWeatherService(string apiKey)
        {
            owp = OpenWeatherProcessor.Instance;
            owp.ApiKey = apiKey;

        }
        public Task<TemperatureModel> GetTempAsync()
        {
            throw new NotImplementedException();
        }
    }
}
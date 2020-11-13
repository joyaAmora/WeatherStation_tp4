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
            LastTemp.Temperature = GetTempAsync().Result.Temperature;
            LastTemp.DateTime = GetTempAsync().Result.DateTime;
        }
        public async Task<TemperatureModel> GetTempAsync()
        {
            TemperatureModel tm = new TemperatureModel();
            tm.DateTime = tm.DateTime.AddSeconds(owp.GetCurrentWeatherAsync().Result.DateTime);
            tm.Temperature = owp.GetCurrentWeatherAsync().Result.Main.Temperature;

            return tm;
        }
    }
}

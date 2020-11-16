using Microsoft.Extensions.Configuration;
using OpenWeatherAPI;
using System.Windows;
using WeatherApp.ViewModels;

namespace WeatherApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var apiKey = AppConfiguration.GetValue("OWApiKey");
            ITemperatureService temperatureService = new OpenWeatherService(apiKey);
            
            DataContext = new TemperatureViewModel(temperatureService);
        }
    }
}

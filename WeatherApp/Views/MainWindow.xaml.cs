using Microsoft.Extensions.Configuration;
using OpenWeatherAPI;
using System.Windows;

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
            AppConfiguration.GetValue("config");
            OpenWeatherService owp = new OpenWeatherService(null);
            owp.GetTempAsync();
        }
    }
}

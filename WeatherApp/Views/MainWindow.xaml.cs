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
        TemperatureViewModel vm;
        public MainWindow()
        {
            InitializeComponent();
            AppConfiguration.GetValue("OWApiKey");

            DataContext = vm;
        }
    }
}

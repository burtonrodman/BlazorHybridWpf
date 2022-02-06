using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using RazorClassLibrary1.Services;
using BlazorHybridWpf.Services;

namespace BlazorHybridWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddBlazorWebView();
            serviceCollection.AddTransient<IGeoLocationService, GeoLocationService>();

            Resources.Add("services", serviceCollection.BuildServiceProvider());
            InitializeComponent();
        }
    }
}

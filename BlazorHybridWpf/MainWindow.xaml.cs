using Microsoft.AspNetCore.Components.WebView.Wpf;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using RazorClassLibrary1;

namespace BlazorHybridWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddBlazorWebView();

            theWebView.Services = serviceCollection.BuildServiceProvider();
            theWebView.RootComponents.Add(new RootComponent()
            {
                Selector = "#app",
                ComponentType = typeof(Main)
            });
        }
    }
}

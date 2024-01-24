using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MahApps.Metro;
using MahApps.Metro.Controls;
using Microsoft.Extensions.DependencyInjection;

namespace BookshopWpf;
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : MetroWindow
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Stock_Click(object sender, RoutedEventArgs e)
        {
            var stockWindow = App.AppHost!.Services.GetRequiredService<StockWindow>();
            stockWindow.Show();
        }

        private void Settings_Click(object sender, RoutedEventArgs e)
        {
            //var settingsWindow = App.AppHost!.Services.GetRequiredService<SettingsWindow>();
            //settingsWindow.Show();
        }
    }

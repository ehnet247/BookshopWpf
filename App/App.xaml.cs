
using BookshopWpf.Login;
using BookshopWpf.Settings;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;

namespace BookshopWpf
{
    public partial class App : Application
    {
        public static IHost? AppHost { get; private set; }

        public App()
        {
            AppHost = Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddSingleton<MainMenu>();
                    services.AddTransient<StockWindow>();
                    services.AddSingleton<ILoginWindowActions, LoginWindowActions>();
                    services.AddSingleton<LoginWindow>();
                    services.AddSingleton<SettingsWindow>();
                })
                .Build();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            await AppHost!.StartAsync();
            //AppHost!.Start();

            var loginWindowActions = AppHost.Services.GetRequiredService<ILoginWindowActions>();
            loginWindowActions.CancelAction = ShowSettings;
            loginWindowActions.OkAction = ShowMainMenu;
            var loginWindow = AppHost.Services.GetRequiredService<LoginWindow>();
            loginWindow.Show();
            base.OnStartup(e);
        }

        private void ShowMainMenu()
        {
            var startupWindow = AppHost!.Services.GetRequiredService<MainMenu>();
            startupWindow.Show();
        }

        private void ShowSettings()
        {
            var settingsWindow = AppHost!.Services.GetRequiredService<SettingsWindow>();
            settingsWindow.Show();
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            // Close every subwindow
            foreach (var service in AppHost!.Services.GetServices<IBookshopService>())
            {
                service?.Close();
            }
            await AppHost!.StopAsync();
            base.OnExit(e);
        }
    }
}

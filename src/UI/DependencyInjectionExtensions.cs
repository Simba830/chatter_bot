using ChatterBot.Interfaces;
using ChatterBot.UI;
using ChatterBot.UI.ViewModels;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class DependencyInjectionExtensions
    {
        public static void AddUI(this IServiceCollection services)
        {
            services.AddSingleton<MainViewModel>();
            services.AddSingleton<AccountsViewModel>();
            services.AddSingleton<IMenuItemViewModel, TerminalViewModel>();
            services.AddSingleton<IMenuItemViewModel, AboutViewModel>();
            services.AddSingleton<IMenuItemViewModel, PluginViewModel>();
            services.AddSingleton<IMenuItemViewModel, SettingsViewModel>();
            services.AddTransient<TwitchBotViewModel>();
            services.AddTransient<TwitchStreamerViewModel>();

            services.AddSingleton<AccountsWindow>();
            services.AddSingleton<MainWindow>();
        }
    }
}
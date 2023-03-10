using ChatterBot.UI.Views;
using MahApps.Metro.IconPacks;
using System.Collections.ObjectModel;

namespace ChatterBot.UI.ViewModels
{
    public class PluginViewModel : MenuItemViewModel
    {
        public ObservableCollection<Plugin> Plugins { get; set; }

        public PluginViewModel()
            : base(new PackIconMaterial { Kind = PackIconMaterialKind.Puzzle }, "Plugins",
                "Custom Plugins", new PluginView())
        {
            Plugins = new ObservableCollection<Plugin>
            {
                new Plugin { Name = "Wasteful Game", Location = "\\WastefulGame\\",
                    Enabled = true, PluginRuntime = PluginRuntime.ChatterPlugin, Version = "1.0.0.0"},
                new Plugin { Name = "DevChatter Arcade", Location = "\\DevChatterArcade\\",
                    Enabled = true, PluginRuntime = PluginRuntime.ChatterPlugin, Version = "1.0.0.0"},
                new Plugin { Name = "Jedi/Sith Detector", Location = "\\JediSithDetector\\",
                    Enabled = true, PluginRuntime = PluginRuntime.PythonScript, Version = "1.0.0.0"},
            };
        }
    }
}
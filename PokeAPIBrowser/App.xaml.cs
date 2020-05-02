using Prism.Ioc;
using PokeAPIBrowser.Views;
using System.Windows;
using Prism.Modularity;
using DenpadokeiFramework;
using Prism.Regions;
using PokeAPIBrowser.List;

namespace PokeAPIBrowser
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<ListModule>();
            base.ConfigureModuleCatalog(moduleCatalog);
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}

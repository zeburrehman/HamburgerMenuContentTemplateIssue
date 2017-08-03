using System.Windows;
using Microsoft.Practices.Unity;
using Prism.Unity;
using Prism.Modularity;
using HamburgerMenuPlayground.Modules.ModuleA;

namespace HamburgerMenuPlayground
{
    public class BootStrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {
            var catalog = (ModuleCatalog)ModuleCatalog;
            catalog.AddModule(typeof(ModuleAModule));
        }
    }
}

using HamburgerMenuPlayground.Modules.ModuleA.Views;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamburgerMenuPlayground.Modules.ModuleA
{
    public class ModuleAModule : IModule
    {
        public IRegionManager RegionManager { get; set; }

        public ModuleAModule(IRegionManager regionManager)
        {
            RegionManager = regionManager;
        }

        public void Initialize()
        {
            RegionManager.RegisterViewWithRegion("MainContentRegion", typeof(HamburgerMenuView));
        }
    }
}

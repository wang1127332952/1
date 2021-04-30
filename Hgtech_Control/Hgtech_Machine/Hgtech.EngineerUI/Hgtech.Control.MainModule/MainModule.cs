using Hgtech.Control.MainModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace Hgtech.Control.MainModule
{
    [Module(ModuleName = "MainModule", OnDemand = false)]
    public class MainModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("AsideRegion", typeof(LeftMenuView));
            regionManager.RegisterViewWithRegion("TopDockRegion", typeof(TopView));
           // regionManager.RegisterViewWithRegion("MainRegion", typeof(ToolsModuleView));
            regionManager.RegisterViewWithRegion("FooterRegion", typeof(FooterView));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}

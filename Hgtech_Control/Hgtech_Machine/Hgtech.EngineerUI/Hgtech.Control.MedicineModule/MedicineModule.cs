using Hgtech.Control.Infrastructure.Constants;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hgtech.Control.MedicineModule
{
    public class MedicineModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            //MedicineMainContent
            //regionManager.RegisterViewWithRegion(RegionNames.MedicineMainContentRegion, typeof(MedicineMainContent));
            //SearchMedicine-Flyout
            //regionManager.RegisterViewWithRegion(RegionNames.FlyoutRegion, typeof(SearchMedicine));
            //rightWindowCommandsRegion
            //regionManager.RegisterViewWithRegion(RegionNames.ShowSearchPatientRegion, typeof(ShowSearchPatient));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}

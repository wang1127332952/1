using Hgtech.Control.Infrastructure.Constants;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hgtech.Control.PatientModule
{
    public class PatientModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();

            //PatientList
            //regionManager.RegisterViewWithRegion(RegionNames.PatientListRegion, typeof(PatientList));
            //PatientDetail-Flyout
            //regionManager.RegisterViewWithRegion(RegionNames.FlyoutRegion, typeof(PatientDetail));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
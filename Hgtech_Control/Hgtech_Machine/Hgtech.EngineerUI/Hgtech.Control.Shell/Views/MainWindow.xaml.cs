using Hgtech.Control.Infrastructure.Constants;
using MahApps.Metro.Controls;
using Prism.Ioc;
using Prism.Regions;
using System.Windows;

namespace Hgtech.Control.Shell.Views
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            var regionManager = ContainerLocator.Current.Resolve<IRegionManager>();
            if (regionManager != null)
            {
                SetRegionManager(regionManager, this.flyoutsControlRegion, RegionNames.FlyoutRegion);
                SetRegionManager(regionManager, this.rightWindowCommandsRegion, RegionNames.ShowSearchPatientRegion);
            }
        }

        void SetRegionManager(IRegionManager regionManager, DependencyObject regionTarget, string regionName)
        {
            RegionManager.SetRegionName(regionTarget, regionName);
            RegionManager.SetRegionManager(regionTarget, regionManager);
        }
    }
}

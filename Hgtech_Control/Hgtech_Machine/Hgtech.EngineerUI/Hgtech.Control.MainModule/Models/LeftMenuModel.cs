using Prism.Commands;
using Prism.Regions;
using System.Collections.Generic;

namespace Hgtech.Control.MainModule.Models
{
    public class LeftMenuModel
    {
        public bool IsSelected { get; set; }
        public string MenuName { get; set; }
        public string TargetView { get; set; }

        public List<LeftMenuModel> Children { get; set; }

        public DelegateCommand<string> OpenViewCommand { get; private set; }

        public LeftMenuModel(IRegionManager region)
        {
            OpenViewCommand = new DelegateCommand<string>((param) =>
            {
                if (!string.IsNullOrEmpty(param))
                {
                    region.RequestNavigate("MainRegion", param);
                }
            });
        }
    }
}

using Hgtech.Control.MainModule.Models;
using Prism.Regions;
using System.Collections.Generic;

namespace Hgtech.Control.MainModule.ViewModels
{
    public class LeftMenuViewModel
    {
        public List<LeftMenuModel> LeftMenuList { get; set; }

        public LeftMenuViewModel(IRegionManager region)
        {
            LeftMenuList = new List<LeftMenuModel>();
            LeftMenuList.Add(new LeftMenuModel(region)
            {
                MenuName = "Menu Management",
                TargetView = "mmView"
            });
            LeftMenuList.Add(new LeftMenuModel(region)
            {
                MenuName = "User Management",
                TargetView = "UserManagementView"
            });
            LeftMenuList.Add(new LeftMenuModel(region)
            {
                MenuName = "Customers",
                TargetView = ""
            });
            LeftMenuList.Add(new LeftMenuModel(region)
            {
                MenuName = "Delivery Partners",
                TargetView = ""
            });
            LeftMenuList.Add(new LeftMenuModel(region)
            {
                MenuName = "Promotions",
                TargetView = ""
            });
            LeftMenuList.Add(new LeftMenuModel(region)
            {
                MenuName = "Settings",
                TargetView = ""
            });
            LeftMenuList.Add(new LeftMenuModel(region)
            {
                MenuName = "Notifycations",
                TargetView = ""
            });
        }
    }
}

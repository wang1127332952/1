using Hgtech.Control.SysModule.Views;
using Prism.Ioc;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hgtech.Control.SysModule
{
    //[Module(ModuleName = "SysModule", OnDemand = true)]
    public class SysModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {

        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<MenuManageView>("mmView");
            containerRegistry.RegisterForNavigation<UserManageView>("UserManagementView");
            containerRegistry.RegisterDialog<UserEditView>();
        }
    }
}

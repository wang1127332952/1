using Hgtech.Control.Infrastructure;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace Hgtech.Control.SysModule.ViewModels
{
    public class MenuManageViewModel : BindableBase, INavigationAware
    {
        private string UriPath = "";

        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public DelegateCommand<string> CloseCommand { get; private set; }
        public DelegateCommand SaveCommand { get; private set; }


        public MenuManageViewModel(IRegionManager regionManager, IUnityContainer unityContainer, ICompositeCommands compositeCommands)
        {
            this.Title = "菜单管理";

            CloseCommand = new DelegateCommand<string>((param) =>
            {
                // 把所在Region里面的当前ViewModel对应的View移除掉
                // 操作Region

                // 通过Unity顶层容器获取对应的类型
                var obj = unityContainer.Registrations.Where(v => v.Name == UriPath).FirstOrDefault();
                string name = obj.MappedToType.Name;
                if (!string.IsNullOrEmpty(name))
                {
                    var region = regionManager.Regions["MainRegion"];
                    var view = region.Views.Where(v => v.GetType().Name == UriPath).FirstOrDefault();
                    if (view != null)
                        region.Remove(view);
                }
            });

            SaveCommand = new DelegateCommand(() =>
            {
                // 菜单保存
            });
            compositeCommands.DoCommand.RegisterCommand(SaveCommand);
        }

        public void OnNavigatedTo(NavigationContext navigationContext)
        {
            UriPath = navigationContext.Uri.ToString();
        }

        public bool IsNavigationTarget(NavigationContext navigationContext)
        {
            return true;
        }

        public void OnNavigatedFrom(NavigationContext navigationContext)
        {

        }
    }
}


using Hgtech.Control.Infrastructure;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using System.Linq;
using Unity;

namespace Hgtech.Control.SysModule.ViewModels
{
    public class UserManageViewModel : BindableBase, INavigationAware
    {
        private string UriPath = "";

        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public DelegateCommand<string> CloseCommand { get; private set; }
        public DelegateCommand OpenDialogCommand { get; private set; }
        public DelegateCommand SaveCommand { get; private set; }
        public UserManageViewModel(IRegionManager regionManager, IUnityContainer unityContainer, IDialogService dialogService, ICompositeCommands compositeCommands)
        {
            this.Title = "用户管理";

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
                    var view = region.Views.Where(v => v.GetType().Name == name).FirstOrDefault();
                    if (view != null)
                    { 
                        region.Remove(view);
                    }
                }
            });

            OpenDialogCommand = new DelegateCommand(() =>
            {
                DialogParameters param = new DialogParameters();
                // View的注册名称 - 参数键值对 - 弹窗回调 - 指定弹出窗口的注册名称
                dialogService.ShowDialog("UserEditView", param,
                    (result) =>
                    {

                    });
            });

            SaveCommand = new DelegateCommand(() =>
            {
                // 用户 保存
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


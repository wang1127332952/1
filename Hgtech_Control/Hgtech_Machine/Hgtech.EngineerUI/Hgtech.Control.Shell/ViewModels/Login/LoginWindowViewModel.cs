using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using Hgtech.Control.Infrastructure.Constants;
using Hgtech.Control.Infrastructure.IServices;

namespace Hgtech.Control.Shell.ViewModels.Login
{
    public class LoginWindowViewModel:BindableBase
    {
        #region Fileids
        private readonly IRegionManager _regionManager;
        private readonly IUserService _userService;
        private readonly IDialogService _dialogService;
        #endregion

        #region Properties


        #endregion

        #region Commands
        private DelegateCommand _loginLoadingCommand;
        public DelegateCommand LoginLoadingCommand =>
            _loginLoadingCommand ?? (_loginLoadingCommand = new DelegateCommand(ExecuteLoginLoadingCommand));


        #endregion

        #region  Excutes
        void ExecuteLoginLoadingCommand()
        {
            //_regionManager.RequestNavigate(RegionNames.LoginContentRegion, "LoginMainContent");
            IRegion region = _regionManager.Regions[RegionNames.LoginContentRegion];
            region.RequestNavigate("LoginMainContent", NavigationCompelted);
            Global.AllUsers = _userService.GetAllUsers();
        }

        #endregion
        public LoginWindowViewModel(IRegionManager regionManager, IUserService userService, IDialogService dialogService)
        {
            _regionManager = regionManager;
            _userService = userService;
            _dialogService = dialogService;
        }

        private void NavigationCompelted(NavigationResult result)
        {
            if (result.Result == true)
            {
                _dialogService.Show("SuccessDialog", new DialogParameters($"message={"导航到LoginMainContent页面成功"}"), null);
            }
            else
            {
                _dialogService.Show("WarningDialog", new DialogParameters($"message={"导航到LoginMainContent页面失败"}"), null);
            }
        }

    }
}

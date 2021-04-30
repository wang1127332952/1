using Hgtech.Control.Infrastructure;
using Hgtech.Control.Infrastructure.CustomerRegionAdapters;
using Hgtech.Control.Infrastructure.IServices;
using Hgtech.Control.Infrastructure.Models;
using Hgtech.Control.Infrastructure.Services;
using Hgtech.Control.Shell.ViewModels.Dialogs;
using Hgtech.Control.Shell.Views.Dialogs;
using Hgtech.Control.Shell.Views.Login;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using Prism.Unity;
using System.Windows;
using System.Windows.Controls.Primitives;
using Unity;
using Unity.Interception;
using Unity.Interception.ContainerIntegration;
using Unity.Interception.Interceptors.InstanceInterceptors.InterfaceInterception;
using Unity.Interception.PolicyInjection;

namespace Hgtech.Control.Shell
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
        }
        protected override Window CreateShell()
        {
            //return Container.Resolve<MainWindow>();
            return Container.Resolve<LoginWindow>();
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            var container = PrismIocExtensions.GetContainer(containerRegistry);
            container.AddNewExtension<Interception>()//add Extension Aop
                                                     //注册服务和添加显示拦截
             .RegisterType<IUserService, UserService>(new Interceptor<InterfaceInterceptor>(), new InterceptionBehavior<PolicyInjectionBehavior>());

            //注册全局命令
            containerRegistry.RegisterSingleton<IApplicationCommands, ApplicationCommands>();
            containerRegistry.RegisterInstance<IFlyoutService>(Container.Resolve<FlyoutService>());

            // 注册复合命令
            containerRegistry.RegisterSingleton<ICompositeCommands, CompositeCommands>();

            //注册导航
            containerRegistry.RegisterForNavigation<LoginMainContent>();

            //注册对话框
            containerRegistry.RegisterDialog<SuccessDialog, SuccessDialogViewModel>();
            containerRegistry.RegisterDialog<WarningDialog, WarningDialogViewModel>();
        }
        protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
        {
            base.ConfigureRegionAdapterMappings(regionAdapterMappings);
            regionAdapterMappings.RegisterMapping(typeof(UniformGrid), Container.Resolve<UniformGridRegionAdapter>());
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new DirectoryModuleCatalog() { ModulePath = @".\Modules" };
        }

    }
}

using MvvmCross.WindowsUWP.Platform;
using MvvmCross.Core.ViewModels;
using XamarinMALDemo.Interfaces;
using MvvmCross.Platform;
using XamarinMALDemo.Uwp.Services;
using MvvmCross.Platform.Plugins;
using MvvmCross.WindowsUWP.Views;
using MvvmCross.Forms.Presenter.Core;
using Windows.UI.Xaml.Controls;
using Windows.ApplicationModel.Activation;
using MvvmCross.Core.Views;

namespace XamarinMALDemo.Uwp
{
    public class Setup : MvxWindowsSetup
    {
        LaunchActivatedEventArgs _args;
        public Setup(Frame rootFrame, LaunchActivatedEventArgs e) : base(rootFrame)
        {
            _args = e;
        }

        protected override IMvxApplication CreateApp()
        {
            var app = new XamarinMALDemo.App();
            Mvx.RegisterSingleton<IUserDialogService>(new UserDialogService());
            Mvx.RegisterSingleton<INetworkService>(new NetworkService());
            return app;
        }

        protected override IMvxWindowsViewPresenter CreateViewPresenter(IMvxWindowsFrame rootFrame)
        {
            Xamarin.Forms.Forms.Init(_args);

            var xamarinFormsApp = new MvxFormsApp();

            var presenter = new ViewPresenter(rootFrame, xamarinFormsApp);
            Mvx.RegisterSingleton<IMvxViewPresenter>(presenter);
            return presenter;
        }
    }
}

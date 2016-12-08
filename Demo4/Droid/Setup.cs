using Android.Content;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Views;
using MvvmCross.Droid.Views;
using MvvmCross.Platform;
using XamarinMALDemo.Interfaces;
using XamarinMALDemo.Droid.Services;

namespace XamarinMALDemo.Droid
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            var app = new App();
            Mvx.RegisterSingleton<IUserDialogService>(new UserDialogService());
            Mvx.RegisterSingleton<INetworkService>(new NetworkService());
            return app;
        }

        protected override IMvxAndroidViewPresenter CreateViewPresenter()
        {
            var presenter = new ViewPresenter();
            Mvx.RegisterSingleton<IMvxViewPresenter>(presenter);

            return presenter;
        }
    }
}
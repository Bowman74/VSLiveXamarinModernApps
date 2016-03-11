using Android.Content;
using MvvmCross.Droid.Platform;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.Platform;
using MvvmCross.Platform;
using XamarinMALDemo1.Interfaces;
using XamarinMALDemo1.Droid.Services;

namespace XamarinMALDemo1.Droid
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
    }
}
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views;
using MvvmCross.Platform;
using UIKit;
using XamarinMALDemo1.iOS.Services;
using XamarinMALDemo1.Interfaces;

namespace XamarinMALDemo1.iOS
{
	public class Setup : MvxIosSetup
	{
		public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
            : base(applicationDelegate, window)
		{
		}

		protected override IMvxApplication CreateApp()
		{
			var app =  new App();
            Mvx.RegisterSingleton<IUserDialogService>(new UserDialogService());
            Mvx.RegisterSingleton<INetworkService>(new NetworkService());
		    return app;
		}

        protected override IMvxIosViewsContainer CreateIosViewsContainer()
        {
            return new ViewsContainer();
        }
    }
}
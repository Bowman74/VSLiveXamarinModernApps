using MvvmCross.Core.ViewModels;
using MvvmCross.Forms.Presenter.Core;
using MvvmCross.iOS.Platform;
using MvvmCross.iOS.Views.Presenters;
using MvvmCross.Platform;
using UIKit;
using Xamarin.Forms;
using XamarinMALDemo2.iOS.Services;
using XamarinMALDemo2.Interfaces;

namespace XamarinMALDemo2.iOS
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

        protected override IMvxIosViewPresenter CreatePresenter()
        {
            Forms.Init();

            var xamarinFormsApp = new MvxFormsApp();

            return new ViewPresenter(Window, xamarinFormsApp);
        }
    }
}
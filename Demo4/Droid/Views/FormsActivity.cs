using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Views;
using MvvmCross.Forms.Presenter.Droid;
using MvvmCross.Platform;
using Xamarin.Forms;

namespace XamarinMALDemo.Droid.Views
{
    [Activity(Label = "XamarinMALDemo4"
        , Icon = "@mipmap/ic_launcher"
        , ScreenOrientation = ScreenOrientation.Portrait
        , Theme = "@style/MyTheme")]
    public class FormsActivity : ActivityBase
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Forms.Init(this, savedInstanceState);
            var formsApp = new FormsApp();
            LoadApplication(formsApp);

            var presenter = (MvxFormsDroidPagePresenter)Mvx.Resolve<IMvxViewPresenter>();
            presenter.MvxFormsApp = formsApp;

            ToolbarResource = Resource.Layout.toolbar;

            Mvx.Resolve<IMvxAppStart>().Start();
        }
    }
}
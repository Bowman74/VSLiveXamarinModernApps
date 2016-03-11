using Android.App;
using Android.Content.PM;
using Android.OS;
using MvvmCross.Core.ViewModels;
using MvvmCross.Core.Views;
using MvvmCross.Forms.Presenter.Droid;
using MvvmCross.Platform;
using Xamarin.Forms;

namespace XamarinMALDemo3.Droid.Views
{
    [Activity(Label = "XamarinMALDemo3"
        , Icon = "@mipmap/ic_launcher"
        , ScreenOrientation = ScreenOrientation.Portrait
        , Theme = "@android:style/Theme.Holo.Light")]
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

            Mvx.Resolve<IMvxAppStart>().Start();
        }
    }
}
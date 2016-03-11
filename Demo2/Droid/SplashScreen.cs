using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;
using Xamarin.Forms;
using XamarinMALDemo2.Droid.Views;

namespace XamarinMALDemo2.Droid
{
    [Activity(
		Label = "XamarinMALDemo2"
		, MainLauncher = true
		, NoHistory = true
        , Icon = "@mipmap/ic_launcher"
        , ScreenOrientation = ScreenOrientation.Portrait
        , Theme = "@android:style/Theme.Holo.Light")]
    public class SplashScreen : MvxSplashScreenActivity
    {
        public SplashScreen()
            : base(Resource.Layout.SplashScreen)
        {
        }

        private bool isInitializationComplete = false;
        public override void InitializationComplete()
        {
            if (!isInitializationComplete)
            {
                isInitializationComplete = true;
                StartActivity(typeof(FormsActivity));
            }
        }
    }
}
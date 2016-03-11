using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;
using Xamarin.Forms;
using XamarinMALDemo3.Droid.Views;

namespace XamarinMALDemo3.Droid
{
    [Activity(
		Label = "XamarinMALDemo3"
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
using Android.App;
using Android.Content.PM;
using MvvmCross.Droid.Views;

namespace XamarinMALDemo1.Droid
{
    [Activity(
		Label = "XamarinMALDemo1.Droid"
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
    }
}
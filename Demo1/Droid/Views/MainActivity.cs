using Android.App;
using Android.OS;
using XamarinMALDemo1.ViewModels;

namespace XamarinMALDemo1.Droid.Views
{
    [Activity(Label = "XamarinMALDemo1", MainLauncher = false)]
    public class MainActivity : ActivityBase<MainViewModel>
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}
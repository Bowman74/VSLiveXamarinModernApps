using MvvmCross.Platform;
using Xamarin.Forms.Platform.Android;
using XamarinMALDemo.Interfaces;
using XamarinMALDemo.Droid.Services;

namespace XamarinMALDemo.Droid.Views
{
    public class ActivityBase : FormsAppCompatActivity
    {
        protected override void OnResume()
        {
            base.OnResume();
            var userDialog = (UserDialogService) Mvx.Resolve<IUserDialogService>();
            userDialog.CurrentActivity = this;
        }

        protected override void OnPause()
        {
            base.OnPause();
            var userDialog = (UserDialogService) Mvx.Resolve<IUserDialogService>();
            userDialog.CurrentActivity = null;
        }
    }
}
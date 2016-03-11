using MvvmCross.Platform;
using Xamarin.Forms.Platform.Android;
using XamarinMALDemo2.Interfaces;
using XamarinMALDemo2.Droid.Services;

namespace XamarinMALDemo2.Droid.Views
{
    public class ActivityBase : FormsApplicationActivity
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
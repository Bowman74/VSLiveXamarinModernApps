using System;
using MvvmCross.Droid.Views;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using XamarinMALDemo1.Interfaces;
using XamarinMALDemo1.Droid.Services;

namespace XamarinMALDemo1.Droid
{
    public class ActivityBase<T> : MvxActivity<T> where T : MvxViewModel
    {
        public ActivityBase()
        {
        }

        protected override void OnResume()
        {
            base.OnResume();
            var userDialog = (UserDialogService)Mvx.Resolve<IUserDialogService>();
            userDialog.CurrentActivity = this;
        }

        protected override void OnPause()
        {
            base.OnPause();
            var userDialog = (UserDialogService)Mvx.Resolve<IUserDialogService>();
            userDialog.CurrentActivity = null;
        }
    }
}


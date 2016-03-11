using System;
using XamarinMALDemo1.Interfaces;
using Android.App;

namespace XamarinMALDemo1.Droid.Services
{
    public class UserDialogService : IUserDialogService
    {
        public UserDialogService()
        {
        }

        public Activity CurrentActivity { private get; set; } 

        public void ShowMessage(string title, string message)
        {
            var dialog = new AlertDialog.Builder(CurrentActivity);
            dialog.SetTitle(title);
            dialog.SetMessage(message);
            dialog.SetNegativeButton("OK", (sender, args) => {  });
            dialog.SetCancelable(false);
            CurrentActivity.RunOnUiThread(() =>
            {
                dialog.Show();
            });
        }
    }
}
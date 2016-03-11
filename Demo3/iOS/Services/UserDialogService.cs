using UIKit;
using XamarinMALDemo3.Interfaces;

namespace XamarinMALDemo3.iOS.Services
{
    public class UserDialogService : IUserDialogService
    {
        public void ShowMessage(string title, string message)
        {
            using (var alert = new UIAlertView(title, message, null, null, "OK"))
            {
                alert.Show();
            }
        }
    }
}
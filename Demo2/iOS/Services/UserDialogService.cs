using UIKit;
using XamarinMALDemo2.Interfaces;

namespace XamarinMALDemo2.iOS.Services
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
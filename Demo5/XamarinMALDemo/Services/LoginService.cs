using XamarinMALDemo.Interfaces;

namespace XamarinMALDemo.Services
{
    public class LoginService : ILoginService
    {
        public bool ValidLogin(string userId, string password)
        {
            return userId.ToUpper() == "TEST" && password == "password";
        }
    }
}


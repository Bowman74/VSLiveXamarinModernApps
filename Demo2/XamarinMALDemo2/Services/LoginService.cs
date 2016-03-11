using XamarinMALDemo2.Interfaces;

namespace XamarinMALDemo2.Services
{
    public class LoginService : ILoginService
    {
        public bool ValidLogin(string userId, string password)
        {
            return userId.ToUpper() == "TEST" && password == "password";
        }
    }
}


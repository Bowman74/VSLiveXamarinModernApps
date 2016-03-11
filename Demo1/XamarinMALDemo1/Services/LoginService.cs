using System;
using XamarinMALDemo1.Interfaces;

namespace XamarinMALDemo1.Services
{
    public class LoginService : ILoginService
    {
        public bool ValidLogin(string userId, string password)
        {
            return userId.ToUpper() == "TEST" && password == "password";
        }
    }
}


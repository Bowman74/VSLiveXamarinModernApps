﻿using XamarinMALDemo3.Interfaces;

namespace XamarinMALDemo3.Services
{
    public class LoginService : ILoginService
    {
        public bool ValidLogin(string userId, string password)
        {
            return userId.ToUpper() == "TEST" && password == "password";
        }
    }
}


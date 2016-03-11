using System;

namespace XamarinMALDemo3.Interfaces
{
    public interface ILoginService
    {
        bool ValidLogin(string userId, string password);
    }
}
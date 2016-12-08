using System;

namespace XamarinMALDemo.Interfaces
{
    public interface ILoginService
    {
        bool ValidLogin(string userId, string password);
    }
}
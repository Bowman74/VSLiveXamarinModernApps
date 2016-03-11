using System;

namespace XamarinMALDemo2.Interfaces
{
    public interface ILoginService
    {
        bool ValidLogin(string userId, string password);
    }
}
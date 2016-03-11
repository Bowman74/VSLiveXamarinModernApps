using System;

namespace XamarinMALDemo1.Interfaces
{
    public interface ILoginService
    {
        bool ValidLogin(string userId, string password);
    }
}
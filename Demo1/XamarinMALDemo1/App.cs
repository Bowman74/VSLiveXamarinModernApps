using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using XamarinMALDemo1.ViewModels;
using XamarinMALDemo1.Interfaces;
using XamarinMALDemo1.Services;

namespace XamarinMALDemo1
{
    public class App : MvxApplication
    {
        public App()
        {
        }

        public override void Initialize()
        {
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<LoginViewModel>());
            Mvx.RegisterType<ILoginService, LoginService>();
            Mvx.RegisterType<IPollService, PollService>();
            RegisterAppStart<LoginViewModel>();
        }
    }
}
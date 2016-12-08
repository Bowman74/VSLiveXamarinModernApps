using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using XamarinMALDemo.ViewModels;
using XamarinMALDemo.Interfaces;
using XamarinMALDemo.Services;

namespace XamarinMALDemo
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<LoginViewModel>());
            Mvx.RegisterType<ILoginService, LoginService>();
            Mvx.RegisterType<IPollService, PollService>();
            RegisterAppStart<LoginViewModel>();
        }
    }
}
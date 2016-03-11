using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using XamarinMALDemo3.ViewModels;
using XamarinMALDemo3.Interfaces;
using XamarinMALDemo3.Services;

namespace XamarinMALDemo3
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
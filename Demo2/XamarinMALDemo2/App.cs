using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;
using XamarinMALDemo2.ViewModels;
using XamarinMALDemo2.Interfaces;
using XamarinMALDemo2.Services;

namespace XamarinMALDemo2
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
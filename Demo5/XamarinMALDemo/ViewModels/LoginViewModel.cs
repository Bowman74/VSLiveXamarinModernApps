using System.Windows.Input;
using XamarinMALDemo.Interfaces;
using MvvmCross.Core.ViewModels;
using XamarinMALDemo.PresentaitonHints;

namespace XamarinMALDemo.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private ILoginService _LoginService;

        public LoginViewModel(IUserDialogService userDialogService, INetworkService networkService, ILoginService loginService)
            : base(userDialogService, networkService)
        {
            _LoginService = loginService;
        }

        private string _userId = string.Empty;
        public string UserId
        {
            get { return _userId; }
            set
            {
                _userId = value;
                RaisePropertyChanged(() => UserId);
            }
        }

        private string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                RaisePropertyChanged(() => Password);
            }
        }

        private ICommand _loginCommand;
        public ICommand LoginCommand
        {
            get
            {
                return _loginCommand ?? (_loginCommand =
                    new MvxCommand(() => { Login(); } ));
            }
        }

        public bool Login()
        {
            if (!NetworkService.HasNetworkConnection())
            {
                UserDialogService.ShowMessage("Network Error", "There is currently no network available to login.");
            }

            // Do some login action, just simulate for demo
            if (_LoginService.ValidLogin(_userId, _password))
            {
                ShowViewModel<MainViewModel>();
                ChangePresentation(new ClearBackstackHint());
                return true;
            }
            UserDialogService.ShowMessage("Invalid Login", "The user name or password supplied was not valid to login.");
            return false;
        }
    }
}
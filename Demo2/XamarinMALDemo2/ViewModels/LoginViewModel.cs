using System.Windows.Input;
using XamarinMALDemo2.Interfaces;
using MvvmCross.Core.ViewModels;
using XamarinMALDemo2.PresentaitonHints;

namespace XamarinMALDemo2.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private ILoginService _LoginService;

        public LoginViewModel(IUserDialogService userDialogService, INetworkService networkService, ILoginService loginService)
            : base(userDialogService, networkService)
        {
            _LoginService = loginService;
        }

        private string _UserId = string.Empty;
        public string UserId
        {
            get { return _UserId; }
            set
            {
                _UserId = value;
                RaisePropertyChanged(() => UserId);
            }
        }

        private string _Password = string.Empty;
        public string Password
        {
            get { return _Password; }
            set
            {
                _Password = value;
                RaisePropertyChanged(() => Password);
            }
        }

        private ICommand _LoginCommand;
        public ICommand LoginCommand
        {
            get
            {
                return _LoginCommand ?? (_LoginCommand =
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
            if (_LoginService.ValidLogin(_UserId, _Password))
            {
                this.ShowViewModel<MainViewModel>();
                ChangePresentation(new ClearBackstackHint());
                return true;
            }
            UserDialogService.ShowMessage("Invalid Login", "The user name or password supplied was not valid to login.");
            return false;
        }
    }
}
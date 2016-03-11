using MvvmCross.Core.ViewModels;
using XamarinMALDemo3.Interfaces;

namespace XamarinMALDemo3.ViewModels
{
    public class BaseViewModel : MvxViewModel
    {
        public BaseViewModel(IUserDialogService userDialogService, INetworkService networkService)
        {
            UserDialogService = userDialogService;
            NetworkService = networkService;
        }

        protected IUserDialogService UserDialogService { get; private set; }
        protected INetworkService NetworkService { get; private set; }
    }
}
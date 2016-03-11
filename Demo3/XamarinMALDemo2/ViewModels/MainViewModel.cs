using System.Collections.Generic;
using System.Windows.Input;
using MvvmCross.Core.ViewModels;
using XamarinMALDemo3.Interfaces;

namespace XamarinMALDemo3.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private IPollService _pollService;
        private IList<IPoll> _polls;

        public MainViewModel(IPollService pollService, IUserDialogService userDialogService, INetworkService networkService) : base(userDialogService, networkService)
        {
            _pollService = pollService;
        }

        public override async void Start()
        {
            base.Start();
            Polls = await _pollService.GetPollsAsync();
        }

        public IList<IPoll> Polls
        {
            get { return _polls; }
            set
            {
                _polls = value;
                RaisePropertyChanged(() => Polls);
            }
        }

        private MvxCommand<IPoll> _incrementPollCommand;
        public ICommand IncrementPollCommand
        {
            get
            {
                _incrementPollCommand = _incrementPollCommand ?? new MvxCommand<IPoll>(p => { p.NumberResponses++; });
                return _incrementPollCommand;
            }
        }
    }
}
using MvvmCross.Core.ViewModels;
using XamarinMALDemo2.Interfaces;

namespace XamarinMALDemo2.Models
{
    public class Poll : MvxNotifyPropertyChanged, IPoll
    {
        private string _pollDescription;
        public string PollDescription
        { get { return _pollDescription;  }
            set
            {
                _pollDescription = value;
                RaisePropertyChanged(() => PollDescription);
            }
        }

        private string _pollQuestion;
        public string PollQuestion
        {
            get { return _pollQuestion; }
            set
            {
                _pollQuestion = value;
                RaisePropertyChanged(() => PollQuestion);
            }
        }

        private int _numberResponses;
        public int NumberResponses
        {
            get { return _numberResponses; }
            set
            {
                _numberResponses = value;
                RaisePropertyChanged(() => NumberResponses);
            }
        }
    }
}
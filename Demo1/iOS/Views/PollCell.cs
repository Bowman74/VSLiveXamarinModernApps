using Foundation;
using System;
using UIKit;
using MvvmCross.Binding.iOS.Views;

namespace XamarinMALDemo1.iOS.Views
{
    public partial class PollCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString("PollCellView");
        public static readonly string bindingText = "PollQuestion PollQuestion; PollResponses NumberResponses, Converter=Number";

        public PollCell (IntPtr handle) : base (bindingText, handle)
        {
        }

        public string PollQuestion
        {
            get { return lblPollQuestion.Text; }
            set { lblPollQuestion.Text = value; }
        }

        public string PollResponses
        {
            get { return lblPollResponses.Text; }
            set { lblPollResponses.Text = value; }
        }
    }
}
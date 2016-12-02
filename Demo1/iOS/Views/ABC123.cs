using System;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.Binding.BindingContext;
using XamarinMALDemo1.Interfaces;
using UIKit;
using Foundation;

namespace XamarinMALDemo1.iOS.Views
{
    public partial class PollCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString("PollCell");

        private const string bindingText = "PollQuestionsField PollQuestion; PollResponsesField NumberResponses, Converter=Number";

        public PollCell(string bindingText, UITableViewCellStyle cellStyle, NSString cellIdentifier, UITableViewCellAccessory tableViewCellAccessory = UITableViewCellAccessory.None) 
            : base(bindingText, cellStyle, cellIdentifier, tableViewCellAccessory)
        {
        }

        public PollCell(IntPtr handle) : base(bindingText, handle)
        {
        }

        //public override void LayoutSubviews()
        //{
        //    base.LayoutSubviews();
        //    this.CreateBinding(lblPollQuestion).For(a => a.Text).To<IPoll>(vm => vm.PollQuestion).Apply();
        //    this.CreateBinding(lblPollResponses).For(a => a.Text).To<IPoll>(vm => vm.NumberResponses).WithConversion("Number").Apply();
        //}

        public string PollQuestionsField
        {
            get { return lblPollQuestion.Text; }
            set { lblPollQuestion.Text = value; }
        }

        public string PollResponsesField
        {
            get { return lblPollResponses.Text; }
            set { lblPollResponses.Text = value; }
        }
    }
}

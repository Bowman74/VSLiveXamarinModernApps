using System;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.Binding.BindingContext;
using XamarinMALDemo1.Interfaces;

namespace XamarinMALDemo1.iOS.Views
{
    public partial class PollCell : MvxTableViewCell
    {
        public PollCell(IntPtr handle) : base (handle)
		{
        }

        public override void LayoutSubviews()
        {
            base.LayoutSubviews();
            this.CreateBinding(lblPollQuestion).For(a => a.Text).To<IPoll>(vm => vm.PollQuestion).Apply();
            this.CreateBinding(lblPollResponses).For(a => a.Text).To<IPoll>(vm => vm.NumberResponses).WithConversion("Number").Apply();
        }
    }
}

using System;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.iOS.Views;
using MvvmCross.Binding.BindingContext;
using XamarinMALDemo1.ViewModels;
using XamarinMALDemo1.iOS.Adapters;

namespace XamarinMALDemo1.iOS.Views
{
    public partial class MainViewController : MvxViewController<MainViewModel>
    {
        public MainViewController(IntPtr handle)
            : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            //var source = new MvxSimpleTableViewSource(tblPolls, typeof(PollCell), "PollCell");
            var source = new PollListAdapter(tblPolls);
            this.CreateBinding(source).For(s => s.ItemsSource).To<MainViewModel>(vm => vm.Polls).Apply();
            this.CreateBinding(source).For(s => s.SelectionChangedCommand).To<MainViewModel>(vm => vm.IncrementPollCommand).Apply();
            tblPolls.Source = source;
            tblPolls.ReloadData();
        }
    }
}
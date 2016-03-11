using Foundation;
using MvvmCross.Binding.iOS.Views;
using UIKit;
using XamarinMALDemo1.iOS.Views;

namespace XamarinMALDemo1.iOS.Adapters
{
    public class PollListAdapter : MvxTableViewSource
    {
        private static readonly string _cellIdentifier = "PollCell";

        public PollListAdapter(UITableView tableView)
            : base(tableView)
        {
        }

        protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath, object item)
        {
            var cell = (PollCell)tableView.DequeueReusableCell(_cellIdentifier, indexPath);
            return cell;
        }
    }
}
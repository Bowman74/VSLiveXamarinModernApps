using Foundation;
using MvvmCross.Binding.iOS.Views;
using UIKit;
using XamarinMALDemo1.iOS.Views;

namespace XamarinMALDemo1.iOS.Adapters
{
    public class PollListAdapter : MvxSimpleTableViewSource
    {

        public PollListAdapter(UITableView tableView)
            : base(tableView, typeof(PollCell), null)
        {
        }

        protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, Foundation.NSIndexPath indexPath, object item)
        {
            var cell = (PollCell)tableView.DequeueReusableCell(PollCell.Key, indexPath);
            return cell;
        }
    }
}
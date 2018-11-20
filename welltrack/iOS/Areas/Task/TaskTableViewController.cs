using Foundation;
using System;
using UIKit;

namespace welltrak.iOS
{
    public partial class TaskTableViewController : UITableViewController, IPageController
    {

        public TaskTableViewController (IntPtr handle) : base (handle)
        {
        }

        public int Index => 0;

        public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);

			var source = (TaskTableSource)TableView.Source;
			if (source == null)
			{
				TableView.Source = new TaskTableSource();
			}
		}
    }
}
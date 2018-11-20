using Foundation;
using System;
using UIKit;

namespace welltrak.iOS
{
    public partial class AppointmentSummaryTableViewController : UITableViewController, IPageController
    {
        public AppointmentSummaryTableViewController()
        {
        }

        public AppointmentSummaryTableViewController (IntPtr handle) : base (handle)
        {
        }

		public int Index => 2;

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);

			var source = (AppointmentSummaryTableSource)TableView.Source;
			if (source == null)
			{
				TableView.Source = new AppointmentSummaryTableSource();
			}
		}
    }
}
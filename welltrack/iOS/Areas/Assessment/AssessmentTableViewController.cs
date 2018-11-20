using Foundation;
using System;
using UIKit;

namespace welltrak.iOS
{
    public partial class AssessmentTableViewController : UITableViewController, IPageController
    {
        public AssessmentTableViewController()
        {
        }


        public AssessmentTableViewController (IntPtr handle) : base (handle)
        {
        }

		public int Index => 1;

		public override void ViewWillAppear(bool animated)
		{
			base.ViewWillAppear(animated);

			var source = (AssessmentTableSource)TableView.Source;
			if (source == null)
			{
				TableView.Source = new AssessmentTableSource();
			}
		}
    }
}
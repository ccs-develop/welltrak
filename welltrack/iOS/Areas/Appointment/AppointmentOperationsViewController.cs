using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace welltrak.iOS
{
    public partial class AppointmentOperationsViewController : UIViewController
    {
        public AppointmentOperationsViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var pvController = new UIPageViewController(UIPageViewControllerTransitionStyle.Scroll, UIPageViewControllerNavigationOrientation.Horizontal);

            List<UIViewController> pages = new List<UIViewController>{
                (TaskTableViewController) this.Storyboard.InstantiateViewController("tasktablevc"),
                (AssessmentTableViewController) this.Storyboard.InstantiateViewController("assessmenttablevc"),
                (AppointmentSummaryTableViewController) this.Storyboard.InstantiateViewController("apptsummaryvc")
            };

            pvController.DataSource = new AppointmentOperationsViewControllerDataSource(pages);
            pvController.View.Frame = View.Bounds;
            pvController.SetViewControllers(new UIViewController[] { pages[0] }, UIPageViewControllerNavigationDirection.Forward, false,s=>{});
            this.NavigationController.NavigationBar.Hidden = true;
            View.AddSubview(pvController.View);
            pvController.DidMoveToParentViewController(this);
            
        }
    }


    public class AppointmentOperationsViewControllerDataSource : UIPageViewControllerDataSource, IUIPageViewControllerDelegate
    {

        List<UIViewController> pages;

        public AppointmentOperationsViewControllerDataSource(List<UIViewController> Pages)
        {
            pages = Pages;
        }

        public override UIViewController GetNextViewController(UIPageViewController pageViewController, UIViewController referenceViewController)
        {
            var currentPage = referenceViewController as IPageController;
            if(currentPage.Index != 2)
            {
                return pages[currentPage.Index + 1];
            }
            return null;
        }

        public override UIViewController GetPreviousViewController(UIPageViewController pageViewController, UIViewController referenceViewController)
        {
			var currentPage = referenceViewController as IPageController;
			if (currentPage.Index != 0)
			{
                return pages[currentPage.Index - 1];
			}
            return null;
        }
    }

}
//using System;
//using System.Collections.Generic;
//using UIKit;

//namespace welltrak.iOS
//{
//    public class AppointmentPageViewControllerDataSource: UIPageViewControllerDataSource
//    {
//		private AppointmentPageViewController _parentViewController;
//		private List<string> _pageTitles;

//		public AppointmentPageViewControllerDataSource(UIViewController parentViewController, List<string> pageTitles)
//		{
//			_parentViewController = parentViewController as AppointmentPageViewController;
//			_pageTitles = pageTitles;
//		}

//		public override UIViewController GetPreviousViewController(UIPageViewController pageViewController, UIViewController referenceViewController)
//		{
//			var vc = referenceViewController as ContentViewController;
//			var index = vc.pageIndex;
//			if (index == 0)
//			{
//				return null;
//			}
//			else
//			{
//				index--;
//				return _parentViewController.ViewControllerAtIndex(index);
//			}
//		}

//		public override UIViewController GetNextViewController(UIPageViewController pageViewController, UIViewController referenceViewController)
//		{
//			var vc = referenceViewController as ContentViewController;
//			var index = vc.pageIndex;

//			index++;
//			if (index == _pageTitles.Count)
//			{
//				return null;
//			}
//			else
//			{
//				return _parentViewController.ViewControllerAtIndex(index);
//			}
//		}

//		public override nint GetPresentationCount(UIPageViewController pageViewController)
//		{
//			return _pageTitles.Count;
//		}

//		public override nint GetPresentationIndex(UIPageViewController pageViewController)
//		{
//			return 0;
//		}
//	}
//}

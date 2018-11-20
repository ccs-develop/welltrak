using Foundation;

using System;
using UIKit;
using CoreGraphics;
using WebKit;
using System.Linq;
using System.Threading.Tasks;

namespace welltrak.iOS
{
	public partial class DisclaimerController : UIViewController
	{
		public DisclaimerController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			//Task.Run(async () => { await FeatureService.GetFeature(Features.Disclaimer); }).Wait();
			lblTitle.Frame = new CGRect((View.Bounds.Width - lblTitle.Bounds.Width) / 2, 5, lblTitle.Bounds.Width, lblTitle.Bounds.Height);
			Cancel.Frame = new CGRect(5, View.Bounds.Bottom - 35, 60, 30);
			Accept.Frame = new CGRect(View.Bounds.Right - 65, View.Bounds.Bottom - 35, 60, 30);
			//btnCancel.BackgroundColor = Colors.Red;

			var body = string.Empty;
			//var disclaimerList = UserService.Instance.DisclaimerItemDetails.SelectMany(x => x.DisplayItems).ToList();
			//foreach (var displayItem in disclaimerList)
			//{
			//	if (displayItem.ItemType == DisplayItemType.Html)
			//		body += $"<div>{displayItem.DisplayValue}</div>";
			//}

			var webView = CreateNewWebView();
			//webView.LoadHtmlString($"<html><body>{body}</body></html>", new NSUrl("https://www.hodgesmace.com"));

			View.AddSubview(webView);
		}

		private WKWebView CreateNewWebView()
		{

			var rect = new CGRect(View.Bounds.X,
								  View.Bounds.Top + 10 + lblTitle.Bounds.Height,
								  View.Bounds.Width,
								  View.Bounds.Height - 10 - lblTitle.Bounds.Height - 10 - Cancel.Bounds.Height);
			var config = new WKWebViewConfiguration()
			{

			};
			var view = new UIView(rect);
			view.Tag = 1235;
			View.AddSubview(view);
			//view.BackgroundColor = Colors.Clouds;

			var rect2 = new CGRect(rect.X + 1, rect.Y + 1, rect.Width - 2, rect.Height - 2);
			var webView = new WKWebView(rect2, config);
			webView.Tag = 122347;
			webView.AllowsBackForwardNavigationGestures = true;
			//webView.NavigationDelegate = new NowWKNavigationDelegate(false, null);
			//webView.UIDelegate = new NowWKUIDelegate();

			//var textView = new UITextView();
			return webView;

		}

		public override void ViewDidLayoutSubviews()
		{
			base.ViewDidLayoutSubviews();

			var view = View.Window?.ViewWithTag(1235);
			var webview = (WKWebView)View.Window?.ViewWithTag(122347);
			Cancel.Frame = new CGRect(5, View.Bounds.Bottom - 35, 60, 30);
			Accept.Frame = new CGRect(View.Bounds.Right - 65, View.Bounds.Bottom - 35, 60, 30);

			if (view != null && webview != null)
			{
				var rect = new CGRect(View.Bounds.X,
									  View.Bounds.Top + 10 + lblTitle.Bounds.Height,
									  View.Bounds.Width,
									  View.Bounds.Height - 10 - lblTitle.Bounds.Height - 10 - Cancel.Bounds.Height);
				view.Frame = rect;

				var rect2 = new CGRect(rect.X + 1, rect.Y + 1, rect.Width - 2, rect.Height - 2);
				webview.Frame = rect2;
			}


			View.BringSubviewToFront(Accept);
			View.BringSubviewToFront(Cancel);
		}

		partial void Accept_TouchUpInside(UIButton sender)
		{
			if (Reachability.RemoteHostStatus() == NetworkStatus.NotReachable)
			{
				var window = UIApplication.SharedApplication.KeyWindow;
				var vc = window.RootViewController;
				while (vc.PresentedViewController != null)
				{
					vc = vc.PresentedViewController;
				}

				var uiAlertController = WelltrakAlertViewController.PresentOKAlert("Network Status", "The network is not reachable at this time.", vc);
				return;
			}

			ProcessAccept();
		}

		partial void Cancel_TouchUpInside(UIButton sender)
		{
			ProcessCancel();
		}

		public async void ProcessAccept()
		{
			var confirmed = await ShowAlert("Confirmation", "By selecting OK, you agree to the terms of use outlined in this document.");

			if (confirmed)
			{
				//Ack
				SendAcknowledgement(true);
				//Segue
				PerformSegue("acceptSegue", this);
			}
		}

		public async void ProcessCancel()
		{
			var confirmed = await ShowAlert("Are you sure you want to cancel?", "You must accept the terms and conditions in order to use this application.", "Yes", "No");

			if (confirmed)
			{
				//Ack
				SendAcknowledgement(false);

				//Segue
				Logout();
			}
		}


		private void SendAcknowledgement(bool accepted)
		{
			//Send Ack
			//var ids = UserService.Instance.DisclaimerItemDetails.Where(x => x.Id != null).Select(x => x.Id.GetValueOrDefault(0)).ToArray();
			//var request = UserService.Instance.NewRequest<DisclaimerRequest>();
			//request.DisclaimerIds = ids;
			//request.UserAgreed = accepted;

			//Task.Run(async () => { await new ValuesService().PostDisclaimerResponse(request); }).Wait();

		}

		public Task<bool> ShowAlert(string title, string message, string positiveButton = "OK", string negativeButton = "Cancel")
		{
			var tcs = new TaskCompletionSource<bool>();

			var uiAlertController = WelltrakAlertViewController.PresentPositiveNegativeAlert(
				title, message, positiveButton, negativeButton, this, new WelltrakAlertViewController.AlertOKCancelDelegate((bool OK) =>
				{
					if (OK) { tcs.SetResult(true); }
					else { tcs.SetResult(false); }
				}));

			//UIApplication.SharedApplication.InvokeOnMainThread(new Action(() =>
			//{
			//  UIAlertView alert = new UIAlertView(title, message, null, NSBundle.MainBundle.LocalizedString(negativeButton, negativeButton),
			//                      NSBundle.MainBundle.LocalizedString(positiveButton, positiveButton));
			//  alert.Clicked += (sender, buttonArgs) => tcs.SetResult(buttonArgs.ButtonIndex != alert.CancelButtonIndex);
			//  alert.Show();
			//}));

			return tcs.Task;
		}

		public void Logout()
		{
			//Create an instance of our AppDelegate
			var appDelegate = UIApplication.SharedApplication.Delegate as AppDelegate;
			appDelegate.Logout(false);
		}
	}
}
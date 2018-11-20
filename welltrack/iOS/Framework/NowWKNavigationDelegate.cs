//using System;
//using Foundation;
//using UIKit;
//using WebKit;

//namespace SBMobile.iOS
//{
//    public class NowWKNavigationDelegate : WKNavigationDelegate
//    {

//        bool UseLoadingOverlay = false;
//        LoadingOverlay LoadingOverlay;
//        UIViewController Controller;

//        /// <summary>
//        /// Initializes a new instance of the <see cref="T:SBMobile.iOS.NowWKNavigationDelegate"/> class.
//        /// </summary>
//        /// <param name="useLoadingOverlay">If set to <c>true</c> use loading overlay.</param>
//        /// <param name="controller">ViewController for managing the drawing of other views.</param>
//        public NowWKNavigationDelegate(bool useLoadingOverlay, UIViewController controller)
//        {
//            if (controller != null)
//            {
//                UseLoadingOverlay = useLoadingOverlay;
//                Controller = controller;
//            }
//        }

//        public override void DecidePolicy(WKWebView webView, WKNavigationAction navigationAction, Action<WKNavigationActionPolicy> decisionHandler)
//        {
//            if (Reachability.RemoteHostStatus() == NetworkStatus.NotReachable)
//            {
//                var window = UIApplication.SharedApplication.KeyWindow;
//                var vc = window.RootViewController;
//                while (vc.PresentedViewController != null)
//                {
//                    vc = vc.PresentedViewController;
//                }

//                var uiAlertController = NowAlertViewController.PresentOKAlert("Network Status", "The network is not reachable at this time.", vc);
//                HideLoadingOverlay();
//                return;
//            }

//            if (navigationAction.NavigationType == WKNavigationType.Reload
//                || navigationAction.NavigationType == WKNavigationType.FormSubmitted
//                || navigationAction.NavigationType == WKNavigationType.BackForward
//                || navigationAction.NavigationType == WKNavigationType.FormResubmitted)
//            {
//				decisionHandler(WKNavigationActionPolicy.Allow);
//			}

//			if (navigationAction.NavigationType == WKNavigationType.LinkActivated)
//			{
				
//				if (navigationAction.Request.Url.ToString().ToLower()[4] != 's')
//				{
//					UIApplication.SharedApplication.OpenUrl(navigationAction.Request.Url);
//					decisionHandler(WKNavigationActionPolicy.Cancel);
//					HideLoadingOverlay();
//					return;
//				}
//                decisionHandler(WKNavigationActionPolicy.Allow);
//			}


//			if (navigationAction.NavigationType == WKNavigationType.Other)
//			{
//				if (navigationAction.Request.Url.ToString().ToLower()[4] != 's' && navigationAction.Request.Url.ToString() != "about:blank")
//				{
//					UIApplication.SharedApplication.OpenUrl(navigationAction.Request.Url);
//					decisionHandler(WKNavigationActionPolicy.Cancel);
//					HideLoadingOverlay();
//					return;
//				}
//				decisionHandler(WKNavigationActionPolicy.Allow);
//			}
//		} 

//		public override void DidCommitNavigation(WKWebView webView, WKNavigation navigation)
//		{
//			if (UseLoadingOverlay)
//			{ 
//                HideLoadingOverlay();
//			}
//		}


//		public override void DidStartProvisionalNavigation(WKWebView webView, WKNavigation navigation)
//		{
//			if (UseLoadingOverlay)
//			{ 
//                ShowLoadingOverlay();
//			}
//		}

//		#region Unused overrides
//		//public override void DidFinishNavigation(WKWebView webView, WKNavigation navigation)
//		//{	
//		//}

//		//public override void ContentProcessDidTerminate(WKWebView webView)
//		//{
//		//}

//		//public override void DecidePolicy(WKWebView webView, WKNavigationResponse navigationResponse, Action<WKNavigationResponsePolicy> decisionHandler)
//		//{	
//		//}

//		//public override void DidFailNavigation(WKWebView webView, WKNavigation navigation, NSError error)
//		//{
//		//}

//		//public override void DidFailProvisionalNavigation(WKWebView webView, WKNavigation navigation, NSError error)
//		//{
//		//}

//		//public override void DidReceiveAuthenticationChallenge(WKWebView webView, NSUrlAuthenticationChallenge challenge, Action<NSUrlSessionAuthChallengeDisposition, NSUrlCredential> completionHandler)
//		//{
//		//}

//		//public override void DidReceiveServerRedirectForProvisionalNavigation(WKWebView webView, WKNavigation navigation)
//		//{
//		//}
//		#endregion

//		/// <summary>
//		/// Loading Screen Section
//		/// </summary>

//		internal void ShowLoadingOverlay()
//		{
//			if (Controller != null)
//			{
//				LoadingOverlay = (LoadingOverlay)Controller.View.ViewWithTag(8273497);

//				if (LoadingOverlay == null)
//				{
//					var bounds = UIScreen.MainScreen.Bounds;
//					LoadingOverlay = new LoadingOverlay(bounds, 8273497);
//					Controller.View.Add(LoadingOverlay);
//				}
//			}

//		}

//		internal void HideLoadingOverlay()
//		{
//			if (LoadingOverlay != null)
//			{
//				LoadingOverlay.Hide();
//			}
//		}

//	}
//}

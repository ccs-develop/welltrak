//using System;
//using Foundation;
//using UIKit;
//using WebKit;

//namespace SBMobile.iOS
//{
//	public class NowWKUIDelegate : WKUIDelegate 
//	{

//        public override WKWebView CreateWebView(WKWebView webView, WKWebViewConfiguration configuration, WKNavigationAction navigationAction, WKWindowFeatures windowFeatures)
//        {
//            if (navigationAction.TargetFrame == null || !navigationAction.TargetFrame.MainFrame)
//            {
//                webView.LoadRequest(navigationAction.Request);
//            }

//            return null;
//        }

//	}
//}

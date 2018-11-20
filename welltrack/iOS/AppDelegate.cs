using Foundation;
using UIKit;
using HockeyApp.iOS;
using System;

namespace welltrak.iOS
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
	[Register("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations

		public override UIWindow Window
		{
			get;
			set;
		}

		public UIStoryboard MainStoryboard
		{
			get { return UIStoryboard.FromName("Main", NSBundle.MainBundle); }
		}

		public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
		{
			// Override point for customization after application launch.
			// If not required for your application you can safely delete this method
			var manager = BITHockeyManager.SharedHockeyManager;
			manager.Configure("$6360909a7a434bd6922c70d5ce65b1f9");
			manager.StartManager();
			//manager.Authenticator.AuthenticateInstallation();

			return true;
		}

		public override void OnResignActivation(UIApplication application)
		{
			// Invoked when the application is about to move from active to inactive state.
			// This can occur for certain types of temporary interruptions (such as an incoming phone call or SMS message) 
			// or when the user quits the application and it begins the transition to the background state.
			// Games should use this method to pause the game.
		}

		public override void DidEnterBackground(UIApplication application)
		{
			// Use this method to release shared resources, save user data, invalidate timers and store the application state.
			// If your application supports background exection this method is called instead of WillTerminate when the user quits.
		}

		public override void WillEnterForeground(UIApplication application)
		{
			// Called as part of the transiton from background to active state.
			// Here you can undo many of the changes made on entering the background.
		}

		public override void OnActivated(UIApplication application)
		{
			// Restart any tasks that were paused (or not yet started) while the application was inactive. 
			// If the application was previously in the background, optionally refresh the user interface.
		}

		public override void WillTerminate(UIApplication application)
		{
			// Called when the application is about to terminate. Save data, if needed. See also DidEnterBackground.
		}

		internal async void Logout(bool fromTimeout)
		{
			//get the token from the UserService
			//var response = await ApiLogout(UserService.Instance.GetAccessToken());

			//then call the logout on UserService
			//UserService.Instance.Logout();

			//Get an instance of our Login Page View Controller
			var loginPageViewController = this.GetViewController(MainStoryboard, "BaseNavController") as UINavigationController;

			//Set the Login Page as our RootViewController
			this.SetRootViewController(loginPageViewController, true);
			//if (fromTimeout)
			//{
			//	loginPageViewController.ShowTimeoutMessage();
			//}
		}
		public UIViewController GetViewController(UIStoryboard storyboard, string viewControllerName)
		{
			return storyboard.InstantiateViewController(viewControllerName);
		}

		//Sets the RootViewController of the Apps main window with an option for animation.
		public void SetRootViewController(UIViewController rootViewController, bool animate)
		{
			if (animate)
			{
				var transitionType = UIViewAnimationOptions.TransitionFlipFromRight;

				Window.RootViewController = rootViewController;
				UIView.Transition(Window, 0.5, transitionType,
								  () => Window.RootViewController = rootViewController,
								  null);
			}
			else
			{
				Window.RootViewController = rootViewController;
			}
		}

	}
}


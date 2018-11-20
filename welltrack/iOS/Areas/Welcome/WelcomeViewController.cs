using Foundation;
using System;
using UIKit;

namespace welltrak.iOS
{
    public partial class WelcomeViewController : UIViewController
    {
        public WelcomeViewController (IntPtr handle) : base (handle)
        {
			
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        public override void ViewWillLayoutSubviews()
        {
            base.ViewWillLayoutSubviews();
			NavigationItem.Title = "Login";
            if(NavigationController != null)
            {
                NavigationController.SetNavigationBarHidden(true, true);             
            }
			
        }

        partial void BtnLogin_TouchUpInside(UIButton sender)
        {
            if(WelltrakAppService.Instance.HasAcceptedTermsAndConditions)
            {
                this.PerformSegue("LoginSegue", this);
            }
            else
            {
                this.PerformSegue("DisclaimerControllerSegue",this);
            }

        }

        partial void BtnDemoSettings_TouchUpInside(UIButton sender)
        {
            this.PerformSegue("DemoSettingsSegue", this);
        }
    }
}
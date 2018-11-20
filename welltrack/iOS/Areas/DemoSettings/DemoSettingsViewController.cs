using Foundation;
using System;
using UIKit;
using welltrak;

namespace welltrak.iOS
{
    public partial class DemoSettingsViewController : UIViewController
    {
        public DemoSettingsViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            this.NavigationItem.Title = "Settings";
            NavigationController.SetNavigationBarHidden(false,true);
            txtTargetAddress.Text = (string.IsNullOrEmpty(WelltrakAppService.Instance.CurrentTargetAddress)) ? Constants.TargetAddress : WelltrakAppService.Instance.CurrentTargetAddress;
        }

        partial void BtnUpdate_TouchUpInside(UIButton sender)
        {
            if(!string.IsNullOrEmpty(txtTargetAddress.Text))
            {
                UpdateAddress(txtTargetAddress.Text);
            }

        }

        public void UpdateAddress(string addressString)
        {
            WelltrakAppService.Instance.CurrentTargetAddress = addressString;
		}

    }
}
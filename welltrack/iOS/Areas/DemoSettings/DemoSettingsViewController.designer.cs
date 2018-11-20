// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace welltrak.iOS
{
    [Register ("DemoSettingsViewController")]
    partial class DemoSettingsViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnUpdate { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblTargetAddress { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtTargetAddress { get; set; }

        [Action ("BtnUpdate_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnUpdate_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnUpdate != null) {
                btnUpdate.Dispose ();
                btnUpdate = null;
            }

            if (lblTargetAddress != null) {
                lblTargetAddress.Dispose ();
                lblTargetAddress = null;
            }

            if (txtTargetAddress != null) {
                txtTargetAddress.Dispose ();
                txtTargetAddress = null;
            }
        }
    }
}
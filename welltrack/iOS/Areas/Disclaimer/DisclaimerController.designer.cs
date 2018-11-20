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
    [Register ("DisclaimerController")]
    partial class DisclaimerController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Accept { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Cancel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblTargetAddress { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblTitle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtDisclaimerText { get; set; }

        [Action ("Accept_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Accept_TouchUpInside (UIKit.UIButton sender);

        [Action ("Cancel_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Cancel_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (Accept != null) {
                Accept.Dispose ();
                Accept = null;
            }

            if (Cancel != null) {
                Cancel.Dispose ();
                Cancel = null;
            }

            if (lblTargetAddress != null) {
                lblTargetAddress.Dispose ();
                lblTargetAddress = null;
            }

            if (lblTitle != null) {
                lblTitle.Dispose ();
                lblTitle = null;
            }

            if (txtDisclaimerText != null) {
                txtDisclaimerText.Dispose ();
                txtDisclaimerText = null;
            }
        }
    }
}
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
    [Register ("RegisterViewController")]
    partial class RegisterViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblErrors { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtConfirmEmail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtEmail { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtFirstName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtLastName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtPassword { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtRepeatPassword { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField txtUsername { get; set; }

        [Action ("ConfirmEmailDidEndEdit:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ConfirmEmailDidEndEdit (UIKit.UITextField sender);

        [Action ("DesiredUsernameDidEndEdit:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void DesiredUsernameDidEndEdit (UIKit.UITextField sender);

        [Action ("FirstEmailDidEndEdit:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void FirstEmailDidEndEdit (UIKit.UITextField sender);

        [Action ("FirstPasswordDidEndEdit:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void FirstPasswordDidEndEdit (UIKit.UITextField sender);

        [Action ("RepeatPasswordDidEndEdit:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void RepeatPasswordDidEndEdit (UIKit.UITextField sender);

        [Action ("UIButton337_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton337_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (lblErrors != null) {
                lblErrors.Dispose ();
                lblErrors = null;
            }

            if (txtConfirmEmail != null) {
                txtConfirmEmail.Dispose ();
                txtConfirmEmail = null;
            }

            if (txtEmail != null) {
                txtEmail.Dispose ();
                txtEmail = null;
            }

            if (txtFirstName != null) {
                txtFirstName.Dispose ();
                txtFirstName = null;
            }

            if (txtLastName != null) {
                txtLastName.Dispose ();
                txtLastName = null;
            }

            if (txtPassword != null) {
                txtPassword.Dispose ();
                txtPassword = null;
            }

            if (txtRepeatPassword != null) {
                txtRepeatPassword.Dispose ();
                txtRepeatPassword = null;
            }

            if (txtUsername != null) {
                txtUsername.Dispose ();
                txtUsername = null;
            }
        }
    }
}
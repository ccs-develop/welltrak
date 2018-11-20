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
    [Register ("WelcomeViewController")]
    partial class WelcomeViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnDemoSettings { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnLogin { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnRegister { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblVersion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch swRememberMe { get; set; }

        [Action ("BtnDemoSettings_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnDemoSettings_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnLogin_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnLogin_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnDemoSettings != null) {
                btnDemoSettings.Dispose ();
                btnDemoSettings = null;
            }

            if (btnLogin != null) {
                btnLogin.Dispose ();
                btnLogin = null;
            }

            if (btnRegister != null) {
                btnRegister.Dispose ();
                btnRegister = null;
            }

            if (lblVersion != null) {
                lblVersion.Dispose ();
                lblVersion = null;
            }

            if (swRememberMe != null) {
                swRememberMe.Dispose ();
                swRememberMe = null;
            }
        }
    }
}
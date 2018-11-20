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
    [Register ("AppointmentCell")]
    partial class AppointmentCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblAddress { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblApptDateTime { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblClientName { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lblAddress != null) {
                lblAddress.Dispose ();
                lblAddress = null;
            }

            if (lblApptDateTime != null) {
                lblApptDateTime.Dispose ();
                lblApptDateTime = null;
            }

            if (lblClientName != null) {
                lblClientName.Dispose ();
                lblClientName = null;
            }
        }
    }
}
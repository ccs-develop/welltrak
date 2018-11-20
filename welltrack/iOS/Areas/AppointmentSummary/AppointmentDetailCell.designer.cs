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
    [Register ("AppointmentDetailCell")]
    partial class AppointmentDetailCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblClientName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblDateTime { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblSummaryLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lblClientName != null) {
                lblClientName.Dispose ();
                lblClientName = null;
            }

            if (lblDateTime != null) {
                lblDateTime.Dispose ();
                lblDateTime = null;
            }

            if (lblSummaryLabel != null) {
                lblSummaryLabel.Dispose ();
                lblSummaryLabel = null;
            }
        }
    }
}
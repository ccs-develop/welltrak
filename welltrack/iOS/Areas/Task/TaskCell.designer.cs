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
    [Register ("TaskCell")]
    partial class TaskCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnCamera { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblTaskName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch swTaskComplete { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextView tvComments { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (btnCamera != null) {
                btnCamera.Dispose ();
                btnCamera = null;
            }

            if (lblTaskName != null) {
                lblTaskName.Dispose ();
                lblTaskName = null;
            }

            if (swTaskComplete != null) {
                swTaskComplete.Dispose ();
                swTaskComplete = null;
            }

            if (tvComments != null) {
                tvComments.Dispose ();
                tvComments = null;
            }
        }
    }
}
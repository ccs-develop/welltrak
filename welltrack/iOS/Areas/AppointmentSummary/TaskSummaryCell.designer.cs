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
    [Register ("TaskSummaryCell")]
    partial class TaskSummaryCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCheckbox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCommentPhotoIndicator { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblTaskName { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lblCheckbox != null) {
                lblCheckbox.Dispose ();
                lblCheckbox = null;
            }

            if (lblCommentPhotoIndicator != null) {
                lblCommentPhotoIndicator.Dispose ();
                lblCommentPhotoIndicator = null;
            }

            if (lblTaskName != null) {
                lblTaskName.Dispose ();
                lblTaskName = null;
            }
        }
    }
}
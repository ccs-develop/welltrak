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
    [Register ("DecimalCell")]
    partial class DecimalCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCount { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblQuestion { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lblCount != null) {
                lblCount.Dispose ();
                lblCount = null;
            }

            if (lblQuestion != null) {
                lblQuestion.Dispose ();
                lblQuestion = null;
            }
        }
    }
}
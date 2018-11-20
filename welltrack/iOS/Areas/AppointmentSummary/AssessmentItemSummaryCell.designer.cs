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
    [Register ("AssessmentItemSummaryCell")]
    partial class AssessmentItemSummaryCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblAssessmentQuestion { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblCheckbox { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel lblStatus { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (lblAssessmentQuestion != null) {
                lblAssessmentQuestion.Dispose ();
                lblAssessmentQuestion = null;
            }

            if (lblCheckbox != null) {
                lblCheckbox.Dispose ();
                lblCheckbox = null;
            }

            if (lblStatus != null) {
                lblStatus.Dispose ();
                lblStatus = null;
            }
        }
    }
}
using Foundation;
using System;
using UIKit;

namespace welltrak.iOS
{
    public partial class AssessmentItemSummaryCell : UITableViewCell
    {
        public AssessmentItemSummaryCell (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateData(AssessmentItem assessmentItem)
        {
            //Up Right Down 
            lblStatus.Text = "";

			if (assessmentItem.AssessmentItemAnswer != null)
			{
				lblCheckbox.Text = "";
				lblCheckbox.TextColor = UIColor.FromRGB(61, 170, 114);

                switch(assessmentItem.AssessmentItemAnswer.AnswerValue)
                {
                    case AnswerEnum.Positive:
                        {
							lblStatus.Text = "";
							lblStatus.TextColor = UIColor.FromRGB(61, 170, 114);
                            return;
                        }
                    case AnswerEnum.Neutral:
                        {
							lblStatus.Text = "";
							lblStatus.TextColor = UIColor.FromRGB(61, 170, 114);
							return;
                        }
                    case AnswerEnum.Negative:
                        {
							lblStatus.Text = "";
                            lblStatus.TextColor = UIColor.LightGray;
							return;
                        }

                }
			}
			else
			{
				lblCheckbox.Text = "";
				lblCheckbox.TextColor = UIColor.LightGray;
			}
            lblAssessmentQuestion.Text = assessmentItem.AssessmentItemQuestion;

		}
    }
}
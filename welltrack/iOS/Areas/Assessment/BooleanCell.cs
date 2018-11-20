using Foundation;
using System;
using UIKit;
using System.Linq;

namespace welltrak.iOS
{
    public partial class BooleanCell : UITableViewCell
    {
        public BooleanCell (IntPtr handle) : base (handle)
        {
        }

		internal void UpdateData(AssessmentItem item)
		{
			lblQuestion.Text = item.AssessmentItemQuestion;
			lblDescription.Text = item.AssessmentItemDescription;

			answerControl.SetTitle(item.AnswerLabels[0].Item1, 0);
			answerControl.SetTitle(item.AnswerLabels[1].Item1, 1);

			if (item.AssessmentItemAnswer != null)
			{
				var answerIndexToSelect = item.AnswerLabels.SingleOrDefault(x => x.Item2 == item.AssessmentItemAnswer.AnswerValue);

				answerControl.SelectedSegment = answerIndexToSelect.Item3;
			}

			answerControl.ValueChanged += (sender, e) => {

				AnswerEnum ae = item.AnswerLabels[(int)answerControl.SelectedSegment].Item2;

				var answer = new AssessmentItemAnswer()
				{
					AnswerText = answerControl.TitleAt(answerControl.SelectedSegment),
					AnswerValue = ae
				};

				item.AssessmentItemAnswer = answer;
			};

		}
    }
}
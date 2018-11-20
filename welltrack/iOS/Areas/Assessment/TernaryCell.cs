using Foundation;
using System;
using System.Linq;
using UIKit;

namespace welltrak.iOS
{
    public partial class TernaryCell : UITableViewCell
    {
        public TernaryCell (IntPtr handle) : base (handle)
        {
        }

        AssessmentItem Item;

        internal void UpdateData(AssessmentItem item)
        {
            lblQuestion.Text = item.AssessmentItemQuestion;
            lblDescription.Text = item.AssessmentItemDescription;

            answerControl.SetTitle(item.AnswerLabels[0].Item1, 0);
            answerControl.SetTitle(item.AnswerLabels[1].Item1, 1);
            answerControl.SetTitle(item.AnswerLabels[2].Item1, 2);

            if(item.AssessmentItemAnswer != null)
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
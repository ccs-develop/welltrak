using Foundation;
using System;
using UIKit;

namespace welltrak.iOS
{
    public partial class TaskCell : UITableViewCell
    {
        public TaskCell (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateData(Action action)
        {
            lblTaskName.Text = action.AppointmentAction.ActionName;
            tvComments.Text = action.Comment;
            swTaskComplete.On = action.Status >= ActionStatus.MarkedComplete;

            swTaskComplete.TouchUpInside += (sender, e) => {

                if(swTaskComplete.On)
                {
                    action.Status = ActionStatus.MarkedComplete;
                }
                else
                {
                    action.Status = ActionStatus.ToDo;
                }

            };
        }

    }
}
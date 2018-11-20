using Foundation;
using System;
using UIKit;

namespace welltrak.iOS
{
    public partial class TaskSummaryCell : UITableViewCell
    {
        public TaskSummaryCell (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateData(Action task)
        {
            lblCommentPhotoIndicator.Text = "";
            if(task.Status == ActionStatus.MarkedComplete)
            {
                lblCheckbox.Text = "";
                lblCheckbox.TextColor = UIColor.FromRGB(61, 170, 114);
            }
            else
            {
				lblCheckbox.Text = "";
				lblCheckbox.TextColor = UIColor.LightGray;
            }

            lblTaskName.Text = task.AppointmentAction.ActionName;

            //picture and comments  

            var iconstring = "";
            if(task.Photos != null && task.Photos.Count > 0)
            {
                iconstring += "";
            }
            if(task.Comment != null && task.Comment.Length > 0)
            {
                if(iconstring.Length > 0)
                {
                    iconstring += " ";
                }
                else
                {
                    iconstring += "";
                }
            }
            lblCommentPhotoIndicator.Text = iconstring;
		}
    }
}
using Foundation;
using System;
using UIKit;
using System.Globalization;

namespace welltrak.iOS
{
    public partial class AppointmentDetailCell : UITableViewCell
    {
        public AppointmentDetailCell (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateData()
        {
            var appointment = WelltrakAppService.Instance.CurrentAppointment;

            if(!string.IsNullOrEmpty(appointment.Client.Title))
            {
                lblClientName.Text = $"{appointment.Client.Title} {appointment.Client.FirstName} {appointment.Client.LastName}";
			}
            else
            {
                lblClientName.Text = $"{appointment.Client.FirstName} {appointment.Client.LastName}";
            }

            if(appointment.Time != DateTime.MinValue)
            {
                lblDateTime.Text = appointment.Time.ToString("MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture);

			}

              
        }
    }
}


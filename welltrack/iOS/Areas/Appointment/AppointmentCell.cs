using Foundation;
using System;
using UIKit;
using System.Globalization;

namespace welltrak.iOS
{
    public partial class AppointmentCell : UITableViewCell
    {
        public AppointmentCell (IntPtr handle) : base (handle)
        {
        }

        internal void UpdateData(Appointment appointment)
        {
            var client = appointment.Client;

            if(!string.IsNullOrEmpty(client.Title))
            {
                lblClientName.Text = $"{appointment.Client.Title} {appointment.Client.FirstName} {appointment.Client.LastName}";
            }
            else
            {
                lblClientName.Text = $"{appointment.Client.FirstName} {appointment.Client.LastName}";
            }

            if(appointment.Time != DateTime.MinValue)
            {
                lblApptDateTime.Text = appointment.Time.ToString("MM/dd/yyyy HH:mm", CultureInfo.InvariantCulture);
            }
            else
            {
                lblApptDateTime.Text = "Date and Time is not available";
            }

            lblAddress.Text = appointment.Client.Address.GetAddressBlockString();

        }
    }
}
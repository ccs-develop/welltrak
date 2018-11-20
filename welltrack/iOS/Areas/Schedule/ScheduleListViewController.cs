using Foundation;
using System;
using UIKit;
using System.Collections.Generic;

namespace welltrak.iOS
{
    public partial class ScheduleListViewController : UITableViewController
    {
        public ScheduleListViewController (IntPtr handle) : base (handle)
        {
            WelltrakAppService.Instance.BuildOutAppointments();
            Appointments = WelltrakAppService.Instance.Appointments;
        }

        List<Appointment> Appointments;

        public override void ViewWillAppear(bool animated)
        {
            base.ViewWillAppear(animated);

            var source = (ScheduleTableSource)TableView.Source;
            if(source == null)
            {
                TableView.Source = new ScheduleTableSource(Appointments, this);
            }
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)
        {
            base.PrepareForSegue(segue, sender);

            if(segue.Identifier == "AppointmentSelectedSegue")
            {
                WelltrakAppService.Instance.CurrentAppointment = Appointments[TableView.IndexPathForSelectedRow.Row];
            }
        }

    }
}
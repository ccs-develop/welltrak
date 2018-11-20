using System;
namespace welltrak
{
    public class AppointmentAction: Entity
    {
        public AppointmentAction()
        {
        }

        public AppointmentActionCategory Category;
        public string ActionName;
        public string Description;
        public int OldID;
    }

    public enum AppointmentActionCategory
    {
        Break,
        AgencyNotification,
        AssistClient,
        TransferAssistance,
        Communication,
        Companionship,
        Exercise,
        HealthManagement,
        Hospice,
        Housekeeping,
        Nutrition,
        PersonalCare,
        HomeSafety,
        Transportation,
        CustomerService
    }
}




           
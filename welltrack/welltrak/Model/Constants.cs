using System;
using System.Collections.Generic;

namespace welltrak
{
    public static class Constants
    {
        public static readonly string TargetAddress = "4013 Brenteresa Court, Snellville Georgia 30039";


        public static readonly List<AppointmentAction> Tasks = new List<AppointmentAction>
        {
            new AppointmentAction
            {
                OldID = 1,
                ActionName = "Hour Lunch Break",
                Description = "One Hour Lunch Break",
                ID = new Guid(),
                Category = AppointmentActionCategory.Break

            },
            new AppointmentAction
            {
                OldID = 1,
                ActionName = "15 Minute Break",
                Description = "15 Minute Break",
                ID = new Guid(),
                Category = AppointmentActionCategory.Break

            },
            new AppointmentAction
            {
                OldID = 2,
                ActionName = "45 Minute Lunch Break",
                Description = "45 Minute Lunch Break",
                ID = new Guid(),
                Category = AppointmentActionCategory.Break

            },
            new AppointmentAction
            {
                OldID = 2,
                ActionName = "10 Minute Break",
                Description = "10 Minute Break",
                ID = new Guid(),
                Category = AppointmentActionCategory.Break

            },
            new AppointmentAction
            {
                OldID = 10,
                ActionName = "Emergency",
                Description = "Emergency",
                ID = new Guid(),
                Category = AppointmentActionCategory.AgencyNotification

            },
            new AppointmentAction
            {
                OldID = 11,
                ActionName = "Employee Injury",
                Description = "Employee Injury",
                ID = new Guid(),
                Category = AppointmentActionCategory.AgencyNotification

            },
            new AppointmentAction
            {
                OldID = 12,
                ActionName = "Client Fall",
                Description = "Client Fall",
                ID = new Guid(),
                Category = AppointmentActionCategory.AgencyNotification

            },
            new AppointmentAction
            {
                OldID = 13,
                ActionName = "Non PCA Activities Exceed 20%",
                Description = "Non PCA Activities Exceed 20%",
                ID = new Guid(),
                Category = AppointmentActionCategory.AgencyNotification

            },
            new AppointmentAction
            {
                OldID = 14,
                ActionName = "Change in Client Condition",
                Description = "Change in Client Condition",
                ID = new Guid(),
                Category = AppointmentActionCategory.AgencyNotification

            },
            new AppointmentAction
            {
                OldID = 15,
                ActionName = "Change in Skin Condition",
                Description = "Change in Skin Condition",
                ID = new Guid(),
                Category = AppointmentActionCategory.AgencyNotification

            },
            new AppointmentAction
            {
                OldID = 16,
                ActionName = "Patient Care Concern",
                Description = "Patient Care Concern",
                ID = new Guid(),
                Category = AppointmentActionCategory.AgencyNotification

            },
            new AppointmentAction
            {
                OldID = 31,
                ActionName = "Assist with Ambulation (ADL)",
                Description = "Assist with Ambulation (ADL)",
                ID = new Guid(),
                Category = AppointmentActionCategory.AssistClient

            },
            new AppointmentAction
            {
                OldID = 32,
                ActionName = "Assist with Dressing (ADL)",
                Description = "Assist with Dressing (ADL)",
                ID = new Guid(),
                Category = AppointmentActionCategory.AssistClient

            },
            new AppointmentAction
            {
                OldID = 33,
                ActionName = "Assist with Nebulizer",
                Description = "Assist with Nebulizer",
                ID = new Guid(),
                Category = AppointmentActionCategory.AssistClient
            },
            new AppointmentAction
            {
                OldID = 34,
                ActionName = "Assist with Oxygen",
                Description = "Assist with Oxygen",
                ID = new Guid(),
                Category = AppointmentActionCategory.AssistClient
            },            
            new AppointmentAction
            {
                OldID = 35,
                ActionName = "Assist with Oxygen",
                Description = "Assist with Oxygen",
                ID = new Guid(),
                Category = AppointmentActionCategory.AssistClient
            },            
            new AppointmentAction
            {
                OldID = 36,
                ActionName = "Transfer Assist (ADL)",
                Description ="Transfer Assist (ADL)",
                ID = new Guid(),
                Category = AppointmentActionCategory.TransferAssistance
            },            
            new AppointmentAction
            {
                OldID = 37,
                ActionName = "Transfer Assist Hoyer Lift (ADL)",
                Description = "Transfer Assist Hoyer Lift (ADL)",
                ID = new Guid(),
                Category = AppointmentActionCategory.TransferAssistance
            },            
            new AppointmentAction
            {
                OldID = 38,
                ActionName = "Transfer Assist Slide Board (ADL)",
                Description = "Transfer Assist Slide Board (ADL)",
                ID = new Guid(),
                Category = AppointmentActionCategory.TransferAssistance
            },            
            new AppointmentAction
            {
                OldID = 39,
                ActionName = "Transfer Assist Transfer Chair (ADL)",
                Description = "Transfer Assist Transfer Chair (ADL)",
                ID = new Guid(),
                Category = AppointmentActionCategory.TransferAssistance
            },
			
            new AppointmentAction
			{
				OldID = 41,
                ActionName = "Assist with Walking (ADL)",
				Description = "Assist with Walking (ADL)",
				ID = new Guid(),
				Category = AppointmentActionCategory.AssistClient
			},  
            //new AppointmentAction
            //{
            //    OldID = 40,
            //        ActionName = "Transfer Assist Transfer Chair (ADL)",
            //    Description = "Transfer Assist Transfer Chair (ADL)",
            //    ID = new Guid(),
            //    Category = AppointmentActionCategory.TransferAssistance
            //},
        };

    };
}

 //NEED TO ADD STILL
//new Tuple<int, string>(41, "Assist with walking (ADL)"),
            //new Tuple<int, string>(42, "Communication with previous PCA at arrival"),
            //new Tuple<int, string>(43, "Communication with previous PCA at departure"),
            //new Tuple<int, string>(44, "Companionship"),
            //new Tuple<int, string>(45, "EXERCISE: active ROM"),
            //new Tuple<int, string>(46, "EXERCISE: passive ROM"),
            //new Tuple<int, string>(47, "EXERCISE: assist with home exercise plan"),
            //new Tuple<int, string>(48, "HEALTH MANAGEMENT: Measured blood sugar"),
            //new Tuple<int, string>(49, "HEALTH MANAGEMENT: Medication assistance"),
            //new Tuple<int, string>(50, "HEALTH MANAGEMENT: Medication reminder"),
            //new Tuple<int, string>(51, "HEALTH MANAGEMENT: Took blood pressure"),
            //new Tuple<int, string>(52, "HEALTH MANAGEMENT: Took vitals"),
            //new Tuple<int, string>(53, "HEALTH MANAGEMENT: Universal precautions"),
            //new Tuple<int, string>(54, "HOSPICE: Comfort measures only"),
            //new Tuple<int, string>(55, "HOSPICE: Emotional support"),
            //new Tuple<int, string>(56, "LIGHT HOUSEKEEPING: Dusting"),
            //new Tuple<int, string>(57, "LIGHT HOUSEKEEPING: Laundry/linens"),
            //new Tuple<int, string>(58, "LIGHT HOUSEKEEPING: Made bed"),
            //new Tuple<int, string>(59, "LIGHT HOUSEKEEPING: Bathroom"),
            //new Tuple<int, string>(60, "LIGHT HOUSEKEEPING: Bedroom"),
            //new Tuple<int, string>(61, "LIGHT HOUSEKEEPING: Kitchen/dining room"),
            //new Tuple<int, string>(62, "LIGHT HOUSEKEEPING: Living room"),
            //new Tuple<int, string>(63, "NUTRITION: Appetite fair"),
            //new Tuple<int, string>(64, "NUTRITION: Appetite good"),
            //new Tuple<int, string>(65, "NUTRITION: Poor"),
            //new Tuple<int, string>(66, "NUTRITION: Assist with feeding"),
            //new Tuple<int, string>(68, "NUTRITION: Bland diet"),
            //new Tuple<int, string>(69, "NUTRITION: Diabetic diet"),
            //new Tuple<int, string>(70, "NUTRITION: Low cholesterol diet"),
            //new Tuple<int, string>(71, "NUTRITION: Low fat diet"),
            //new Tuple<int, string>(72, "NUTRITION: Low sodium diet"),
            //new Tuple<int, string>(73, "NUTRITION: Mechanical soft diet"),
            //new Tuple<int, string>(74, "NUTRITION: Puree diet"),
            //new Tuple<int, string>(75, "NUTRITION: Regular diet"),
            //new Tuple<int, string>(76, "NUTRITION: Thick liquids diet"),
            //new Tuple<int, string>(77, "NUTRITION: Meal planning"),
            //new Tuple<int, string>(78, "NUTRITION: Meal preparation"),
            //new Tuple<int, string>(79, "PERSONAL CARE: Apply lotion"),
            //new Tuple<int, string>(80, "PERSONAL CARE: Assist with toileting (ADL)"),
            //new Tuple<int, string>(81, "PERSONAL CARE: Assist with commode (ADL)"),
            //new Tuple<int, string>(82, "PERSONAL CARE: Back rub"),
            //new Tuple<int, string>(83, "PERSONAL CARE: Bed bath (ADL)"),
            //new Tuple<int, string>(84, "PERSONAL CARE: Bed pan assistance (ADL)"),
            //new Tuple<int, string>(85, "PERSONAL CARE: Bowel movement, NO"),
            //new Tuple<int, string>(86, "PERSONAL CARE: Bowel movement, YES"),
            //new Tuple<int, string>(87, "PERSONAL CARE: Bowel/bladder (ADL)"),
            //new Tuple<int, string>(88, "PERSONAL CARE: Catheter assistance/care (ADL)"),
            //new Tuple<int, string>(89, "PERSONAL CARE: Change diaper/brief(ADL)"),
            //new Tuple<int, string>(90, "PERSONAL CARE: Comb hair"),
            //new Tuple<int, string>(91, "PERSONAL CARE: Condom catheter change (ADL)"),
            //new Tuple<int, string>(92, "PERSONAL CARE: Denture care"),
            //new Tuple<int, string>(93, "PERSONAL CARE: Foot care"),
            //new Tuple<int, string>(95, "PERSONAL CARE: Nail care- cleaning"),
            //new Tuple<int, string>(96, "PERSONAL CARE: Nail care- filing"),
            //new Tuple<int, string>(97, "PERSONAL CARE: Oral care"),
            //new Tuple<int, string>(100, "PERSONAL CARE: Shower assist (ADL)"),
            //new Tuple<int, string>(101, "PERSONAL CARE: Shower assist w/ chair (ADL)"),
            //new Tuple<int, string>(102, "PERSONAL CARE: Skin care"),
            //new Tuple<int, string>(103, "PERSONAL CARE: Sponge bath (ADL)"),
            //new Tuple<int, string>(104, "PERSONAL CARE: Tub bath (ADL)"),
            //new Tuple<int, string>(105, "Basic home safety"),
            //new Tuple<int, string>(106, "TRANSPORTATION: Doctor’s appointment"),
            //new Tuple<int, string>(107, "TRANSPORTATION: Errands/shopping"),
            //new Tuple<int, string>(109, "AGENCY NOTIFIED: Non well-balanced nutrition"),
            //new Tuple<int, string>(110, "AGENCY NOTIFIED: Inadequate accommodations"),
            //new Tuple<int, string>(111, "AGENCY NOTIIED: Off hour care"),
            //new Tuple<int, string>(200, "Customer Service Visit"),

//Added
//1,"1 hour lunch/ Two 15 minute breaks"),
            //new Tuple<int, string>(2, "45 minute lunch/Two 10 minute breaks"),
            //new Tuple<int, string>(10, "AGENCY NOTIFIED: Emergency"),
            //new Tuple<int, string>(11, "AGENCY NOTIFIED: Employee Injury"),
            //new Tuple<int, string>(12, "AGENCY NOTIFIED: Client Fall"),
            //new Tuple<int, string>(13, "AGENCY NOTIFIED: Non PCA activities exceed 20%"),
            //new Tuple<int, string>(14, "AGENCY NOTIFIED: Change in client condition"),
            //new Tuple<int, string>(15, "AGENCY NOTIFIED: Change in skin condition"),
            //new Tuple<int, string>(16, "AGENCY NOTIFIED: Patient care concern"),
            //new Tuple<int, string>(31, "Assist with ambulation (ADL)"),
            //new Tuple<int, string>(32, "Assist with dressing (ADL)"),
            //new Tuple<int, string>(33, "Assist with nebulizer"),
//            //new Tuple<int, string>(34, "Assist with oxygen"),
//new Tuple<int, string>(35, "TRANSFER ASSIST (ADL)"),
            //new Tuple<int, string>(36, "TRANSFER ASSIST: 2 person (ADL)"),
            //new Tuple<int, string>(37, "TRANSFER ASSIST- hoyer lift (ADL)"),
            //new Tuple<int, string>(38, "TRANSFER ASSIST- slide board (ADL)"),
            //new Tuple<int, string>(39, "TRANSFER ASSIST- Transfer chair (ADL)"),
            //new Tuple<int, string>(40, "TRANSFER ASSIST- Transfer chair (ADL)"),
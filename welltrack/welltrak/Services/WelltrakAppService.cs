using System;
using System.Collections.Generic;

namespace welltrak
{
    public class WelltrakAppService
    {
        #region Static AppService Setup
        private static WelltrakAppService instance;

        static WelltrakAppService()
        {
            instance = new WelltrakAppService();
        }

        public static WelltrakAppService Instance
        {
            get
            {
                return instance;
            }
        }
        #endregion


        public void BuildOutAppointments()
        {
            Appointments = new List<Appointment>()
            {
                new Appointment{
                    Client = new Client
                    {
                        FirstName = "Clint",
                        LastName = "Smith",
                        Address = new Address
                        {
                            StreetAddress1 = "4013 Brenteresa Court\t",
                            City="Snellville",
                            State= "GA",
                            ZipCode="30039"
                        },
                        Age = 33,
                        Title ="Mr."
                    }
                    ,
                    Time = DateTime.Today.AddHours(12),
                    ID = Guid.NewGuid()

                },
                new Appointment{
                    Client = new Client
                    {
                        FirstName = "Clint",
                        LastName = "Smith",
                        Address = new Address
                        {
                            StreetAddress1 = "576 Sigman Road",
                            City="Conyers",
                            State= "GA",
                            ZipCode="30013"
                        },
                        Age = 31,
                        Title ="Mr."
                    }
                    ,
                    Time = DateTime.Today.AddHours(12),

                },
                new Appointment{
                    Client = new Client
                    {
                        FirstName = "Brian",
                        LastName = "Jonick",
                        Address = new Address
                        {
                            StreetAddress1 = "38 Timberlost Trail NE",
                            City="Suwanee",
                            State= "GA",
                            ZipCode="30024"
                        },
                        Age = 29,
                        Title ="Mr."
                    }
                    ,
                    Time = DateTime.Today.AddHours(12),

                },
				new Appointment{
					Client = new Client
					{
						FirstName = "Brian",
						LastName = "Jonick",
						Address = new Address
						{
							StreetAddress1 = "1143 Chatham Road",
							City="Buford",
							State= "GA",
							ZipCode="30518"
						},
						Age = 29,
						Title ="Mr."
					}
					,
					Time = DateTime.Today.AddHours(12),

				},
            };
            foreach (var a in Appointments)
            {
                a.Actions = new List<Action>
                {
                    new Action
                    {
                        ID = a.ID,
                        AppointmentAction = Constants.Tasks[0],
                        Status = ActionStatus.ToDo
                    },
					new Action
					{
						ID = a.ID,
						AppointmentAction = Constants.Tasks[1],
						Status = ActionStatus.ToDo
					},              
                    new Action
					{
						ID = a.ID,
						AppointmentAction = Constants.Tasks[2],
						Status = ActionStatus.ToDo
					},                    
                    new Action
					{
						ID = a.ID,
						AppointmentAction = Constants.Tasks[3],
						Status = ActionStatus.ToDo
					},                    
                    new Action
					{
						ID = a.ID,
						AppointmentAction = Constants.Tasks[4],
						Status = ActionStatus.ToDo
					},
                };

                a.AssessmentItems = new List<AssessmentItem>{
                    new AssessmentItem
                    {
                        AssessmentItemQuestion ="Did the client miss any prescribed medications?",
                        AssessmentItemDescription = "Taking medications as prescribed is important for the client. If the client chooses not to take medications, assess why and encourage the client to consult a doctor.",
                        AssessmentItemResponseType = AssessmentItemResponseType.Boolean,
                        AnswerLabels = new List<Tuple<string, AnswerEnum,int>> 
                        {
                            new Tuple<string, AnswerEnum,int>("No",AnswerEnum.Positive,0),
							new Tuple<string, AnswerEnum,int>("Yes",AnswerEnum.Negative,1),
                        },
                    },
					new AssessmentItem
                    {
						AssessmentItemQuestion ="Did the client have any falls or near-falls in the last day?",
						AssessmentItemDescription = "Falls or near-falls indicate balance problems and are a significant risk for hospital readmissions.",
						AssessmentItemResponseType = AssessmentItemResponseType.Boolean,
						AnswerLabels = new List<Tuple<string, AnswerEnum,int>>
						{
							new Tuple<string, AnswerEnum,int>("No",AnswerEnum.Positive,0),
							new Tuple<string, AnswerEnum,int>("Yes",AnswerEnum.Negative,1),
						},
					},
					new AssessmentItem
                    {
                        AssessmentItemQuestion ="Weight compared to yesterday",
                        AssessmentItemDescription = "Increasing weight may be a sign of looming trouble. A gain of two (2) pounds could be the start of something more serious.",
						AssessmentItemResponseType = AssessmentItemResponseType.Ternary,
						AnswerLabels = new List<Tuple<string, AnswerEnum,int>>
						{
							new Tuple<string, AnswerEnum,int>("Decrease",AnswerEnum.Positive,0),
                            new Tuple<string, AnswerEnum,int>("Same",AnswerEnum.Neutral,1),
							new Tuple<string, AnswerEnum,int>("Increase",AnswerEnum.Negative,2),
						},
					},

					new AssessmentItem
					{
                        AssessmentItemQuestion ="Client's breathing compared to yesterday:",
						AssessmentItemDescription = "Difficulty breathing may be a sign of a more serious problem. It makes it harder for the client to perform activitiesand can make the client anxious.",
						AssessmentItemResponseType = AssessmentItemResponseType.Ternary,
						AnswerLabels = new List<Tuple<string, AnswerEnum,int>>
						{
							new Tuple<string, AnswerEnum,int>("Better",AnswerEnum.Positive,0),
							new Tuple<string, AnswerEnum,int>("Same",AnswerEnum.Neutral,1),
							new Tuple<string, AnswerEnum,int>("Worse",AnswerEnum.Negative,2),
						},
					},

					new AssessmentItem
					{
						AssessmentItemQuestion ="Client's pain compared to yesterday:",
						AssessmentItemDescription = "Pain beyond that experienced in the normal aging process should be addressed because it could be a sign that the client has unusual inflammation, an injury, or an infection.",
						AssessmentItemResponseType = AssessmentItemResponseType.Ternary,
						AnswerLabels = new List<Tuple<string, AnswerEnum,int>>
						{
							new Tuple<string, AnswerEnum,int>("Better",AnswerEnum.Positive,0),
							new Tuple<string, AnswerEnum,int>("Same",AnswerEnum.Neutral,1),
							new Tuple<string, AnswerEnum,int>("Worse",AnswerEnum.Negative,2),
						},
					},
					new AssessmentItem
					{
						AssessmentItemQuestion ="Client's sleep compared to yesterday:",
						AssessmentItemDescription = "A good night's sleep is important for healing and well-being. If a client is having difficulty sleeping, it can be a sign of breathing difficulties, an inection or unresolved pain.",
						AssessmentItemResponseType = AssessmentItemResponseType.Ternary,
						AnswerLabels = new List<Tuple<string, AnswerEnum,int>>
						{
							new Tuple<string, AnswerEnum,int>("Better",AnswerEnum.Positive,0),
							new Tuple<string, AnswerEnum,int>("Same",AnswerEnum.Neutral,1),
							new Tuple<string, AnswerEnum,int>("Worse",AnswerEnum.Negative,2),
						},
					},
					new AssessmentItem
					{
						AssessmentItemQuestion ="Swelling in client's feet and ankles compared to yesterday:",
						AssessmentItemDescription = "Swelling in the client's lower extremities can be a sign of excess fluid in the body which can lead to other symptoms. Difficulty getting on socks or shoes can be an early warning sign.",
						AssessmentItemResponseType = AssessmentItemResponseType.Ternary,
						AnswerLabels = new List<Tuple<string, AnswerEnum,int>>
						{
							new Tuple<string, AnswerEnum,int>("Better",AnswerEnum.Positive,0),
							new Tuple<string, AnswerEnum,int>("Same",AnswerEnum.Neutral,1),
							new Tuple<string, AnswerEnum,int>("Worse",AnswerEnum.Negative,2),
						},
					},
					new AssessmentItem
					{
						AssessmentItemQuestion ="Client's mood compared to yesterday:",
						AssessmentItemDescription = "Changes in the client's mood can be a sign for the onset of depression. Depression can lead to poor personal care and/or missing medications",
						AssessmentItemResponseType = AssessmentItemResponseType.Ternary,
						AnswerLabels = new List<Tuple<string, AnswerEnum,int>>
						{
							new Tuple<string, AnswerEnum,int>("Better",AnswerEnum.Positive,0),
							new Tuple<string, AnswerEnum,int>("Same",AnswerEnum.Neutral,1),
							new Tuple<string, AnswerEnum,int>("Worse",AnswerEnum.Negative,2),
						},
					},
				};

            }
        }

        #region Global Application Storage  
        public string CurrentTargetAddress { get; set; }
        public bool HasAcceptedTermsAndConditions = true; //{ get; set; }
        public string TermsAndConditionsText { get; set; }
        public Appointment CurrentAppointment { get; set; }
        public List<Appointment> Appointments { get; set; }


        #endregion
    }
}

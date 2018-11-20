using System;
using System.Collections.Generic;


namespace welltrak
{
    public class Action: Entity
    {
        public AppointmentAction AppointmentAction;
        public string Comment;
        public List<Tuple<byte[], string, Guid>> Photos;
        public Guid AppointmentID;
        public ActionStatus Status;
        //public List<>
    }

    public enum ActionStatus 
    {
        ToDo 
        , MarkedComplete //InAppointment checked as complete
        , AttestedComplete //OnAppointmentFinished (As part of entire appointment submission
    }
}
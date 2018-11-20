using System;
using System.Collections.Generic;

namespace welltrak
{
    public class Appointment: Entity
    {
        public DateTime Time { get; set; }
        public Client Client { get; set; }
        public DateTime ArrivalTime { get; set; }
        public List<Action> Actions { get; set; }
        public List<AssessmentItem> AssessmentItems { get; set; }
    }
}

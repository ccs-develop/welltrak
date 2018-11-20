using System;
using System.Collections.Generic;
namespace welltrak
{
    public class AssessmentItem: Entity
    {

        public string AssessmentItemQuestion { get; set; }
        public string AssessmentItemDescription { get; set; }
        public AssessmentItemResponseType AssessmentItemResponseType {get;set;}
        public AssessmentItemAnswer AssessmentItemAnswer { get; set; }
        public List<Tuple<string,AnswerEnum,int>> AnswerLabels { get; set; }

    }

    public class AssessmentItemAnswer
    {
        public AnswerEnum AnswerValue;
        public string AnswerText;
    }

    public enum AnswerEnum 
    {
        Positive, Negative, Neutral
    }

    public enum AssessmentItemResponseType
    {
        DecimalRating,
        Ternary,
        Boolean
    }
}

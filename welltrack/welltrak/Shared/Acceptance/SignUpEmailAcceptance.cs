using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace welltrak.Shared
{
    /// <summary>
    /// Class holds fields that will be used by static class for email validation.
    /// </summary>
    public class SignUpEmailAcceptance
    {
        private bool isValid;
        public bool IsValid
        {
            get
            {
                if ((EmailEntered == true) && (EmailMatchConfirm == true)
                    && (EmailCharacters == true) /* && (EmailAuthorized==true) */)
                {
                    return true;
                }
                else { return false; }
            }
            set { isValid = value; }
        }

        public bool? EmailEntered { get; set; }
        public bool? EmailMatchConfirm { get; set; }
        public bool? EmailCharacters { get; set; }
        public bool EmailAuthorized { get; set; } // will use this to check if email is already in database or is a valid email (sending physical email.)
    }
}

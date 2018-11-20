using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace welltrak.Shared
{
    public class SignUpFormAcceptance
    {
        private bool isValid;

        public bool IsValid
        {
            get
            {
                if ((FormFieldsEntered == true) && (PhoneNumberFormat == true)
                  && (EmailAcceptance.IsValid == true) && (PasswordAcceptance.IsValid == true)
                  && (UsernameAcceptance.IsValid == true))
                {
                    return true;
                }
                else { return false; }
            }
            set { isValid = value; }
        }

        public bool? FormFieldsEntered { get; set; }
        public bool? PhoneNumberFormat { get; set; }
        public SignUpEmailAcceptance EmailAcceptance { get; set; }
        public SignUpPasswordAcceptance PasswordAcceptance { get; set; }
        public SignUpUsernameAcceptance UsernameAcceptance { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace welltrak.Shared
{
    /// <summary>
    /// Class holds fields that will be used by static class for password validation. 
    /// </summary>
    public class SignUpPasswordAcceptance
    {
        private bool isValid;
        public bool IsValid
        {
            get
            {
                if ((PasswordEntered == true) && (PasswordLength == true)
                  && (PasswordCharacters == true) && (PasswrodMatchConfirm == true))
                {
                    return true;
                }
                else { return false; }
            }
            set { isValid = value; }
        }

        public bool? PasswordEntered { get; set; }
        public bool? PasswordLength { get; set; }
        public bool? PasswordCharacters { get; set; }
        public bool? PasswrodMatchConfirm { get; set; }
    }
}

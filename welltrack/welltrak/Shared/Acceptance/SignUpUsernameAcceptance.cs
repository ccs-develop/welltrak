using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace welltrak.Shared
{
    public class SignUpUsernameAcceptance
    {
        private bool isValid;

        public bool IsValid
        {
            get
            {
                if ((UsernameEntered == true) && (UsernameLength == true)
                  && (UsernameCharacters == true) /*&& (UsernameAvailable == true) */)
                {
                    return true;
                }
                else { return false; }
            }
            set { isValid = value; }
        }

        public bool? UsernameEntered { get; set; }
        public bool UsernameAvailable { get; set; } //username already in database
        public bool? UsernameLength { get; set; }
        public bool? UsernameCharacters { get; set; }
    }
}

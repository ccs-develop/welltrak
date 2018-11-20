using System.Text.RegularExpressions;

namespace welltrak.Shared
{
    /// <summary>
    /// Class that will validate users attempts to sign up for WellTrak.
    /// </summary>
    public static class SignUpFormValidation
    {

        /// <summary>
        /// method checks user sign up password for proper length, format, and matching confirm password input.Returns SignUpPasswordAcceptance Object
        /// </summary>
        /// <param name="txtPassword"></param>
        /// <param name="txtConfirmPassword"></param>
        public static SignUpPasswordAcceptance ValidatePasswords(string txtPassword, string txtConfirmPassword)
        {

            SignUpPasswordAcceptance SignUpPasswordAO = new SignUpPasswordAcceptance();
            if (txtPassword.Length > 0 && txtConfirmPassword.Length > 0)
            {
                SignUpPasswordAO.PasswordEntered = true;

                if (txtPassword.Length < 8)
                {
                    SignUpPasswordAO.PasswordLength = false;
                }
                else
                {
                    SignUpPasswordAO.PasswordLength = true;
                }

                if (Regex.Match(txtPassword, @"^(?![a-z]*$)(?![A-Z]*$)(?!\d*$)(?!\p{P}*$)(?![^a-zA-Z\d\p{P}]*$).{6,}$").Success) //changed
                {
                    SignUpPasswordAO.PasswordCharacters = true;
                }
                else
                {
                    SignUpPasswordAO.PasswordCharacters = false;
                }

                if (txtPassword != txtConfirmPassword)
                {
                    SignUpPasswordAO.PasswrodMatchConfirm = false;
                }
                else
                {
                    SignUpPasswordAO.PasswrodMatchConfirm = true;
                }
            }
            else
            {
                SignUpPasswordAO.PasswordEntered = false;
            }
            return SignUpPasswordAO;
        }

        /// <summary>
        /// This static method will validate that the emails being inputed are valid and matching.
        /// </summary>
        /// <param name="txtConfirmEmail"></param>
        /// <param name="txtEmail"></param>
        /// <returns></returns>
        public static SignUpEmailAcceptance ValidateEmailAddresses(string txtEmail, string txtConfirmEmail)
        {
            SignUpEmailAcceptance SignUpEmailAO = new SignUpEmailAcceptance();

            if (txtConfirmEmail.Length > 0 && txtEmail.Length > 0)
            {
                SignUpEmailAO.EmailEntered = true;

                if (txtEmail != txtConfirmEmail)
                {
                    SignUpEmailAO.EmailMatchConfirm = false;
                }
                else
                {
                    SignUpEmailAO.EmailMatchConfirm = true;

                    try
                    {
                        var addr = new System.Net.Mail.MailAddress(txtEmail);
                        SignUpEmailAO.EmailCharacters = true;
                    }
                    catch
                    {
                        SignUpEmailAO.EmailCharacters = false;
                    }

                    //call to data base is email authorized or already used. if no the SingUpEmailAO.EmailAuthorized = true; 

                }
            }
            else SignUpEmailAO.EmailEntered = false;
            return SignUpEmailAO;
        }

        /// <summary>
        /// This Method checks the username input to verify if valid input.
        /// </summary>
        /// <param name="txtUsername"></param>
        /// <returns></returns>
        public static SignUpUsernameAcceptance ValidateUsername(string txtUsername)
        {
            SignUpUsernameAcceptance SignUpUsernameAO = new SignUpUsernameAcceptance();

            if (txtUsername.Length > 0)
            {
                SignUpUsernameAO.UsernameEntered = true;

                if (txtUsername.Length < 6)
                {
                    SignUpUsernameAO.UsernameLength = false;
                }
                else
                {
                    SignUpUsernameAO.UsernameLength = true;

                    if (Regex.Match(txtUsername, @"^[a-zA-Z0-9]+$").Success)
                    {
                        SignUpUsernameAO.UsernameCharacters = true;
                    }
                    else
                    {
                        SignUpUsernameAO.UsernameCharacters = false;
                    }

                }
                //TODO: call to database to verify username not in database if not in database SignUpUsernameAO.UsernameAvailable = true;
            }
            else SignUpUsernameAO.UsernameEntered = false;

            return SignUpUsernameAO;
        }

        /// <summary>
        /// This Method verifies that all fields in the SignUp Screen are filled. Also verifies phone number format.
        /// </summary>
        /// <param name="txtFirstName"></param>
        /// <param name="txtLastName"></param>
        /// <param name="txtEmail"></param>
        /// <param name="txtConfirmEmail"></param>
        /// <param name="txtPassword"></param>
        /// <param name="txtRepeatPassword"></param>
        /// <param name="txtUsername"></param>
        /// <param name="txtPhoneNumber"></param>
        /// <returns></returns>
        public static SignUpFormAcceptance ValidateForm(string txtFirstName, string txtLastName, string txtPhoneNumber, string txtEmail,
        string txtConfirmEmail, string txtPassword, string txtConfirmPassword, string txtUsername) 
        {
            SignUpFormAcceptance SignUpFormAO = new SignUpFormAcceptance();

            bool validated = (txtFirstName.Length > 0
                 && txtLastName.Length > 0
                 && txtEmail.Length > 0
                 && txtConfirmEmail.Length > 0
                 && txtPassword.Length > 0
                 && txtConfirmPassword.Length > 0
                 && txtUsername.Length > 0
                 && txtPhoneNumber.Length > 0
                 );

            if (!validated)
            {
                SignUpFormAO.FormFieldsEntered = false;
            }
            else
            {
                SignUpFormAO.FormFieldsEntered = true;

                if (Regex.Match(txtPhoneNumber, @"\(?\d{3}\)?-? *\d{3}-? *-?\d{4}").Success)
                {
                    SignUpFormAO.PhoneNumberFormat = true;
                }
                else
                {
                    SignUpFormAO.PhoneNumberFormat = false;
                }
            }

            SignUpFormAO.EmailAcceptance =  ValidateEmailAddresses(txtEmail, txtConfirmEmail);
            SignUpFormAO.PasswordAcceptance = ValidatePasswords(txtPassword, txtConfirmPassword);
            SignUpFormAO.UsernameAcceptance = ValidateUsername(txtUsername);
            return SignUpFormAO;
        }
    }
}


using Microsoft.VisualStudio.TestTools.UnitTesting;
using welltrak.Shared;

namespace welltrak.Droid.Tests
{
    [TestClass()]
    public class SignUpFormValidationTests
    {
        /// <summary>
        /// Test (Successful) validate password method.
        /// </summary>
        [TestMethod()]
        public void ValidatePasswords_Success()
        {
            //Arrange, Act, Assert 
            var AO = SignUpFormValidation.ValidatePasswords("Welltrak1!", "Welltrak1!");
            Assert.IsTrue((AO.PasswordEntered == true) && (AO.PasswordLength == true)
                 && (AO.PasswordCharacters == true)  && (AO.PasswrodMatchConfirm == true));
        }
        /// <summary>
        /// Test (Fail Entered) validate password method.
        /// </summary>
        [TestMethod()]
        public void ValidatePasswords_Fail1()
        {
            //Arrange, Act, Assert 
            var AO = SignUpFormValidation.ValidatePasswords("Welltrak1!", "");
            Assert.IsTrue((AO.PasswordEntered == false) && (AO.PasswordLength == null)
                 && (AO.PasswordCharacters == null)  && (AO.PasswrodMatchConfirm == null));
        }
        /// <summary>
        /// Test (Fail Length) validate password method.
        /// </summary>
        [TestMethod()]
        public void ValidatePasswords_Fail2()
        {
            //Arrange, Act, Assert 
            var AO = SignUpFormValidation.ValidatePasswords("trak", "trak");
            Assert.IsTrue((AO.PasswordEntered == true) && (AO.PasswordLength == false)
                 && (AO.PasswordCharacters == false) && (AO.PasswrodMatchConfirm == true));
        }
        /// <summary>
        /// Test (Fail Characters) validate password method.
        /// </summary>
        [TestMethod()]
        public void ValidatePasswords_Fail3()
        {
            //Arrange, Act, Assert 
            var AO = SignUpFormValidation.ValidatePasswords("wwwwwwwwwwww", "wwwwwwwwwwww");
            Assert.IsTrue((AO.PasswordEntered == true) && (AO.PasswordLength == true)
                 && (AO.PasswordCharacters == false)  && (AO.PasswrodMatchConfirm == true));
        } 
          /// <summary>
          /// Test (Fail Match Confirm) validate password method.
          /// </summary>
        [TestMethod()]
        public void ValidatePasswords_Fail4()
        {
            //Arrange, Act, Assert 
            var AO = SignUpFormValidation.ValidatePasswords("Welltrak1!", "Welltrak1");
            Assert.IsTrue((AO.PasswordEntered == true) && (AO.PasswordLength == true)
                 && (AO.PasswordCharacters == true) && (AO.PasswrodMatchConfirm == false));
        }


        /// <summary>
        /// Test (Successful) validate email method.
        /// </summary>
        [TestMethod()]
        public void ValidateEmailAddress_Success()
        {
            //Arrange, Act, Assert
            var AO = SignUpFormValidation.ValidateEmailAddresses("Welltrak@gmail.com", "Welltrak@gmail.com");
            Assert.IsTrue((AO.EmailEntered == true) && (AO.EmailMatchConfirm == true) && (AO.EmailCharacters == true));
        }
        /// <summary>
        /// Test (Fail Entered) validate email method.
        /// </summary>
        [TestMethod()]
        public void ValidateEmailAddress_Fail1()
        {
            //Arrange, Act, Assert
            var AO = SignUpFormValidation.ValidateEmailAddresses("Welltrak@gmail.com", "");
            Assert.IsTrue((AO.EmailEntered == false) && (AO.EmailMatchConfirm == null) && (AO.EmailCharacters == null));
        }
        /// <summary>
        /// Test (Fail Match Confirm) validate email method.
        /// </summary>
        [TestMethod()]
        public void ValidateEmailAddress_Fail2()
        {
            //Arrange, Act, Assert
            var AO = SignUpFormValidation.ValidateEmailAddresses("Welltrak@gmail.com", "Welltak@gmail.com");
            Assert.IsTrue((AO.EmailEntered == true) && (AO.EmailMatchConfirm == false) && (AO.EmailCharacters == null));
        }
        /// <summary>
        /// Test (Fail Characters) validate email method.
        /// </summary>
        [TestMethod()]
        public void ValidateEmailAddress_Fail3()
        {
            //Arrange, Act, Assert
            var AO = SignUpFormValidation.ValidateEmailAddresses("Welltrak", "Welltrak");
            Assert.IsTrue((AO.EmailEntered == true) && (AO.EmailMatchConfirm == true) && (AO.EmailCharacters == false));
        }



        /// <summary>
        /// Test (Successful) validate username method.
        /// </summary>
        [TestMethod()]
        public void ValidateUsername_Success()
        {
            //Arrange, Act, Assert
            var AO = SignUpFormValidation.ValidateUsername("Welltrak1");
            Assert.IsTrue((AO.UsernameEntered == true) && (AO.UsernameLength == true) && (AO.UsernameCharacters == true));
        }
        /// <summary>
        /// Test (Fail Entered) validate username method.
        /// </summary>
        [TestMethod()]
        public void ValidateUsername_Fail1()
        {
            //Arrange, Act, Assert
            var AO = SignUpFormValidation.ValidateUsername("");
            Assert.IsTrue((AO.UsernameEntered == false) && (AO.UsernameLength == null) && (AO.UsernameCharacters == null));
        }
        /// <summary>
        /// Test (Fail Length) validate username method.
        /// </summary>
        [TestMethod()]
        public void ValidateUsername_Fail2()
        {
            //Arrange, Act, Assert
            var AO = SignUpFormValidation.ValidateUsername("Well");
            Assert.IsTrue((AO.UsernameEntered == true) && (AO.UsernameLength == false) && (AO.UsernameCharacters == null));
        }
        /// <summary>
        /// Test (Fail Characters) validate username method.
        /// </summary>
        [TestMethod()]
        public void ValidateUsername_Fail3()
        {
            //Arrange, Act, Assert
            var AO = SignUpFormValidation.ValidateUsername("Welltrak1!@#");
            Assert.IsTrue((AO.UsernameEntered == true) && (AO.UsernameLength == true) && (AO.UsernameCharacters == false));
        }



        /// <summary>
        /// Test (Success) validate ValidateForm method. 
        /// </summary>
        [TestMethod()]
        public void ValidateForm_Success()
        {
            //Arrange, Act, Assert
            var AO = SignUpFormValidation.ValidateForm("Luke", "Skywalker", "770-883-2456", "LBeth@mail.com", "LBeth@mail.com", "abc123!@#", "abc123!@#", "LSkywalker1");
            Assert.IsTrue((AO.FormFieldsEntered == true) && (AO.PhoneNumberFormat == true) && (AO.IsValid == true));
        }
        /// <summary>
        /// Test (Fail Form Fields Entered) validate ValidateForm method. 
        /// </summary>
        [TestMethod()]
        public void ValidateForm_Fail1()
        {
            //Arrange, Act, Assert
            var AO = SignUpFormValidation.ValidateForm("", "Skywalker", "770-883-2456", "LBeth@mail.com", "LBeth@mail.com", "abc123!@#", "abc123!@#", "LSkywalker1");
            Assert.IsTrue((AO.FormFieldsEntered == false) && (AO.PhoneNumberFormat == null) && (AO.IsValid == false));
        }
        /// <summary>
        /// Test (Fail Phone Number Format) validate ValidateForm method. 
        /// </summary>
        [TestMethod()]
        public void ValidateForm_Fail2()
        {
            //Arrange, Act, Assert
            var AO = SignUpFormValidation.ValidateForm("Luke", "Skywalker", "A70-8C3-2!56", "LBeth@mail.com", "LBeth@mail.com", "abc123!@#", "abc123!@#", "LSkywalker1");
            Assert.IsTrue((AO.FormFieldsEntered == true) && (AO.PhoneNumberFormat == false) && (AO.IsValid = true));
        }
        /// <summary>
        /// Test (Fail email format) validate ValidateForm method. 
        /// </summary>
        [TestMethod()]
        public void ValidateForm_Fail3()
        {
            //Arrange, Act, Assert
            var AO = SignUpFormValidation.ValidateForm("Luke", "Skywalker", "770-883-2456", "LBethmailcom", "LBethmailcom", "abc123!@#", "abc123!@#", "LSkywalker1");
            Assert.IsTrue((AO.FormFieldsEntered == true) && (AO.PhoneNumberFormat == true) && (AO.IsValid == false));
        }
        /// <summary>
        /// Test (Fail because Password) validate ValidateForm method. 
        /// </summary>
        [TestMethod()]
        public void ValidateForm_Fail4()
        {
            //Arrange, Act, Assert
            var AO = SignUpFormValidation.ValidateForm("Luke", "Skywalker", "770-883-2456", "LBeth@mail.com", "LBeth@mail.com", "abcdef", "abcdef", "LSkywalker1");
            Assert.IsTrue((AO.FormFieldsEntered == true) && (AO.PhoneNumberFormat == true) && (AO.IsValid == false));
        }
        /// <summary>
        /// Test (Fail because Username) validate ValidateForm method. 
        /// </summary>
        [TestMethod()]
        public void ValidateForm_Fail5()
        {
            //Arrange, Act, Assert
            var AO = SignUpFormValidation.ValidateForm("Luke", "Skywalker", "770-883-2456", "LBeth@mail.com", "LBeth@mail.com", "abc123!@#", "abc123!@#", "sky");
            Assert.IsTrue((AO.FormFieldsEntered == true) && (AO.PhoneNumberFormat == true) && (AO.IsValid == false));
        }
    }
}
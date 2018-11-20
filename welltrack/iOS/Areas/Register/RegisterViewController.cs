using Foundation;
using System;
using UIKit;
using System.Collections.Generic;
using System.Text.RegularExpressions;
//using welltrak.Shared;

namespace welltrak.iOS
{
	public partial class RegisterViewController : UIViewController
	{
		List<string> ErrorMessages = new List<string>();

		public RegisterViewController(IntPtr handle) : base(handle)
		{

		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			lblErrors.Text = string.Empty;
		}

		partial void UIButton337_TouchUpInside(UIButton sender)
		{
			if (ValidateForm())
			{
				this.PerformSegue("registerToWelcomeSegue", this);
			}
		}


		partial void FirstEmailDidEndEdit(UITextField sender)
		{
			ValidateEmailAddresses();
		}

		partial void ConfirmEmailDidEndEdit(UITextField sender)
		{
			ValidateEmailAddresses();
		}

		partial void FirstPasswordDidEndEdit(UITextField sender)
		{
			ValidatePasswords();
		}

		partial void RepeatPasswordDidEndEdit(UITextField sender)
		{
			ValidatePasswords();
		}

		partial void DesiredUsernameDidEndEdit(UITextField sender)
		{
			ValidateUsername();
		}

		internal void ValidateUsername()
		{
			if (txtUsername.Text.Length < 6)
			{
				AddErrorMessages("Username must be at least 6 characters.");
			}
			else
			{
				RemoveErrorMessage("Username must be at least 6 characters.");
			}
		}

		internal bool ValidateForm()
		{
			bool validated = (txtFirstName.Text.Length > 0
				 && txtLastName.Text.Length > 0
				 && txtEmail.Text.Length > 0
				 && txtConfirmEmail.Text.Length > 0
				 && txtPassword.Text.Length > 0
				 && txtRepeatPassword.Text.Length > 0
				 && txtUsername.Text.Length > 0
	             );

			if (!validated)
			{
				AddErrorMessages("Please fill in all fields to continue.");
			}
			else
			{ 
				RemoveErrorMessage("Please fill in all fields to continue.");
			}

			validated = (validated && ErrorMessages.Count == 0);
			return validated;		
		}
				
		internal void ValidateEmailAddresses()
		{
			if (txtConfirmEmail.Text.Length > 0 && txtEmail.Text.Length > 0)
			{
				if (txtEmail.Text != txtConfirmEmail.Text)
				{
                    AddErrorMessages("Emails do not match.");
				}
				else
				{
                    RemoveErrorMessage("Emails do not match.");
					if (Regex.Match(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$").Success)
				    {
						RemoveErrorMessage("Email is not properly formatted.");       
				    }
					else
				    {
                        AddErrorMessages("Email is not properly formatted.");             
				    }

				}
			}
		}

		internal void ValidatePasswords()
		{
			if (txtPassword.Text.Length > 0 && txtRepeatPassword.Text.Length > 0)
			{
				if (txtPassword.Text.Length < 8)
				{
                    AddErrorMessages("Passwords must be at least 8 characters long.");
				}
				else
				{
					RemoveErrorMessage("Passwords must be at least 8 characters long.");
					return;
				}

				if (Regex.Match(txtPassword.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*(_|-+_!@#$%^&*.,?)).+$").Success)
				{
					RemoveErrorMessage("Password needs 1: lower & upper alpha, numeral & symbol");
				}
				else
				{
                    AddErrorMessages("Password needs 1: lower & upper alpha, numeral & symbol");
				}

				if (txtPassword.Text != txtRepeatPassword.Text)
				{
                    AddErrorMessages("Passwords do not match.");
				}
				else
				{
					RemoveErrorMessage("Passwords do not match.");
				}
			}
			
		}

		internal void AddErrorMessages(string msg)
		{
			if (!ErrorMessages.Exists(x => x == msg))
			{
				ErrorMessages.Add(msg);
			}

			SetErrorText();
		}

		internal void RemoveErrorMessage(string msg)
		{
			if (ErrorMessages.Exists(x => x == msg))
			{
				ErrorMessages.Remove(msg);
			}
			SetErrorText();
		}

		internal void SetErrorText()
		{ 
 			string errors = string.Empty;
			foreach (string s in ErrorMessages)
			{	
				errors = s + "\n";
			}
			lblErrors.Text = errors;
		}
    }
}
using Android.App;
using Android.Widget;
using Android.OS;
using HockeyApp.Android;
using HockeyApp.Android.Metrics;

namespace welltrak.Droid
{
    [Activity(Label = "welltrak", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;
        private Button mButtonCreateAccount;
        private Button mButtonLogin;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
           mButtonCreateAccount = FindViewById<Button>(Resource.Id.btnCreateAnAccount);

            mButtonCreateAccount.Click += MButtonCreateAccount_Click; 

           mButtonLogin = FindViewById<Button>(Resource.Id.btnLogin);

            mButtonLogin.Click += MButtonLogin_Click;

            CheckForUpdates();
        }

        private void MButtonLogin_Click(object sender, System.EventArgs e)
        {
            FragmentTransaction transaction = FragmentManager.BeginTransaction();
            dialog_Login loginDialog = new dialog_Login();
            loginDialog.Show(transaction, "dialog Fragment"); 
        }

        private void MButtonCreateAccount_Click(object sender, System.EventArgs e)
        {
            FragmentTransaction transaction = FragmentManager.BeginTransaction();
            dialog_CreateAccount createAccountDialog = new dialog_CreateAccount();
            createAccountDialog.Show(transaction, "dialog Fragment");
        }

        protected override void OnResume()
        {
            base.OnResume();
            MetricsManager.Register(Application, $"da03f5f384e84fada96ca75c95e7c02d");
            CrashManager.Register(this, $"da03f5f384e84fada96ca75c95e7c02d");
        }
        private void CheckForUpdates()
        {
            // Remove this for store builds!
#if DEBUG
            UpdateManager.Register(this, $"da03f5f384e84fada96ca75c95e7c02d");
#endif
		}

		private void UnregisterManagers()
		{
			UpdateManager.Unregister();
		}

		protected override void OnPause()
		{
			base.OnPause();
			UnregisterManagers();
		}

		protected override void OnDestroy()
		{
			base.OnDestroy();
			UnregisterManagers();
		}

	}
}


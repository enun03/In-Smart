using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Threading;

namespace login_system
{//esto es sin cafe
    [Activity(Label = "login_system", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity{
        //here you set the variables up by name and purpose.
        private ProgressBar mProgressBar;
        private Button mBtnSignUp, mbtnsignin;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.log);
            mBtnSignUp = FindViewById<Button>(Resource.Id.btnsignup);
            mbtnsignin = FindViewById<Button>(Resource.Id.btnsignin);
            mProgressBar = FindViewById<ProgressBar>(Resource.Id.progressBar1);
            mbtnsignin.Click += mbtnsignin_Click;  // Added to send user to the next page.
            //primero los botones y luego los events.
            mBtnSignUp.Click += (object sender, EventArgs args) =>
         

            {

                //pull up dialog
                FragmentTransaction transaction = FragmentManager.BeginTransaction();
                dialog_SignUp signUpDialog = new dialog_SignUp();
                signUpDialog.Show(transaction, "dialog fragment");

                signUpDialog.mOnSignUpComplete += SignUpDialog_mOnSignUpComplete;
                //lo que se conoce como el Dialog, Util para warnings o Info adds.
            };




        }
        // The intent is used to send the user to the next page.
        //me tomo 2 horas pero lo logre.
        private void mbtnsignin_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(menuActivity));
            StartActivity(intent);
        }

        void SignUpDialog_mOnSignUpComplete(object sender, OnSignUpEventArgs e)
        {
            mProgressBar.Visibility = ViewStates.Visible;
            Thread thread = new Thread(ActLikeARequest);
            thread.Start();
           
        }
        private void ActLikeARequest()
        {// this is used for the progress bar. 3000= 3 seconds
            Thread.Sleep(3000);
            RunOnUiThread(() => { mProgressBar.Visibility = ViewStates.Invisible; });
            // de derecha a izquierda (el progress bar esta invisible una vez que se cumple la action se vuelve visible por 3 segundos)
        }
        
    }
}


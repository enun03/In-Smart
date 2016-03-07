using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace login_system
{
    [Activity(Label = "Menu")]
    public class menuActivity : Activity
    { //Here i set the variables to be used. This could be a permanent fix or a temp fix. 
        private Button mButtonMenu1, mButtonMenu2, mButtonMenu3 ;//mButtonMenu4

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Menu);
            mButtonMenu1 = FindViewById<Button>(Resource.Id.ButtonMenu1);
            mButtonMenu2 = FindViewById<Button>(Resource.Id.ButtonMenu2);
            mButtonMenu3 = FindViewById<Button>(Resource.Id.ButtonMenu3);
           // mButtonMenu4 = FindViewById<Button>(Resource.Id.ButtonMenu4);


            mButtonMenu1.Click += MButtonMenu1_Click;
            mButtonMenu2.Click += mButtonMenu2_Click;
            mButtonMenu3.Click += MButtonMenu3_Click;
           // mButtonMenu4.Click += MButtonMenu4_Click;
 
        }

     /*/  private void MButtonMenu4_Click(object sender, EventArgs e)
        {
            
        } */
        //i left the 4th button in here just incase somebody needs it.
        private void MButtonMenu3_Click(object sender, EventArgs e)
        {
          var intent = new Intent(this, typeof(SchedulerActivity));
            StartActivity(intent);
        }

        private void mButtonMenu2_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(ChatActivity));
            StartActivity(intent);
        }

        private void MButtonMenu1_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(BulletinActivity));
            StartActivity(intent);
        }

    }
}
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
    {
        private Button mButtonMenu1, mButtonMenu2, mButtonMenu3, mButtonMenu4;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Bulletin);
            mButtonMenu1 = FindViewById<Button>(Resource.Id.ButtonMenu1);
            mButtonMenu2 = FindViewById<Button>(Resource.Id.ButtonMenu2);
            mButtonMenu3 = FindViewById<Button>(Resource.Id.ButtonMenu3);
            mButtonMenu4 = FindViewById<Button>(Resource.Id.ButtonMenu4);



        }
        
    }
}
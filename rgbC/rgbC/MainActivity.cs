using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace rgbC
{
    [Activity(Label = "rgbC", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        Button Convertbutton;
        TextView hexvaluetextfield;
        EditText redvaluelabel, bluevaluelabel,greenvaluelabel;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            Convertbutton = FindViewById<Button>(Resource.Id.Convertbutton);
            hexvaluetextfield = FindViewById<TextView>(Resource.Id.hexvaluetextfield);
            redvaluelabel = FindViewById<EditText>(Resource.Id.redvaluelabel);
            bluevaluelabel = FindViewById<EditText>(Resource.Id.bluevaluelabel);
            greenvaluelabel = FindViewById<EditText>(Resource.Id.greenvaluelabel);
            Convertbutton.Click += Convertbutton_Click;

        }

        private void Convertbutton_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            string hexvalue = hexvaluetextfield.Text;
            string redhexvalue = hexvalue.Substring(0, 2);
            string greenhexvalue = hexvalue.Substring(2, 2);
            string bluehexvalue = hexvalue.Substring(4, 2);

        }
    }
}


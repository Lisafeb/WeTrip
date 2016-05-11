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

namespace WeTripAndroidApp
{
    [Activity(Label = "Activity1")]
    public class Activity1 : Activity
    {
        void OnClick(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(Activity1));
            base.StartActivity(intent);
        }
    
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }
    }
}
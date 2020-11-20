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

namespace Profus_mobile
{
<<<<<<< HEAD
    [Activity(Label = "@string/app_name",Name = "Info", Theme = "@style/AppTheme", MainLauncher = false, NoHistory = true)]
=======
    [Activity(Label = "Info")]
>>>>>>> parent of 33b27d6... 1.1.1
    public class Info : Activity
    {        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.Info);

            // Create your application here
        }
    }
}
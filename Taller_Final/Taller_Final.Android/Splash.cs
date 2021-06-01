using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Taller_Final.Droid
{
    [Activity(Label = "AMPH" ,Theme = "@style/slash_theme", MainLauncher =true,NoHistory =true,ConfigurationChanges = Android.Content.PM.ConfigChanges.ScreenSize)]
    public class Splash : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));

            // Create your application here
        }
    }
}
using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace thorpenCommonFunctions
{
    [Activity(Label = "LearningApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        clsCommonFunctions cmnFunctions = new clsCommonFunctions();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { DoButtonPress();  };

            button = FindViewById<Button>(Resource.Id.cmdShowCount);
            button.Click += delegate { ShowCount(); };

        }

        protected override void OnStart()
        {
            base.OnStart();

            if (clsGlobalFunctions.LoggedIn == false)
            {
                StartActivity(typeof(layout1Activity));
            }
        }

        void Restart()
        {
            
            if (count == 10)
            {
                count = 0;
                clsGlobalFunctions.LoggedIn = false;
                if (clsGlobalFunctions.LoggedIn == false)
                {
                    StartActivity(typeof(layout1Activity));
                }
            }
        }

        void ShowCount()
        {
            StartActivity(typeof(layout2));
        }

        void DoButtonPress()
        {


            Button button = FindViewById<Button>(Resource.Id.MyButton);
            button.Text = string.Format("{0} clicks!", count++);

            cmnFunctions.SetGlobalInt("gblCount", count);

            Restart();
        }
    }
}


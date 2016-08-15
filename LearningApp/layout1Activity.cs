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


namespace LearningApp
{
    [Activity(Label = "layout1")]
    public class layout1Activity : Activity 
    {

        clsCommonFunctions cmnFunctions = new clsCommonFunctions();
        clsGlobalFunctions globalFuncitons = new clsGlobalFunctions();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.layout1);

            // Create your application here

            Button button = FindViewById<Button>(Resource.Id.button1);

            button.Click += delegate { LogIn(); };

            button = FindViewById<Button>(Resource.Id.button2);

            button.Click += delegate { LogOut(); };
        

        }

        public  void LogIn()
        {
            globalFuncitons.Login();
            this.Finish();
        }

        public  void LogOut()
        {
            globalFuncitons.Logout();
            this.Finish();
        }
    }
}
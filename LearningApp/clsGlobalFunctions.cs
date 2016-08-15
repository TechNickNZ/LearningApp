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

    class clsGlobalFunctions : Activity
    {

        public static Boolean LoggedIn = false;

        public void Logout()
        {
            LoggedIn = false;
        }

        public void Login()
        {
            LoggedIn = true;
        }
    }
}
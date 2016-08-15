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
    class layout2 : Activity
    {
        clsCommonFunctions cmnFunctions = new clsCommonFunctions();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            int count;
            base.OnCreate(savedInstanceState);
            count = cmnFunctions.GetGlobalInt("gblCount");
            TextView textView;
            textView = (TextView)FindViewById(Resource.Id.txtCount);
            textView.Text = count.ToString();
        }
    }
}
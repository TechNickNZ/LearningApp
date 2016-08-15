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
using Android.Preferences;

namespace LearningApp
{
    public class clsCommonFunctions
    {
        ISharedPreferences GlobalPreferences;
        ISharedPreferencesEditor GlobalPrefEditor;


        public Boolean getGlobalBoolean(String valueKey)
        {
            return GlobalPreferences.GetBoolean(valueKey, false);
        }
        public void SetGlobalBoolean(String valueKey, Boolean valueData)
        {
            GlobalPrefEditor.PutBoolean(valueKey, valueData);
        }
        public String GetGlobalString(String valueKey)
        {
            return GlobalPreferences.GetString(valueKey, "");
        }
        public void SetGlobalString(String valueKey, String valueData)
        {
            GlobalPrefEditor.PutString(valueKey, valueData);
        }
        public int GetGlobalInt(String valueKey)
        {
            return GlobalPreferences.GetInt(valueKey, 0);
        }
        public void SetGlobalInt(String valueKey, int valueData)
        {
            GlobalPrefEditor.PutInt(valueKey, valueData);
        }
    }
}
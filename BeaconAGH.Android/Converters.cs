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

namespace BeaconAGH.Android
{
    public class Converters
    {
        public static string IntToString(int val)
        {
            return val.ToString();
        }

        public static string DateTimeToString(DateTime val)
        {
            return val.ToLongTimeString();
        }
    }
}
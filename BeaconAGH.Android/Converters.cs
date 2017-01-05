using System;

namespace BeaconAGH.Android
{
    public class Converters
    {
        public static string IntToString(int val)
        {
            return val.ToString();
        }

        public static string NullableIntToString(int? val)
        {
            return val != null ? val.ToString() : "Not obtainable";
        }

        public static string DateTimeToString(DateTime val)
        {
            return val.ToLongTimeString();
        }
    }
}
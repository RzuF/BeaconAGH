using Android.App;
using Android.OS;

namespace BeaconAGH.Android
{
    [Activity(Label = "BeaconAGH.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public partial class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}


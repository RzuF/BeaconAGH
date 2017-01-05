using System.Collections.Generic;
using Android.App;
using Android.OS;
using BeaconAGH.VM;
using GalaSoft.MvvmLight.Helpers;

namespace BeaconAGH.Android
{
    [Activity(Label = "BeaconAGH.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public partial class MainActivity : Activity
    {
        List<Binding> _bindings = new List<Binding>();

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var x = ViewModelLocator.Main.Id;

            _bindings.Add(this.SetBinding(() => ViewModelLocator.Main.Id, () => IdEditText.Text).ConvertSourceToTarget(Converters.IntToString));
            _bindings.Add(this.SetBinding(() => ViewModelLocator.Main.Delay, () => DelayEditText.Text).ConvertSourceToTarget(Converters.IntToString));
            _bindings.Add(this.SetBinding(() => ViewModelLocator.Main.Range, () => RangeEditText.Text).ConvertSourceToTarget(Converters.IntToString));
            _bindings.Add(this.SetBinding(() => ViewModelLocator.Main.Timestamp, () => TimestampEditText.Text).ConvertSourceToTarget(Converters.DateTimeToString));

            GetDataOneButton.SetCommand("Click", ViewModelLocator.Main.RequestDataTimestampCommand);
            GetDataTwoButton.SetCommand("Click", ViewModelLocator.Main.RequestDataNoTimestampCommand);
        }
    }
}


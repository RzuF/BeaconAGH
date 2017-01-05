using System;
using Android.App;
using Android.Runtime;
using BeaconAGH.VM;

namespace BeaconAGH.Android
{
    [Application]
    public class BeaconAGH : Application
    {
        public BeaconAGH(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer)
        {
        }

        public override void OnCreate()
        {
            base.OnCreate();

            AndroidViewModelLocator.RegisterDependencies();

            new ViewModelLocator();
        }

        public override void OnTerminate()
        {
            base.OnTerminate();
        }
    }
}
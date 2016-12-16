using System;
using Android.App;
using Android.Runtime;

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
        }

        public override void OnTerminate()
        {
            base.OnTerminate();
        }
    }
}
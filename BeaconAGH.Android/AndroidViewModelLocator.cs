using BeaconAGH.Adapters;
using BeaconAGH.Android.Adapters;
using BeaconAGH.VM;
using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace BeaconAGH.Android
{
    public static class AndroidViewModelLocator
    {
        public static void RegisterDependencies()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default); //first and only registaration

            SimpleIoc.Default.Register<ILocationProvider>(() => new LocationProvider()); //register android adapter implementation to use it in shared code via reflection
        }
    }
}
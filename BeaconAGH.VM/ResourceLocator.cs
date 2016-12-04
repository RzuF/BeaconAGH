using BeaconAGH.Adapters;
using GalaSoft.MvvmLight.Ioc;

namespace BeaconAGH.VM
{
    public static class ResourceLocator
    {
        public static ILocationProvider LocationProvider => SimpleIoc.Default.GetInstance<ILocationProvider>();
    }
}

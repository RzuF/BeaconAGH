using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;

namespace BeaconAGH.VM
{
    public class ViewModelLocator
    {
        #region Init

        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<MainViewModel>();
        }

        #endregion

        #region Propierties

        public static MainViewModel Main => ServiceLocator.Current.GetInstance<MainViewModel>();

        #endregion
    }
}

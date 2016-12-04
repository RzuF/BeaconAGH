using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;

namespace BeaconAGH.VM
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel(IMessenger messenger) : base(messenger)
        {
        }
    }
}

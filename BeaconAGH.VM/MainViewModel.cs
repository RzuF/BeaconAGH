using System;
using System.Windows.Input;
using BeaconAGH.Adapters;
using BeaconAGH.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using BeaconAGH.BL.LocationProcessor;

namespace BeaconAGH.VM
{
    public class MainViewModel : ViewModelBase
    {
        #region Private Variables

        #endregion


        public MainViewModel(ILocationProvider locationProvider)
        {
            _locationProvider = locationProvider;

            LocationProcessor.Instance.OnLocationParametersChanged += InstanceOnOnLocationParametersChanged;
        }

        private void InstanceOnOnLocationParametersChanged(object sender, LocationParameters locationParameters)
        {
            Id = locationParameters.Id;
            Range = locationParameters.Range;
            Timestamp = locationParameters.Timestamp;
            Delay = locationParameters.Delay;
        }

        #region Proporties

        private int _id;

        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
                RaisePropertyChanged(() => Id);
            }
        }

        private int _range;

        public int Range
        {
            get { return _range; }
            set
            {
                _range = value;
                RaisePropertyChanged(() => Range);
            }
        }

        private DateTime _timestamp;

        public DateTime Timestamp
        {
            get { return _timestamp; }
            set
            {
                _timestamp = value;
                RaisePropertyChanged(() => Timestamp);
            }
        }

        private int? _delay;

        public int? Delay
        {
            get { return _delay; }
            set
            {
                _delay = value;
                RaisePropertyChanged(() => Delay);
            }
        }

        #endregion

        #region Commands

        private ICommand _requestDataTimestampCommand;
        public ICommand RequestDataTimestampCommand => _requestDataTimestampCommand ?? (_requestDataTimestampCommand = new RelayCommand(RequestDataTimestampMethod));

        private ICommand _requestDataNoTimestampCommand;
        public ICommand RequestDataNoTimestampCommand => _requestDataNoTimestampCommand ?? (_requestDataNoTimestampCommand = new RelayCommand(RequestDataNoTimestampMethod));

        #endregion

        #region Adapters

        private readonly ILocationProvider _locationProvider;

        #endregion

        #region Methods

        private async void RequestDataTimestampMethod()
        {
            var response = await _locationProvider.RequestLocationData(new RequestLocation() {RequestDateTime = DateTime.Now});

            await LocationProcessor.Instance.GetLocatonData(response);
        }

        private async void RequestDataNoTimestampMethod()
        {
            var response = await _locationProvider.RequestLocationData(null);

            await LocationProcessor.Instance.GetLocatonData(response);
        }

        #endregion
    }
}

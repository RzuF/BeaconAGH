using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BeaconAGH.Models;

namespace BeaconAGH.BL.LocationProcessor
{
    public class LocationProcessor
    {
        #region Singleton

        private static LocationProcessor _instance;
        public static LocationProcessor Instance => _instance ?? (_instance = new LocationProcessor());

        #endregion

        #region Events

        public event EventHandler<LocationParameters> OnLocationParametersChanged;

        #endregion

        public async Task GetLocatonData(ResponseLocation response)
        {
            OnLocationParametersChanged?.Invoke(this, new LocationParameters());
        }
    }
}

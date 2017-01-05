﻿using System;
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
        #region Private Variables

        private int _id = 0;

        #endregion

        #region Singleton

        private static LocationProcessor _instance;
        public static LocationProcessor Instance => _instance ?? (_instance = new LocationProcessor());

        #endregion

        #region Events

        public event EventHandler<LocationParameters> OnLocationParametersChanged;

        #endregion

        public async Task GetLocatonData(ResponseLocation response)
        {
            OnLocationParametersChanged?.Invoke(this, new LocationParameters()
            {
                Id = _id++,
                Timestamp = response.ResponseDateTime,
                Range = response.Range,
                Delay = (response.RequestDateTime != null ? (int)response.ResponseDateTime.Subtract(response.RequestDateTime.Value).TotalMilliseconds : (int?)null)
            });
        }
    }
}

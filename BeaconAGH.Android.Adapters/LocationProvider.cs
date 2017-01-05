using System;
using System.Threading.Tasks;
using BeaconAGH.Adapters;
using BeaconAGH.Models;

namespace BeaconAGH.Android.Adapters
{
    public class LocationProvider : ILocationProvider
    {
        public async Task<ResponseLocation> RequestLocationData(RequestLocation requestLocation)
        {
            var rand = new Random();

            await Task.Delay(rand.Next(100) + 1000);

            var now = DateTime.Now;

            return new ResponseLocation()
            {
                RequestDateTime = requestLocation?.RequestDateTime,
                Range = rand.Next(100),
                ResponseDateTime = now
            };
        }
    }
}
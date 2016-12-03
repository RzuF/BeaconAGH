using BeaconAGH.Models;

namespace BeaconAGH.Adapters
{
    public interface ILocationProvider
    {
        ResponseLocation RequestLocationData(RequestLocation requestLocation);
    }
}

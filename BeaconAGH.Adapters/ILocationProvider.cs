using System.Threading.Tasks;
using BeaconAGH.Models;

namespace BeaconAGH.Adapters
{
    public interface ILocationProvider
    {
        Task<ResponseLocation> RequestLocationData(RequestLocation requestLocation);
    }
}

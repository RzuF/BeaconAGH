using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeaconAGH.Models
{
    public class LocationParameters
    {
        public int Id { get; set; }
        public int Range { get; set; }
        public DateTime Timestamp { get; set; }
        public int? Delay { get; set; }
    }
}

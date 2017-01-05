using System;

namespace BeaconAGH.Models
{
    public class ResponseLocation
    {        
        public int Range { get; set; }
        public DateTime ResponseDateTime { get; set; }
        public DateTime? RequestDateTime { get; set; }
    }
}

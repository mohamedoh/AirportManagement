using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Flight
    {
        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public int EstimatedDuration { get; set; }
        public Plane MyPlane { get; set; }
        public ICollection<Passenger>  Passengers { get; set; }
        public override string ToString()
        {
            return base.ToString + "{Destination " + Destination + "Departure " + Departure + "FlightDate " + FlightDate + "FlightId " + FlightId + "EffectiveArrival  "+ EffectiveArrival + "EstimatedDuration " + EstimatedDuration + "Plane " + MyPlane + "}";
        }
    }
}

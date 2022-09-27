using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public enum PlaneType
    {
        Boing =0 ,
        Airbus = 1 ,
    }
    public class Plane
    {
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType MyPlaneType { get; set; }
        public ICollection<Flight> Flights { get; set; }

        public override string ToString()
        {
            return base.ToString + "{Capacity" + Capacity + "ManufactureDate " + ManufactureDate + "PlaneId" + PlaneId + "PlaneType" + MyPlaneType + "}";
        }
        public Plane()
        {

        }
        public Plane(int capacity, PlaneType pt, DateTime date)
        {
            MyPlaneType = pt;
            Capacity = capacity;
            ManufactureDate = date;
            
        }
    }
}

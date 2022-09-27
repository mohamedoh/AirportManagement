using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.Core.Domain
{
    public class Passenger
    {
        public static DateTime BirthDate { get; set; }
        public string PassportNumber { get; set; }
        public string EmailAdress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelNumber { get; set; }

        public readonly int Age = (int)(DateTime.Now.Year) - (int)(BirthDate.Year);


        public ICollection<Flight> Flights { get; set; }


        public override string ToString()
        {
            return base.ToString + "{BrithDate " + BirthDate + "PassportNumber " 
                + PassportNumber + "EmailAdress" + EmailAdress + "FirstName" + FirstName + "}"
                ;
        }
       
        public bool CheckProfile(string FirstName,string LastName, string EmailAdress = null)
        {
            return FirstName == this.FirstName && LastName == this.LastName
                && (EmailAdress == null || EmailAdress == this.EmailAdress);

        }

        public virtual string GetPassengerType()
        {
            return "I'm a Passenger";
        }
        public void GetAge(DateTime BirthDate,ref int calculatedAge)
        {
            calculatedAge = (int)(DateTime.Now.Year) - (int)(BirthDate.Year);
        
        }

        /*public void GetAge( Passenger aPassenger)
        {
            aPassenger.Age = (int)(DateTime.Now.Year) - (int)(aPassenger.BirthDate.Year);
        }*/
    }

}

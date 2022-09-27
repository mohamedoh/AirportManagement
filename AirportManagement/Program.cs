// See https://aka.ms/new-console-template for more information
using AM.Core.Domain;
using System.ComponentModel;

Flight fl = new Flight();
Console.WriteLine(fl.ToString());
Plane plane = new Plane();
plane.Capacity = 200;
plane.ManufactureDate =DateTime.Now;
plane.MyPlaneType =0;
Plane plane1 = new Plane(150, PlaneType.Boing, new DateTime(2015,08,09));
Plane plane2 = new Plane() { Capacity = 200, ManufactureDate=new DateTime(2000,01,01), MyPlaneType=PlaneType.Airbus };  
// teste qst 12

Passenger Passenger = new Passenger();
Traveller Traveller = new Traveller();
Staff Staff = new Staff();
Console.WriteLine(Passenger.GetPassengerType());
Console.WriteLine(Traveller.GetPassengerType());
Console.WriteLine(Staff.GetPassengerType());

//teste qst 13
Passenger p = new Passenger();
DateTime B = new DateTime(2015, 08, 09);
int calculatedAge = 0;
p.GetAge(B, ref calculatedAge);
Console.WriteLine(calculatedAge);
Passenger p1 = new Passenger();
p1.BirthDate = new DateTime(2015, 08, 09);
p1.GetAge(p1);
Console.WriteLine(p1.age);

//ref https://learn.microsoft.com/fr-fr/docs/ && https://stackoverflow.com/
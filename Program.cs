using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_class_dan_object
{
    class Program
    {
        static void Main(string[] args)
        {
            //membuat objek dari class taxi
            taxi taxi = new taxi();

            taxi.DriverName = " Ahmad ";
            taxi.OnDuty =  true;
            taxi.NumPassenger =  10;
            
            taxi.TaxiInfo();
            taxi.PickUpPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}

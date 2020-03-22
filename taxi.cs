using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tugas_class_dan_object
{
    class taxi
    {
        public string DriverName;
        public bool OnDuty;
        public int NumPassenger;

        
        public void TaxiInfo()
        {
            Console.WriteLine(" ================================");
            Console.WriteLine(" | Driver Name         : {0}| ", DriverName);
            if (OnDuty == true)
            {
                Console.WriteLine(" | On Duty             :  Yes   |");
            }
            Console.WriteLine(" | Number Of Passenger :  {0}    | ", NumPassenger);
            Console.WriteLine(" ================================");

        }

        public void PickUpPassenger()
        {
            Console.WriteLine(" ");
            Console.WriteLine("{0}sedang menjemput penumpang", DriverName);
        }
        public void DropOffPassenger()
        {
            Console.WriteLine("{0}selesai mengantar penumpang", DriverName);
        }
    }
}

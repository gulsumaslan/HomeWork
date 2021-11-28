using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Car: IVehicles
    {
        public int stop { get; set; }
        public string wiper { get; set; }


        public void Drive(int stop=7)
        {
            Console.WriteLine(stop);
        }
        public void Run()
        {
            Console.WriteLine(wiper = "cam sileceği" ); ;
        }
    }
}

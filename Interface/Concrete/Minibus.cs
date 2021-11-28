using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class Minibus : IVehicles
    {
        public int numberofseats { get; set; }
        public string wiper { get ; set ; }
        public int stop { get ; set; }

        public void Run()
        {
            Console.WriteLine("koltuk sayısı"+ numberofseats);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class MotorCycle: IVehicles
    {
        public int stop { get; set; }
        public int İkiTekerlek { get; set; }
        

        public void Run()
        {
            Console.WriteLine("motorsiklet"+İkiTekerlek +stop);
        }
    }
}

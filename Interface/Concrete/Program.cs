using System;
using System.Collections.Generic;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car();
            //car.stop = 5;
            //car.wiper = "cam sileceği";

            //MotorCycle motor = new MotorCycle();
            //motor.İkiTekerlek = 2;
            //motor.stop = 5;

            //Minibus minibus = new Minibus();
            //minibus.numberofseats = 24;


            //IVehicles[] vehicles = { car, motor, minibus };




            Car car = new Car() { stop = 1, wiper = "cam sileceği" };

            car.Drive();

            MotorCycle motor = new MotorCycle() { İkiTekerlek = 2, stop = 4, };


            Minibus minibus = new Minibus() { numberofseats = 4, stop = 6, wiper = "cam sileceği" };

            List<IVehicles> list = new List<IVehicles> { car, minibus, motor };

            //Car car1 = new Car();
            //car1.Drive(list);



            foreach (var x in list)
            {
                x.Run();


                }
            }
    }
}

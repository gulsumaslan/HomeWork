using System;
using System.Collections.Generic;
using System.Text;

namespace Kalitim
{
    class Deneme:Animals
    {
        public void Show(Animals animal)
        {
            animal.Age = 7;
            Console.WriteLine("hayvanın güncelleme yaşı :"+ animal.Age );
            
        }

        
    }
}

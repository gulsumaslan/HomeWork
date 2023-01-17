using System;
using System.Collections.Generic;
using System.Text;

namespace  ExtendsProject
{
    class Deneme:Animals
    {
        public void Show(Animals animal)
        {
            animal.Age = 7;
            Console.WriteLine("update age of the animal :"+ animal.Age );
            
        }

        
    }
}

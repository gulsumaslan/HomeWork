using System;

namespace ExtendsProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Birds birds = new Birds();
            birds.Age = 3;
            birds.Colors = "sari";
            birds.Flies = "uçar";
            birds.Name = "şaşkın";

            Dogs dogs = new Dogs();
            dogs.Age = 3;
            dogs.Colors = "siyah";
            dogs.Size = 100;
            dogs.Name = "çirkin";

            Cat cat = new Cat();
            cat.breed = "scotich";
            cat.Name = "sessiz";
            cat.Age = 12;
            cat.Colors = "gri";

            Deneme deneme = new Deneme();
            deneme.Show(birds);





        }
    }
}

using System;
using Module4.Classes;

namespace Module4
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Dog();
            animal1.Name = "Sparky";
            Console.WriteLine(animal1.Speak());

            Animal animal2 = new Bear();
            animal2.Name = "Teddy";
            Console.WriteLine(animal2.Speak());

            Animal animal3 = new Pig();
            animal3.Name = "Orton";
            Console.WriteLine(animal3.Speak());

            Animal animal4 = new Animal();
            animal4.Name = "Snoopy";
            Console.WriteLine(animal4.Speak());

        }
    }
}

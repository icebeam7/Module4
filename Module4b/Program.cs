using System;
using Module4b.Classes;

namespace Module4b
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal1 = new Dog();
            animal1.Name = "Sparky";
            Console.WriteLine(animal1.Speak());
            Console.WriteLine(animal1.Sleep());

            Dog dog = animal1 as Dog; //Casting
            dog.Eat();

            Animal animal2 = new Bear();
            animal2.Name = "Teddy";
            Console.WriteLine(animal2.Speak());

            Animal animal3 = new Pig();
            animal3.Name = "Orton";
            Console.WriteLine(animal3.Speak());

            // This is an error, can't create instance of Animal class
            /*
            Animal animal4 = new Animal();
            animal4.Name = "Snoopy";
            Console.WriteLine(animal4.Speak());
            */
        }
    }
}

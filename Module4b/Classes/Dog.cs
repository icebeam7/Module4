using System;
using System.Collections.Generic;
using System.Text;

namespace Module4b.Classes
{
    public class Dog : Animal
    {
        public void Play(int x)
        {
            Console.WriteLine("You played with the dog for " + x + " hours");
        }

        public override string Speak()
        {
            return "Woof!";
        }

        public void Eat()
        {
            Console.WriteLine("The dog is eating");
            string sound = base.Sleep(); // Calling a method from the parent class

            Console.WriteLine("The dog is now sleeping: " + sound);
        }



    }
}

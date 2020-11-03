using System;
using System.Collections.Generic;
using System.Text;

namespace Module4.Classes
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
    }
}

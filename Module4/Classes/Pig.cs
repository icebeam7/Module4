using System;
using System.Collections.Generic;
using System.Text;

namespace Module4.Classes
{
    public class Pig : Animal
    {
        public override string Speak()
        {
            string pigSound = "Oink";
            string animalSound = base.Speak();

            return pigSound + " " + animalSound;
        }

    }
}

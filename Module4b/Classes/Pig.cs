using System;
using System.Collections.Generic;
using System.Text;

namespace Module4b.Classes
{
    public class Pig : Animal
    {
        public override string Speak()
        {
            string pigSound = "Oink";
            //string animalSound = base.Speak(); // base.Speak is not accessible/defined

            //return pigSound + " " + animalSound;
            return pigSound;
        }

    }
}

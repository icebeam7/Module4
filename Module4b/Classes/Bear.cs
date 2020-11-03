using System;
using System.Collections.Generic;
using System.Text;

namespace Module4b.Classes
{
    public class Bear : Animal
    {
        public bool Hunt()
        {
            return true;
        }

        public override string Speak()
        {
            return "GRRRRRRRR!!!!";
        }
    }
}

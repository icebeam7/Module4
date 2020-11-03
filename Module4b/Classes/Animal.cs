using System;
using System.Collections.Generic;
using System.Text;

namespace Module4b.Classes
{
    public abstract class Animal
    {
        public string Name;

        public abstract string Speak();
        
        public string Sleep()
        {
            return "Zzzzzz";
        }

    }
}

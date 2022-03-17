using System;
using System.Collections.Generic;
using System.Text;

namespace AP204_Polymorphism_Abstract
{
    class Animal
    {
        public string Sort;
        public virtual void Sound()
        {
            Console.WriteLine("Animal make sound");
        }
    }
}

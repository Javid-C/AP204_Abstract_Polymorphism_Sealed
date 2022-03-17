using System;
using System.Collections.Generic;
using System.Text;

namespace AP204_Polymorphism_Abstract
{
    abstract class Human
    {
        public string Name;
        public string Surname;
        public byte Age;
        public string Gender;
        public abstract int Iq { get; set; }

        public Human(string name, string surname, string gender, byte age, int iq)
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            Age = age;
            Iq = iq;
        }

        public abstract void Sleep();

        public abstract void Eat();

    }
}

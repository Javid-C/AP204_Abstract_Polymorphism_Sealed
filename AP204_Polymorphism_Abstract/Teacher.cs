using System;
using System.Collections.Generic;
using System.Text;

namespace AP204_Polymorphism_Abstract
{
    class Teacher : Human
    {
        public string Profession;
        private int _iq;
        public Teacher(string name, string surname, string gender, byte age, string profession,int iq) : base(name, surname, gender, age,iq)
        {
            Profession = profession;
        }

        public override int Iq
        {

            get => _iq;

            set
            {
                if(value > 120)
                {
                    _iq = value;
                }
            }
        }

        public override void Eat()
        {
            Console.WriteLine("Meat");
        }

        public override void Sleep()
        {
            Console.WriteLine("6 hours");
        }

        // abstract olmayan bir classda abstract bir method ola bilmez

        //public abstract void Test();
    }
}

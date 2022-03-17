using System;
using System.Collections.Generic;
using System.Text;

namespace AP204_Polymorphism_Abstract
{
    class Student : Human
    {
        public byte Point;
        public string GroupNo;
        private int _iq;
        public Student(string name, string surname, string gender, byte age, byte point, string no,int iq) : base(name, surname, gender, age,iq)
        {
            Point = point;
            GroupNo = no;
        }

        public override int Iq
        {

            //get
            //{
            //    return _iq;
            //}
            get => _iq;

            set
            {
                if (value > 100)
                {
                    _iq = value;
                }
            }
        }

        public override void Eat()
        {
            Console.WriteLine("Pasta");
        }

        public override void Sleep()
        {
            Console.WriteLine("4 hours");
        }

        public override string ToString()
        {
            return $"Bu bir studentdir";
        }
    }
}

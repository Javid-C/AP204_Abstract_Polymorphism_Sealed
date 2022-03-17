using System;
using System.Collections.Generic;
using System.Text;

namespace AP204_Polymorphism_Abstract
{
    class Employee
    {
        //public double Salary;

        public virtual void Salary()
        {
            Console.WriteLine("Salary");
        }
    }
}

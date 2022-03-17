using System;
using System.Collections.Generic;
using System.Text;

namespace AP204_Polymorphism_Abstract
{
    class Intern:Employee
    {
        public override sealed void Salary()
        {
            Console.WriteLine("None");
        }
    }
}

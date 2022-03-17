using System;
using System.Collections.Generic;
using System.Text;

namespace AP204_Polymorphism_Abstract
{
    class Engineer:Employee
    {

        public  override void Salary()
        {
            Console.WriteLine("Engineer salary");
        }
    }
}

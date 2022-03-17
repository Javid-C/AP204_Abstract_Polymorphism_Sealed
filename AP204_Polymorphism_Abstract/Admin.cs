using System;
using System.Collections.Generic;
using System.Text;

namespace AP204_Polymorphism_Abstract
{
    class Admin : User
    {
        public string Section;
        public bool isSuperAdmin;

        public Admin(string username, string pw, string section, bool issuperadmin) : base(username, pw)
        {
            Section = section;
            isSuperAdmin = issuperadmin;
        }

        public void Info()
        {
            Console.WriteLine($"Username: {Username}, Password: {Password}, Section: {Section}, {(isSuperAdmin ? "Super admindir" : "Super admin deyil")} ");
        }
    }
}

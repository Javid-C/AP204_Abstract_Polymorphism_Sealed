using System;
using System.Collections.Generic;
using System.Text;

namespace AP204_Polymorphism_Abstract
{
    class User
    {
        private string _username;
        private string _password;

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (value.Length > 6)
                {
                    _username = value;
                }
                else
                {
                    Console.WriteLine("Username uzunlugu minimum 7 olmalidir");
                }
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (CheckPassword(value))
                {
                    _password = value;
                }
                else
                {
                    Console.WriteLine("Password duzgun teyin edilmedi");
                }
            }
        }

        public User(string username, string pw)
        {
            Username = username;
            Password = pw;
        }


        public bool CheckPassword(string pw)
        {
            if (pw.Length >= 8)
            {
                bool hasDigit = false;
                bool hasUpper = false;
                bool hasLower = false;

                foreach (char letter in pw)
                {
                    if (char.IsDigit(letter))
                    {
                        hasDigit = true;
                        continue;
                    }
                    if (char.IsUpper(letter))
                    {
                        hasUpper = true;
                        continue;
                    }
                    if (char.IsLower(letter))
                    {
                        hasLower = true;
                    }
                }

                bool result = hasDigit && hasUpper && hasLower;
                return result;

            }
            return false;
        }
    }
}

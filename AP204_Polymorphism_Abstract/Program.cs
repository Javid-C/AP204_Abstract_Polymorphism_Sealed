using System;

namespace AP204_Polymorphism_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Home work

            //string pw;
            //string username;

            ////Admin admin1 = new Admin("javid","javid","slider",true);

            //do
            //{
            //    Console.WriteLine("Zehmet olmasa username daxil edin:");

            //    username = Console.ReadLine();

            //} while (!(username.Length>6));

            //do
            //{
            //    Console.WriteLine("Zehmet olmasa parol daxil edin:");

            //    pw = Console.ReadLine();
            //} while (!CheckPassword(pw));

            //Console.WriteLine("Zehmet olmasa section secin:");

            //string section = Console.ReadLine();

            //Console.WriteLine("Super admindirmi?  y/n");
            //bool isSuperAdmin = false;
            //string superAdmin = Console.ReadLine();
            //if (superAdmin.ToLower().Trim() == "y")
            //{
            //    isSuperAdmin = true;
            //}

            //Admin admin = new Admin(username,pw,section,isSuperAdmin);

            //admin.Info();
            #endregion


            #region Polymorphism

            //Animal animal = new Animal();
            //animal.Sound();

            //Eagle eagle = new Eagle();
            //eagle.Sound();

            //Shark shark = new Shark();
            //shark.Sound();


            //Student student = new Student("Fatima", "Hasanzade");

            //Console.WriteLine(student);
            #endregion


            Teacher teacher = new Teacher("Javid","Asadullayev","Male",24,"Programming",119);

            teacher.Sleep();

            Console.WriteLine(teacher);

            Engineer engineer = new Engineer();

            engineer.Salary();


        }
        public static bool CheckPassword(string pw)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7FeaturesConsoleAppVS2017
{
    class refPrac2
    {
        static void Main(string[] args)
        {


            int empid;

            do
            {
                Console.WriteLine("Enter the Emp id 1 or 2. Type 0 to exit");

                int.TryParse(Console.ReadLine(), out empid);
                string empname = EmpDetailsById(empid, out string desig, out int sal, out int bonus);

                Console.WriteLine($"The details are");
                Console.WriteLine($"Name={empname}, {desig}, {sal}, {bonus}");
               
            } while (empid != 0);
             
        }

        public static string EmpDetailsById(int id, out string designation, out int salary, out int bonus)
        {
            string employeeName=String.Empty;
            designation = "test";
            salary = 0;
            bonus = 0;

            if (id == 1) {
                employeeName = "XYZ manager";
                designation = "Manager";
                salary = 10000;
                bonus = 500;
            }
            if (id == 2)
            {
                employeeName = "ABC manager";
                designation = "Employee";
                salary = 5000;
                bonus = 250;
            }

            return employeeName;

        }
    }
}

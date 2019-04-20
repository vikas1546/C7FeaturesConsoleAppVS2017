using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7FeaturesConsoleAppVS2017
{
    class refPrac
    {
        static void Main(string[] args)
        {
            int fine = 500;
            // int sal = 0;
            //  GetSalary(1, 200,ref sal);
            int c = 0;
           ref int sal = ref GetSalary(1, 200,   ref c );
            Console.WriteLine(sal);
            Console.WriteLine(sal - fine);
            Console.WriteLine(sal);
            Console.ReadLine();
        }

        public static  ref int  GetSalary(int empcode, int bonus, ref int s)
        {
              int sal = 10000 + bonus;
            s = sal;
            return  ref s;
            
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7FeaturesConsoleAppVS2017
{
    class LocalFunctions
    {
        //private void AddNumbers(int a, int b)
        //{
        //    Console.WriteLine(a + b);
        //}

        static void Main()
        {
            void AddNumbers(int a, int b)
            {
                Console.WriteLine(a + b);
            }

            // LocalFunctions obj = new LocalFunctions(); // no need to create instance coz function is local now.
            AddNumbers(100, 25);



            // in local functions, we can use ref, out, and generics, but they are not allowed in Anonymous functions
            void AddNumbers2(int a, int b, ref int c, ref int d)
            {
                c = a + b;
                d = a * b;
            }

            //below using ref variables. we have to declare the ref variables
            int x = 0, y = 0;
            AddNumbers2(100, 25, ref x, ref y);
            Console.WriteLine("The value of x and y using ref variable is =" + x + "  " + y);

            // below using out variables.
            void AddNumbers3(int a, int b, out int c, out int d)
            {
                c = a + b;
                d = a * b;
            }
            // for below, we dont have to declare the out variables
            AddNumbers3(100, 25, out int p, out int q);
            Console.WriteLine("The value of p and q using out variables is " + p + "   " + q);


            void AddNumbers4(params int[] myarr)
            {
                int Sum = 0;
                foreach (int i in myarr)
                {
                    Sum += i;
                }

                Console.WriteLine("The sum of given numbers using params parameter is " + Sum);
            }

            AddNumbers4(10, 20, 30, 40, 50);

            //creating generic methods as local methods.
            void AddNumbers5<T>(T a, T b)
            {
                dynamic d1 = a;
                dynamic d2 = b;
                if(d1 is int)
                Console.WriteLine("Using Generic Addnumbers5 =" + (d1 + d2));
                else
                    Console.WriteLine("Using Generic Addnumbers5 (string args) =" + (d1 + d2));
            }
            AddNumbers5(2,3);      //or AddNumbers5<int>(4,5);
            AddNumbers5("Vikas", "Sharma");  //string args




            Console.ReadLine();
        }


    }
}

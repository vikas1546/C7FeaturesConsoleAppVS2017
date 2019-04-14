using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7FeaturesConsoleAppVS2017
{
    class Tuples
    {
        static void Main()
        {
            TupleExample1();
            TupleExample2();
            TupleExample3();
            Console.ReadLine();
        }

        private static void TupleExample1()
        {
            List<int> numberslist = new List<int> { 3, 5, 11, 4, 7 };
            var result = GetLowestHighest(numberslist);

            Console.WriteLine(result.Item1); // ugly?
            Console.WriteLine(result.Item2); // yeah, ugly..
           
        }

        private static (int, int) GetLowestHighest(IReadOnlyCollection<int> numbers)
        {
            int lowest = numbers.Min(n => n);
            int highest = numbers.Max(n => n);
            return (lowest, highest);
        }


         private static void TupleExample2()
        {
            Tuple<int, int> obj = Math1(25, 100);
            Console.WriteLine("Output from Example2= " + obj.Item1 + " ---" + obj.Item2);
        }
        public static Tuple<int, int> Math1(int a, int b)
        {
            int c = a + b;
            int d = a * b;
            Tuple<int, int> mytuple = Tuple.Create(c, d);
            return mytuple;
        }


        private static Tuple<int, int> GetSumAndProduct_1(int a, int b)
        {
            return Tuple.Create(a + b, a * b);
             //Console.WriteLine("Output from Example2= " + obj.Item1 + " ---" + obj.Item2); 
        }

        private static (int Sum, int Product) GetSumAndProduct_2(int a, int b)
        {
            return (a + b, a * b);
            //Console.WriteLine("Output from Example2= " + obj.Item1 + " ---" + obj.Item2); 
        }
        private static void TupleExample3()
        {
            var tp = GetSumAndProduct_1(20, 40);
            Console.WriteLine("Output from Example3_1= " + tp.Item1 + " ---" + tp.Item2);

            var res = GetSumAndProduct_2(20, 40);
            Console.WriteLine("Output from Example3_2= " + res.Sum + " ---" + res.Product);

            (int s, int p) = GetSumAndProduct_2(20, 40);
            Console.WriteLine($"The sum is {s} and the Product is {p}");

            var (_sum,_product) = GetSumAndProduct_2(20, 40);
            Console.WriteLine($"The sum is {_sum} and the Product is {_product}");


            var myself = (name:"vikas sharma", job:"Sr.Software Engineer");
            Console.WriteLine($"The name is {myself.name} and the Job is {myself.job}");
            Console.WriteLine(myself.GetType());

            //A tuple can be defined and used anywhere within the Expression. for eg below
            var tnp = new Func<double, double, (double sum, double product)>((no1, no2) => (no1 + no2, no1 * no2));
            var result = tnp(10, 20);
            Console.WriteLine($"Sum is ={result.sum} and Product is ={result.product}");
        }

        

    }
}

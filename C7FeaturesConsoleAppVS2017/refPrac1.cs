using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7FeaturesConsoleAppVS2017
{
    class refPrac1
    {
        static void Main(string[] args)
        {
            int[] numbers = {1,2,3,4,5,6,7,8,9,10 };
            ref int item = ref GiveMeNumberatIndex(numbers, 2);
            Console.WriteLine($"The Item at above index 2 is = {item}");
            item = 100;
            Console.WriteLine($"The modified item now is= {numbers[2]}");
            Console.WriteLine($"The modified array is=" + String.Join(", ", numbers));
            Console.ReadLine();

        }

        public static ref int GiveMeNumberatIndex(int[] myarray, int index)
        {
            return ref myarray[index];
        }
    }
}

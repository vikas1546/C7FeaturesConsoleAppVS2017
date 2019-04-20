using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C7FeaturesConsoleAppVS2017
{
    public class refLocalrefReturnsDemo
    {
        static void Main(string[] args)
        {
            string[] speakersArray = { "Mahesh", "Suresh", "vikas", "Ganesh", "Dinesh" };
            //define a ref local variable like below
            // ref string speaker = ref speakersArray[2];  //it stores the reference of the second item. vikas gets stored
            ref string speaker = ref FindSpeaker(speakersArray, "Ganesh");
            // now we update the value of the ref local variable. It will update the speakersArray also.
            speaker += " Sharma";
            Console.WriteLine("Speaker Name is =" + speaker);
            Console.WriteLine("Speaker Array is= \n" + String.Join(",", speakersArray)); // 

            //CTM:
            //for ref variable, Once the reference of the variable is assigned, thereafter we can not assign/bind that
            // ref varible to another element. 
            //ref-reassignment is possible only in C#7.3 onwards.
            //eg.below statement will cause error in C#7.0
            // speaker = ref speakersArray[1];

            //Also the concept of ref local variables can not be used with Collections, Lists,Generics, or any complex types. 
            // for eg. below code will cause error
            //  List<string> authorsArray = new List<string>() { "Mahesh", "Suresh", "vikas", "Ganesh", "Dinesh" };
            // ref string author = ref authorsArray[2];

            //Another feature of ref local variables is that,  once the ref has been set to the local variable, and then if any 
            // changes happens to the original data, then still the reference variable will work properly. 
            // eg. below, lets resize the original speakers array to limit to one element only,

            Array.Resize(ref speakersArray, 1); // original speakersArray has been updated to one element.
            //now lets update the value of the ref local variable.
            speaker = "The new speaker";
            Console.WriteLine("Speaker Name is =" + speaker);
            Console.WriteLine("Speaker Array is= \n" + String.Join(",", speakersArray));


            Console.ReadLine();
        }

       public static ref string FindSpeaker(string[] speakersArray, string speaker)
        {
            // below code to verify that a given speaker exists in the speakers array.
            for (int i = 0; i < speakersArray.Length; i++)
            {
                if (speakersArray[i].Equals(speaker))
                    return ref speakersArray[i];
            }

            // if the speaker does not exists in the array, then throw an exception coz below is not possible 
            //coz the string passed "Speaker Not Found" is a value type but we need a reference type to return.
            //return ref "Speaker Not Found";
            // so the best solution is to throw an exception.
            throw new Exception("Speaker Not Found");
        } 

    }
}
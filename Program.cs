using System;
using System.Runtime.CompilerServices;

namespace Excersize_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //if statements

            Console.WriteLine();
            int age = int.Parse(Console.ReadLine());

            if(age >= 18)
            {
                Console.WriteLine("You are old enough to enter.");
            }


           
            Console.WriteLine(Convert.ToString(age));    // convert int to string

            Console.WriteLine(Convert.ToDouble(age));    // convert int to double
            Console.WriteLine(Convert.ToInt32(age));  // convert double to int
            Console.WriteLine(Convert.ToString(age));   // convert bool to string
            
        }
    }
}

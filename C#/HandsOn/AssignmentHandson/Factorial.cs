using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentHandson
{
    internal class Factorial
    {
        static void Main()
        {
            Console.WriteLine("Enter Number to be checked : ");
            int readNumber = int.Parse(Console.ReadLine());
            Int64 fact = 1;
            for(int i=readNumber;i>=1;i--)
            {
                fact *= i;
            }
            Console.WriteLine($"Factorial of {readNumber} is {fact}");


            /*for(int i=1;i<=Math.Sqrt(readNumber);i++)
            {
                if (readNumber % i == 0)
                    Console.WriteLine($"{i} ");
            }*/
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentHandson
{
    internal class OddEven
    {
        static void Main()
        {
            Console.WriteLine("Enter Number to be checked : ");
            int readNumber = int.Parse(Console.ReadLine());
            if (readNumber % 2 == 0)
                Console.WriteLine($"{readNumber} is Even Number");
            else
                Console.WriteLine($"{readNumber} is Odd Number");
        }
    }
}

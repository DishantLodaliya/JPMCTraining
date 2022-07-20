using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentHandson
{
    internal class MaxThree
    {
        static void Main()
        {
            int a, b, c;
            Console.WriteLine($"Enter Three Numbers");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (a > b && a > c)
                Console.WriteLine($"{a} is Largest Number");
            else if (b>c)
                Console.WriteLine($"{b} is Largest Number");
            else
                Console.WriteLine($"{c} is Largest Number");
        }
    }
}

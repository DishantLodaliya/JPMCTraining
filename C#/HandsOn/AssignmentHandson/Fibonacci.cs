using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentHandson
{
    internal class Fibonacci
    {
        static void Main()
        {
            int end = 40;
            Console.WriteLine($"Fibonacci Series upto {end} are : ");
            int a=0, b=1;
            Console.WriteLine($"{a}");
            while(a<end)
            {
                int temp = b;
                b = a + b;
                a = temp;
                if(a<end)
                Console.WriteLine($"{a} ");
            }
      
        }
    }
}

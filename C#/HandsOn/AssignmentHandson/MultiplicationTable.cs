using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentHandson
{
    internal class MultiplicationTable
    {
        static void Main()
        {
            int tableNumber = 7, rangeNumber = 20;
            Console.WriteLine($"Multiplication Table of {tableNumber} : ");
            for (int i = 1; i <= rangeNumber; i++)
            {
                Console.WriteLine($"{tableNumber} x {i} = {i * tableNumber}");
            }

        }
    }
}

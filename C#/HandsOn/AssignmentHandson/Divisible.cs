using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentHandson
{
    internal class Divisible
    {
        static void Main()
        {
            int startRange = 200, endRange = 300, divideBy = 7;
            Console.WriteLine($"Numbers divisible by {divideBy} between {startRange} and {endRange} are :");
            for(int i=(1+(startRange/divideBy))*divideBy;i<=endRange;i+=divideBy)
                Console.WriteLine($" {i}");
        }
    }
}

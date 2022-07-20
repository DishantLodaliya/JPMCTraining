using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentHandson
{
    internal class DisplayRange
    {
        static void Main()
        {
            Console.WriteLine("Enter Range for Numbers to be Printed on Screen");
            int startRange, endRange;
            startRange = int.Parse(Console.ReadLine());
            endRange = int.Parse(Console.ReadLine());

            Console.WriteLine("Numbers in the Range are : ");
            for(int i=startRange;i<=endRange;i++)
                Console.Write(" "+i);
        }
    }
}

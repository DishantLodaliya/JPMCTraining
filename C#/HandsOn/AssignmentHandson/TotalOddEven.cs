using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentHandson
{
    internal class TotalOddEven
    {
        static void Main()
        {
            Console.WriteLine("Enter As Many Numbers to count for Odd Even (777 to Terminate) : ");
            int oddCount = 0;
            int evenCount = 0;
            int readNumber;
            do
            {
                readNumber = int.Parse(Console.ReadLine());
                if (readNumber % 2 == 0)
                    evenCount++;
                else
                    oddCount++;

            } while (readNumber != 777);
            Console.WriteLine($"Total Odd Counts : {oddCount-1} \n Total Even Counts : {evenCount}");
        }
    }
}

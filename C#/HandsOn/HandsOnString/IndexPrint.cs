using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnString
{
    internal class IndexPrint
    {
        static void Main()
        {
            string str = "The quick brown fox jumps over the lazy dog";
            int index = 12;
            Console.WriteLine($"Character at {index}th Index is {str[index]}");
        }
    }
}

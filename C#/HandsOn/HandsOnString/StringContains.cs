using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnString
{
    internal class StringContains
    {
        static void Main()
        {
            string str = "The quick brown fox jumps over the lazy dog";
            string containsStr = "is";
            if(str.Contains(containsStr))
                Console.WriteLine($"String contains {containsStr}");
            else
                Console.WriteLine($"String does not contains {containsStr}");
        }
    }
}

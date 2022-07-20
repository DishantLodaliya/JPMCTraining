using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnString
{
    internal class StringEqual
    {
        static void Main()
        {
            string str = "The quick brown fox jumps over the lazy dog";
            string strCompare = "The quick brown fox jumps over the lazy dog";
            if (str.Equals(strCompare))
                Console.WriteLine($"Strings are Equal");
            else
                Console.WriteLine($"Strings are not Equal");
        }
    }
}

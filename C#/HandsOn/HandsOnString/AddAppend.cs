using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnString
{
    internal class AddAppend
    {
        static void Main()
        {
            string str = "The quick brown fox jumps over the lazy dog";
            string appendString = " and killed it";
            string apdString = str + appendString;
            Console.WriteLine($"String after appending : \n{apdString}");
        }
    }
}

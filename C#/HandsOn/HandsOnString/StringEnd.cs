using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnString
{
    internal class StringEnd
    {
        static void Main()
        {
            string str = "The quick brown fox jumps over the lazy dog";
            string stringEnds = "dog";
            if (str.EndsWith(stringEnds))
                Console.WriteLine($"String Ends with {stringEnds}");
            else
                Console.WriteLine($"String does not Ends With {stringEnds}");
        }
    }
}

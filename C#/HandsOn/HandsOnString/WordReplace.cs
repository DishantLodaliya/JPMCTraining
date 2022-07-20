using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnString
{
    internal class WordReplace
    {
        static void Main()
        {
            string str = "The quick brown fox jumps over the lazy dog";
            string replaceSrc = "The";
            string replaceDst = "A";
            string replacedStr = str.Replace(replaceSrc, replaceDst);
            Console.WriteLine($"{str}\n\n After Replacing {replaceSrc} with {replaceDst} :\n{replacedStr}");
        }
    }
}

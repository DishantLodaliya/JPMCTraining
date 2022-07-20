using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentHandson
{
    internal class GreetUser
    {
        static void Main()
        {
            Console.WriteLine("May I Know Your Name Please?");
            string readName = Console.ReadLine();
            Console.WriteLine($"Hi {readName}, Welcome to Tavisca, JPMC"); 
        }
    }
}

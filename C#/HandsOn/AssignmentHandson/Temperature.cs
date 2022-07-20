using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentHandson
{
    internal class Temperature
    {
        static void Main()
        {
            Console.WriteLine("May I Know Your Body Temperature in Fahrenhit Please?");
            double fahrenhitTemp = double.Parse(Console.ReadLine());
            double celciusTemp = (fahrenhitTemp - 32) * Convert.ToDouble(5.0 / 9.0);
            Console.WriteLine($"Your Temperature in Celcius is {celciusTemp}");
        }
    }
}

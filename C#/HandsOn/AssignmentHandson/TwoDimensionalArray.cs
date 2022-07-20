using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentHandson
{
    internal class TwoDimensionalArray
    {
        static void Main()
        {
            Console.WriteLine("Please Enter 3x3 Matrix Value");
            int[,] arr = new int[3, 3];
            for(int i=0;i<3;i++)
            {
                for(int j=0;j<3;j++)
                    arr[i,j] = int.Parse(Console.ReadLine());   
            }

            Console.WriteLine("Your Entered 3x3 Matrix is :");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(" " + arr[i, j]);
                Console.WriteLine();
            }
        }
    }
}

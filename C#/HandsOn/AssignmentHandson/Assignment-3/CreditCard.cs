using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentHandson.Assignment_3
{
    internal class CreditCard
    {
        static void Main()
        {
            Console.WriteLine("Enter The Total Amount");
            double totalAmount = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter The Monthly Amount");
            double monthlyAmount = double.Parse(Console.ReadLine());

            int month = 1;
            double remainAmount = totalAmount;
            double paid = 0;
            Console.WriteLine($"Month - 0 \n Remaining Amount : {remainAmount}\n Paid Amount : {paid}");
            while(remainAmount>=0)
            {
                remainAmount = (remainAmount * 1.015) - monthlyAmount;
                paid += monthlyAmount;

                Console.WriteLine($"Month - {month} \n Remaining Amount : {remainAmount}\n Paid Amount : {paid}");
                month++;

            }
        }
    }
}

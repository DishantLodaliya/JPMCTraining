using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentHandson
{
    internal class BankInterest
    {
        static void Main()
        {
            double amount, targetAmount, interest, years;
            Console.WriteLine("Enter the Amount you Have :");
            amount = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Interest Rate :");
            interest = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Target Amount :");
            targetAmount = double.Parse(Console.ReadLine());

            years = 0;
            double tempAmount = amount;
            while(tempAmount<targetAmount)
            {
                tempAmount = (tempAmount * (1 + (interest / 100)));
                years++;
            }
            Console.WriteLine($"You will have to wait for {years} to get {targetAmount}");
        }
    }
}

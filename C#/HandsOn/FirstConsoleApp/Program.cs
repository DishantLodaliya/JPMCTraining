using System;
namespace FirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("What is your Name ?");
            string readName = Console.ReadLine();
            Console.WriteLine("Hello {0}, Welcome to Tavisca JPMC" , readName);
            Console.WriteLine("{0}, What is your Birth Year?" , readName);
            int readYear = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} Your Near about age is {1}", readName, (2022 - readYear));
            Console.ReadKey();

            double doubleData = 5.6892;
            int intData = (int)doubleData;
            int intNewData = Convert.ToInt16(doubleData);

        }
    }
}

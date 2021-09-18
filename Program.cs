using System;

namespace ConsoleApp5_fi_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string n;
            Console.WriteLine("input number that you want to find and enter END to finish");
            do
            {
                n = Console.ReadLine();
            } while (n != "END");
            Console.WriteLine("  ");

            string find;
            Console.WriteLine("input the thing that you want to solve");
            find = Console.ReadLine();
            if (find == "FindMax")
            {
                Console.WriteLine("Max value is = " + Math.Max(n));
            }
            else if(find == "FindMin")
            {
                Console.WriteLine("Min value is = " + Math.Min(n));

            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prime_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the second number");
            int second = int.Parse(Console.ReadLine());
            for (int i = first; i <= second; i++)
            {
                int counter = 0;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                        break;
                    }
                }
                if (counter == 0 && i != 1)
                {
                    Console.WriteLine("The prime number is");
                    Console.WriteLine("{0}", i);
                }
                    Console.ReadKey();
            }



        }
    }
}

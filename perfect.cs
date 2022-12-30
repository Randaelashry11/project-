using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pleas enter n1");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Pleas enter n2");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("The perfect number is:");

            for (int i = n1; i <= n2; i++)
            {
                int j = 1;
                int sum = 0;
                 while(j < i)
                 {
                    if (i % j == 0)
                        sum = sum + j;
                    j++;
                 }
                if (sum == i)
               
                    Console.WriteLine("{0}", i);
            }
                            Console.ReadKey();




        }















    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            String s;
            int num;

            do
            {
                Console.WriteLine("Enter a number, foo.");
                s = Console.ReadLine();
                num = Convert.ToInt32(s);

                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine(fib(i));
                }

                Console.WriteLine("Continue? y or n");
                s = Console.ReadLine();
            } while (s != "n");
            




        }

        static int fib(int n)
        {

            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavd4
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Input number a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input number b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                int tmp = a;
                a = b;
                b = tmp;
            }

            for (int i = a; i <= b; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }

        }
    }
}

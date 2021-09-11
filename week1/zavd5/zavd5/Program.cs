using System;

namespace zavd5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            char[] numCharArr = num.ToString().ToCharArray();
            Array.Reverse(numCharArr);

            Console.WriteLine(numCharArr);
        }
    }
}

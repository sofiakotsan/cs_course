using System;

namespace zavd2
{
    class Program
    {
        static void Main(string[] args)
        {
            string ticketNumber = "";
            while (ticketNumber.Length != 6)
            {
                Console.Write("Enter a 6 digit numer: ");
                ticketNumber = Console.ReadLine();
            }

            int number = Convert.ToInt32(ticketNumber);

            int firstHalf = number / 1000;
            int secondHalf = number % 1000;
            int fitstHalfSum = (firstHalf / 100) + (firstHalf / 10 - (firstHalf / 100 * 10)) + (firstHalf % 10);
            int secondHalfSum = (secondHalf / 100) + (secondHalf / 10 - (secondHalf / 100 * 10)) + (secondHalf % 10);

            if (fitstHalfSum == secondHalfSum)
                Console.WriteLine("This is a lucky ticket.");
            else
                Console.WriteLine("This is not a lucky ticket.");

        }
    }
}
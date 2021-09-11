using System;

namespace zavd1
{
    class Program
    {
        static void Main(string[] args)
        {
            string finalStr = "";
            char buffer;

            Console.WriteLine("Input char: ");

            while (true)
            {
                buffer = Convert.ToChar(Console.Read());
                if (buffer == '.')
                    break;
                finalStr += buffer;
            }

            Console.WriteLine(finalStr);

            int spaceCounter = 0;
            for (int i = 0; i < finalStr.Length; i++)
                if (finalStr[i] == ' ')
                    ++spaceCounter;

            Console.WriteLine("Number of spaces: " + spaceCounter);

        }
    }
}

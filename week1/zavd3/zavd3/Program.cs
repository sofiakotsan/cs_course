using System;

namespace zavd3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.Write("Input a string: ");
            str = Console.ReadLine();

            char[] strArr =  str.ToCharArray();
            
            for (int i = 0; i < strArr.Length; i++)
            {
                if (char.IsLower(strArr[i]))
                    strArr[i] = char.ToUpper(strArr[i]);
                else if (char.IsUpper(strArr[i]))
                    strArr[i] = char.ToLower(strArr[i]);
            }

            Console.WriteLine(strArr);
        }
    }
}

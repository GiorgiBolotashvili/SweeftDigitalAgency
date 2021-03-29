using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter \"close\"  if you want to finish");
                Console.Write("Enter string: ");
                string name = Console.ReadLine();
                if (name == "close")
                    break;
                
                if (IsPalindrom(name))
                {
                    Console.WriteLine($"{name} is palindrom!");
                }
                else
                {
                    Console.WriteLine($"{name} is not palindrom!");
                }
                Console.WriteLine();
            }
        }
        static bool IsPalindrom(string text)
        {
            char[] array = text.ToCharArray();
            for (int i = 0; i < array.Length / 2; i++)
            {
                if (array[i] != array[^(1 + i)])
                {
                    return false;
                }
            }
            return true;
        }
    }
}

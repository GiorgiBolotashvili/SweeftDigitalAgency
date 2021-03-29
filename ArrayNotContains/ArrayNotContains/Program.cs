using System;

namespace ArrayNotContains
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testOne = { 10, 8, 7, 6, 5, 4, 3, 2, 1 };
            int[] testTwo = { 10, 9, 8, 7, 6, 5, 11, 4, 3, 2, 12, 13, 1 };
            int[] testThree = { 10, 9, 8, 7, 6, 5, 11, 4, 3, 2, 12, 13 };

            Console.WriteLine(NotContains(testOne));
            Console.WriteLine(NotContains(testTwo));
            Console.WriteLine(NotContains(testThree));
        }

        static int NotContains(int[] array)
        {
            int counter = 0;
            bool check = true;
            while (check)
            {
                check = false;
                counter++;
                for (int i = 0; i < array.Length; i++)
                {
                    if (counter == array[i])
                    {
                        check = true;
                    }
                }
            }
            return counter;
        }
    }
}

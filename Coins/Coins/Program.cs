using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"the amount minimal coins is {MinSplit(amount)}");
        }

        static int MinSplit(int amount)
        {
            int counter = 0, remainder = amount;
            int[] coins = { 50, 20, 10, 5 };
            for (int i = 0; i < coins.Length; i++)
            {
                counter += remainder / coins[i];
                remainder = remainder % coins[i];
            }
            counter += remainder;

            return counter;
        }
    }
}

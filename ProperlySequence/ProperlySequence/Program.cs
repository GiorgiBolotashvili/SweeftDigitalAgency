using System;

namespace ProperlySequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string testOne = "(1) This example (which was written this month (January))is intended to illustrate.";
            string testTwo = ")(1) This example (which was written this month (January))is intended to illustrate.";
            string testThree = "(11)(()))122((((()) ";
            Console.WriteLine(IsProperly(testOne));
            Console.WriteLine(IsProperly(testTwo));
            Console.WriteLine(IsProperly(testThree));
        }

        static bool IsProperly(string sequence)
        {
            int counter = 0;
            for (int i = 0; i < sequence.Length; i++)
            {
                if (sequence[i] == '(')
                    counter++;
                else if (sequence[i] == ')')
                    counter--;
                if (counter < 0)
                    return false;
            }
            if (counter == 0)
                return true;
            else
                return false;

        }
    }
}

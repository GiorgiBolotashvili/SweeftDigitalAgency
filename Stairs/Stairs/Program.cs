using System;

namespace Stairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int testOne = 3;
            int testTwo = 5;
            int testThree = 10;
            Console.WriteLine(countVariants(testOne));
            Console.WriteLine(countVariants(testTwo));
            Console.WriteLine(countVariants(testThree));
        }

        private static int countVariants(int stairsCount)
        {

            int oneStep = stairsCount, twoStep = 0, counter = 0;
            while (oneStep >= 0 && twoStep <= stairsCount)
            {
                if (oneStep == 0 || twoStep == 0)
                {
                    counter++;
                }
                else if (twoStep == 2)
                {
                    counter += stairsCount - 1;
                }
                else if (twoStep > 2)
                {
                   SumVarStep(oneStep, twoStep, ref counter);
                }
                oneStep -= 2;
                twoStep += 2;
            }

            return counter;
        }

        private static void SumVarStep(int step, int twoStep, ref int count)
        {
            if (twoStep>4)
            {
                twoStep -= 2;
                while (step>=0)
                {
                    SumVarStep(step, twoStep, ref count);
                    step--;
                }
            }
            else
            {
                count += GaussSum(step + 1);
            }
            return;
        }

        private static int GaussSum(int number)
        {
            if (number % 2 != 0)
            {
                return (number + 1) / 2 * number;
            }
            else
            {
                return number / 2 * (number + 1);
            }
        }
    }
}

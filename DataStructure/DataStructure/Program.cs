using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDataStructure<int> myData = new MyDataStructure<int>();
            for (int i = 10; i < 20; i++)
            {
                myData.Add(i);
            }
            myData.Remove(15);
            myData.RemoveAt(3);
            myData.Insert(5, 999);

            for (int i = 0; i < myData.Count; i++)
            {
                Console.WriteLine(myData[i]);
            }
            Console.WriteLine();
            Console.WriteLine(myData.Contains(1));
            Console.WriteLine($"Count is: {myData.Count}");
        }
    }
}

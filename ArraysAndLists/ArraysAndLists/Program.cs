using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            int[] numArray = new int[5];
            numArray[0] = 5;
            numArray[1] = 2;
            numArray[2] = 10;
            numArray[3] = 300;
            numArray[4] = 5000;

            List<int> intList = new List<int>();
            intList.Add(4);
            intList.Add(10);
            Console.WriteLine(intList[0]);
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;

namespace ArrayListDrill
{
    class Program
    {
        static void Main()
        {
            string[] stringArray = new string[5];
            stringArray[0] = "Mozambique";
            stringArray[1] = "Mauritania";
            stringArray[2] = "Malawi";
            stringArray[3] = "Morocco";
            stringArray[4] = "Mali";

            int[] intArray = new int[] {1, 1, 2, 3, 5, 8, 13};
            List<string> stringList = new List<string> {"Alif", "Hamza", "Baa", "Taa", "Thaa",  };

            Console.WriteLine("Please input a value between 1 and 5 to receive the string at that position");
            int stringArrayIndex = Convert.ToInt16(Console.ReadLine());
            if (stringArrayIndex > 5)
            {
                Console.WriteLine("Please input a value between 1 and 5");
                stringArrayIndex = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine(stringArray[stringArrayIndex-1]);
            Console.WriteLine("Please input a value between 1 and 7 to receive the integer at that position");
            int intArrayIndex = Convert.ToInt16(Console.ReadLine());
            if (intArrayIndex > 7)
            {
                Console.WriteLine("Please input a value between 1 and 7");
                intArrayIndex = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine(intArray[stringArrayIndex - 1]);
            Console.WriteLine("Please input a value between 1 and 5 to receive the integer at that position");
            int stringListIndex = Convert.ToInt16(Console.ReadLine());
            if (stringListIndex > 5)
            {
                Console.WriteLine("Please input a value between 1 and 5");
                stringListIndex = Convert.ToInt16(Console.ReadLine());
            }
            Console.WriteLine(stringList[stringListIndex - 1]);
            Console.Read();
        }
    }
}

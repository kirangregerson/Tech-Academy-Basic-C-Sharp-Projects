using System;
using System.Collections.Generic;

namespace IterationDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animalArray = { "Flying", "Jumping", "Colossal", "Screeching", "Armored" };
            Console.WriteLine("Input the name of an animal to receive new varieties");
            string baseAnimal = Convert.ToString(Console.ReadLine());
            for(int i = 0; i < animalArray.Length; i++)
            {
                animalArray[i] += (" " + baseAnimal);
                Console.WriteLine(animalArray[i]);
            }

            List<string> wordList = new List<string>();
            wordList.Add("the");
            wordList.Add("be");
            wordList.Add("to");
            wordList.Add("of");
            wordList.Add("and");
            wordList.Add("a");
            wordList.Add("in");
            wordList.Add("that");
            wordList.Add("have");
            wordList.Add("i");

            Console.WriteLine("Input a word to see if it is one of the top 10 most common English words");
            Console.WriteLine("(lowercase only please)");
            string listQuery = Convert.ToString(Console.ReadLine());
            Boolean onList = false;
            for(int i = 0; i < wordList.Count; i++)
            {
                if(wordList[i] == listQuery)
                {
                    if(i == 0)
                    {
                        Console.WriteLine("Your word is the 1st most common word (index = " + i + ")");
                        onList = true;
                    }
                    else if(i == 1)
                    {
                        Console.WriteLine("Your word is the 2nd most common word (index = " + i + ")");
                        onList = true;
                    }
                    else if (i == 2)
                    {
                        Console.WriteLine("Your word is the 3rd most common word (index = " + i + ")");
                        onList = true;
                    }
                    else
                    {
                        Console.WriteLine("Your word is the " + (i + 1) + "th most common word (index = " + i + ")");
                        onList = true;
                    }
                    break;
                }
            }
            if (!onList)
            {
                Console.WriteLine("Your word is not one of the 10 most common words.");
            }

            List<string> presidentList = new List<string>();
            presidentList.Add("George Washington");
            presidentList.Add("George Washington");
            presidentList.Add("John Adams");
            presidentList.Add("Thomas Jefferson");
            presidentList.Add("Thomas Jefferson");
            presidentList.Add("James Madison");
            presidentList.Add("James Madison");
            presidentList.Add("James Monroe");
            presidentList.Add("James Monroe");
            presidentList.Add("John Quincy Adams");
            presidentList.Add("Andrew Jackson");
            presidentList.Add("Andrew Jackson");
            presidentList.Add("Martin Van Buren");
            presidentList.Add("William Henry Harrison");
            presidentList.Add("John Tyler");

            Console.WriteLine("Input the name of a president to see if they were one of the first 10 presidents");
            Console.WriteLine("(first and last name, both initials capitalized)");
            string userPresident = Convert.ToString(Console.ReadLine());
            onList = false;

            for (int i = 0; i < presidentList.Count; i++)
            {
                if ((i != 0) && (i != presidentList.Count - 1))
                {
                    if ((presidentList[i] != presidentList[i - 1]) && (presidentList[i] == userPresident))
                    {
                        if (presidentList[i] == presidentList[i + 1])
                        {
                            Console.WriteLine(userPresident + " is on the list (indices " + i + " and " + (i + 1) + ")");
                            onList = true;
                        }
                        else
                        {
                            Console.WriteLine(userPresident + " is on the list (index = " + i + ")");
                            onList = true;
                        }
                    }
                }
                else if((presidentList[i] == userPresident) && ((i == 0) || (i != presidentList.Count - 1)))
                {
                    Console.WriteLine(userPresident + " is on the list (index = " + i + ")");
                    onList = true;
                }
            }
            if (!onList)
            {
                Console.WriteLine("Your president is not one of the first 10.");
            }
            Console.WriteLine("Press enter to see the list of presidents and which ones had two terms");
            Console.ReadLine();

            string previousPresident = "King George III";
            foreach (string president in presidentList)
            {
                if (president != previousPresident)
                {
                    Console.Write(president);
                }
                else
                {
                    Console.Write(" (served two terms)");
                }
                previousPresident = president;
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}

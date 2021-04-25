using System;
using System.Collections.Generic;

namespace ArraysListAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uncomment to try differnt exercises
            // Array1();
            // Array2();
            // List1();
            // List2();
            List3();

        }

        static void Array1()
        {
            string[] names = new string[5];
            names[0] = "Scott";
            names[1] = "Is";
            names[2] = "Very";
            names[3] = "Tired";
            names[4] = "Kill me";

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"Hello {names[i]}");
            }
        }

        static void Array2()
        {
            // i knew there was a way to do them all at once.
            int[] numArray = { 34, 5, 67, 1, 99, 34, 44, 78, 34, 0 };

            Console.WriteLine($" The array stores {numArray.Length} values");
            int Total = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                Total += numArray[i];
            }
            Console.WriteLine(Total);
        }

        static void List1()
        {
            List<int> numList = new List<int>();

            int numsWanted = 5;
            for (int i = 0; i < numsWanted; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"Please input {numsWanted} numbers");
                    numList.Add(int.Parse(Console.ReadLine()));
                }
                else if (i != 0)
                {
                    Console.WriteLine("Give me another number.");
                    numList.Add(int.Parse(Console.ReadLine()));
                }
            }

            Console.WriteLine("Please give me an extra number");
            int extraNumber = int.Parse(Console.ReadLine());

            if (numList.Contains(extraNumber))
            {
                Console.WriteLine("You have inputed this number previously");
            }
            else
            {
                Console.WriteLine("This is a new number");
            }
        }

        static void List2()
        {
            List<int> numList = new List<int>();

            int numsWanted = 5;
            for (int i = 0; i < numsWanted; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine($"Please input {numsWanted} numbers");
                    numList.Add(int.Parse(Console.ReadLine()));
                }
                else if (i != 0)
                {
                    Console.WriteLine("Give me another number.");
                    numList.Add(int.Parse(Console.ReadLine()));
                }
            }
            Console.WriteLine("Please give me an extra number");
            int extraNumber = int.Parse(Console.ReadLine());
            int repeats = 0;
            if (numList.Contains(extraNumber))
            {
                for (int i = 0; i < numsWanted; i++)
                {
                    if (extraNumber == numList[i])
                    {
                        repeats++;
                    }

                }
                Console.WriteLine($"You've entered {extraNumber} previously in the list {repeats} times.");
            }
            else
            {
                Console.WriteLine("This is a new number in the list");
            }
        }

        static void List3()
        {
            List<string> wordEntry = new List<string>();

            Console.WriteLine("Enter as many words as you desire my lord, and once pleased with what you have done, press stop and it shall be read back in reverse order.");
            // Keep going until stop occurs as the index and the count of elements in the array increase proportionally until stop occurs. i.e everytime index += 1,  wordentry.count +=1 element as well
            for (int index = 0; index <= wordEntry.Count;  index++)
            {
                string input = Console.ReadLine();

                if (input != "stop")
                {
                    // wordEntry +=1
                    wordEntry.Add(input);
                }
                else if (input == "stop")
                {
                    // important to keep this outside the for loop, lest you reverse directions endlessly.
                    wordEntry.Reverse();
                    Console.WriteLine();
                    for (int i = 0; i < wordEntry.Count; i++)
                    {
                         Console.WriteLine(wordEntry[i]);
                    }
                    // This kills the index by making it 1 greater then the list count. Without infinite recurrsion occurs.
                   index++;
                }
            }
        }

    }
}

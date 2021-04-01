using System;

namespace _4NestedRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please put in a name.");
            string name = Console.ReadLine();
            int LineCount = 0;
            int NewLineCount = 0;

            while (NewLineCount < 10)
            {
                while (LineCount < 10)
                {
                  Console.Write(name + " ");
                  LineCount ++;  
                }
                Console.WriteLine();
                NewLineCount ++;
                LineCount = 0;
            }

        }
    }
}

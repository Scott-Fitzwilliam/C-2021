using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please put in a name.");
            string Name = Console.ReadLine();
            Console.WriteLine("How many times do you want to print it?");
            int NameCount = int.Parse(Console.ReadLine());
            int LineCount = NameCount;
            int WriteCount = NameCount;

            while (LineCount > 0)
            {
                while (WriteCount > 0)
                {
                    Console.Write(Name + " ");
                    WriteCount --;
                }
                Console.WriteLine();
                LineCount --;
                WriteCount = NameCount;
                

            }

            


        }
    }
}

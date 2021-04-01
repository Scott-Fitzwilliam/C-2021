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

            while (NameCount > 0)
            {
                Console.Write(Name + " ");
                NameCount --;
            }
            


        }
    }
}

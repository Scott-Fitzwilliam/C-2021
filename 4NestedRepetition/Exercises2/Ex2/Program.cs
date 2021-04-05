using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many x's would you like?");
            int xRequested = int.Parse(Console.ReadLine());
                       

            while (xRequested > 0)
            {      
                for (int Count = 0; Count < xRequested; Count++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
                xRequested --;
            }  
            

        }
    }
}

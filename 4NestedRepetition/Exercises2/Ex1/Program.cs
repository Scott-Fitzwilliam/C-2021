using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int XCount = 5;
                       

            while (XCount > 0)
            {      
                for (int Count = 0; Count < XCount; Count++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
                XCount --;

            }

        }
    }
}

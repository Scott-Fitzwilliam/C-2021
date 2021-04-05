using System;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task3();
            //Task4();


        }

        static void Task3()
        {
            int XCount = 5;
            int LineCount = XCount;

            while (LineCount > 0)
            {
                int xRequired = XCount - LineCount;
                for (int Count = 0; Count <= xRequired; Count++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
                LineCount --;
            }
        }

            static void Task4()
            {
                Console.WriteLine("How many Acending x's are you after?");
                int xWidth = int.Parse(Console.ReadLine());

                for (int LineCount = xWidth; LineCount > 0; LineCount--)
                {

                    int xRepeat = xWidth - LineCount;
                    for (int x = 0; x <= xRepeat; x++)
                    {
                        Console.Write("x");
                    }
                     Console.WriteLine();
                     
                }
               
            }

    }
}

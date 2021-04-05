using System;

namespace AdvancedExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task1();
            // Task2();
            Task3();
        }



        static void Task1()
        {
            // the first loop must make new lines and created the one space to the left as it won't increment by 2 like the second loop.
            // The second loop needs to decrement by two reducing over time the amount of x's, there can be no print xx, since that can't work, so something else is needed.
            //There must be a smarter way of coding this rather then making x > 1
            int LineLength = 6;
            for (int LineCount = LineLength; LineCount > 0; LineCount--)
            {
                int SpaceCount = LineLength - LineCount;
                while (SpaceCount > 0)
                {
                    Console.Write(" ");
                    SpaceCount--;
                }
                for (int x = 2*LineCount; x > 1; x--)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }

        }

        static void Task2()
        {
            int LineLength = 6;
            for (int LineCount = 0; LineCount < LineLength; LineCount++)
            {
                if (LineCount != 0)
                {
                    int spaceCount = LineCount;
                    while (spaceCount < LineLength)
                    {
                        Console.Write(" ");
                        spaceCount ++;
                    }
                    for (int x = 2*LineCount; x > 1; x--)
                    {
                        Console.Write("x");
                    }
                    Console.WriteLine();

                }
            }

        }
        
        static void Task3()
        {
        // The only change needed for task 3 is to create a int.Parse(Readline()); as the value for the interger and a writeline requesting input which is boring.
        //Instead, i am going to make a acending and decending triangle that asks how many maximum x's one wants and make a pyramid based on the design.
            {
                Console.WriteLine("How many centered decending x's do you want?");
                int xLength = int.Parse(Console.ReadLine());

                for (int LineLength = xLength; LineLength > 0; LineLength-=2)
                {
                    int SpaceCount = (xLength - LineLength)/2;
                    while (SpaceCount > 0)
                    {
                        Console.Write(" ");
                        SpaceCount--;
                    }

                    for (int x = 0; x < LineLength; x++)
                    {
                        Console.Write("x");
                    }
                    Console.WriteLine();
                }
            }

            {
                // the spaces needed to is conversely proportionally do the amount of linespaces
                //the amount of lines needs to be half the amount of x's requested as the pyramid requires increments of two.
                // the amount of x's needs to start at almost none, and increase as linespaces changes

                Console.WriteLine("How many centered ascending x's do you want?");
                int xLength = int.Parse(Console.ReadLine());
                int OddOrEven = xLength % 2;


                for (int LineLength = OddOrEven; LineLength <= xLength; LineLength+=2)
                {
                    if (LineLength != 0)
                    {
                        int SpaceCount = (xLength - LineLength)/2;
                        while (SpaceCount > 0)
                        {
                            Console.Write(" ");
                            SpaceCount--;
                        }

                        for (int x = 0; x < LineLength; x++)
                        {
                            Console.Write("x");
                        }
                        Console.WriteLine();
                    }

                }



            }


        }
    }
}

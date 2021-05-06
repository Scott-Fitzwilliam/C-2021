using System;
using System.Collections.Generic;

namespace New_folder
{
    class Program
    {
       public static void Main(string[] args)

        {
            // Will store the dice rolls
            List<int> DiceRoll = new List<int>();
            // Controls how many dice a rolled together
            Console.WriteLine("How many dice are we using?");
            int DiceUsed = int.Parse(Console.ReadLine());
            // The minimum of the dice roll
            int DiceMin = 1;
            // The maximum of the dice roll - 1. So 6.
            Console.WriteLine("How many sides does this die you're using have by the way?");
            int DiceMax = int.Parse(Console.ReadLine()) + 1;
            if (DiceMax <= 0 + 1 )
            {
                Console.WriteLine(">____>. Really? How about no. Goodbye.");
                return;
            }
            else if (DiceMax == 1 + 1)
            {
                Console.WriteLine("What are the hell are you using?!? A Möbius strip???");
            }
            else if (DiceMax == 6 + 1)
            {
                Console.WriteLine("Respect for the Classics.");
            }
            else if (DiceMax == 20 + 1)
            {
                Console.WriteLine("A D&D player I see.");
            }
            else if (DiceMax >= 100 + 1)
            {
                Console.WriteLine("What the hell are you rolling? It's basically a sphere in disguise. Just play marbles man.");
            }
            else
            {
                Console.WriteLine("I am confused and frightened by you decisions");
            }

            Console.WriteLine("Would you like to roll the dice? Y/N");
            string Decision = Console.ReadLine();        

            if (Decision == "Y" || Decision == "y")
            {
                DiceRoll.Add(RandomNumber(DiceUsed, DiceMin, DiceMax));

                while (Decision == "Y" || Decision == "y")
                {
                    Console.WriteLine("Would you like to roll again or stop? Y/Stop");
                    Decision = Console.ReadLine();
                    if (Decision == "Y" || Decision == "y")
                    {
                        DiceRoll.Add(RandomNumber(DiceUsed, DiceMin, DiceMax));
                    }

                    // Perform random dice roll and then add to array.
                    else if (Decision == "Stop" || Decision == "stop")
                    {
                        Console.WriteLine("The amount of elements is the list is " + DiceRoll.Count);

                        // Allows for the selection of rolls to be examined... eventually.
                        Console.WriteLine("How many rolls would you like to exam?");
                        PrintRolls(int.Parse(Console.ReadLine()));

                        decimal DiceTotal = 0;
                        // Get the sum of all the dice.
                        for (int i = 0; i < DiceRoll.Count; i++)
                        {
                            DiceTotal += DiceRoll[i];
                        }
                        Console.WriteLine($"The Total of all the rolls is {DiceTotal}");
                        
                        decimal Average = DiceTotal/DiceRoll.Count;
                        Console.WriteLine($"The Average of all the dice rolls is {Average}.");
                    }
                }
            
            }
            static int RandomNumber(int DiceUsed, int min, int max)  
            {
                int DiceTotal = 0;
                for (int i = 0; i < DiceUsed; i++)
                {
                    Random rnd = new Random();
                    int DiceLanded = rnd.Next(min, max);
                    DiceTotal += DiceLanded;

                }
                return DiceTotal;
            }  


             //showing inputted rolls
            void PrintRolls(int howMany){
                if (howMany <= DiceRoll.Count && howMany > 0)
                {
                Console.WriteLine($"These are the first {howMany} numbers you rolled.");
                for (int i = 0; i < howMany; i++)
                        {
                            Console.WriteLine(DiceRoll[i]);
                        }
                }
                else if(howMany == 0)
                {
                    Console.WriteLine(" Show 0? Really? I guess you just wanted to skip it I guess.");
                }
                else
                {
                    Console.WriteLine("What do you think you're playing at? Well look at you, so clever with your negative and big numbers, trying to kill the program. You're 10 steps behind me, not even in the race. I'm just going to print them all if you're going to be such a smart ass. I hope your satisfied with trying to kill this poor program. You monster.");
                        for (int i = 0; i < DiceRoll.Count; i++)
                        {
                            Console.WriteLine(DiceRoll[i]);
                        }
                }
                

            }
                
            


            


        }
    }
}

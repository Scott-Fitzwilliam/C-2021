using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int Fizz = 3;
            int Buzz = 5;
            int FizzBuzz = Fizz*Buzz;


            for (int Count = 1; Count <= 100; Count++)
            {


                if (Count % FizzBuzz == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (Count % Fizz == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (Count % Buzz == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(Count);
                }

            }
        }
    }
}

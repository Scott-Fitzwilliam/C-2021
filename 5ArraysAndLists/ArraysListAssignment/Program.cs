using System;
using System.Collections.Generic;

namespace ArraysListAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uncomment to try differnt exercises
            Array1();
            // Array2();
        }

        static void Array1(){
            string[] names = new string[5];
            names[0] = "Scott";
            names[1] = "Is";
            names[2] = "Very";
            names[3] = "Tired";
            names[4] = "Killme";

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
        
    }
}

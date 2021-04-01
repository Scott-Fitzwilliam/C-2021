using System;

namespace Variable_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input your first name");
            string FirstName = Console.ReadLine();
            Console.WriteLine("\n" + FirstName);
            
            Console.WriteLine("Please input your last name");
            string LastName = Console.ReadLine();
            Console.WriteLine("\n" + LastName);

            Console.WriteLine("Please input your Student ID");
            string StudentID = Console.ReadLine();
            Console.WriteLine("\n" + StudentID);
            
            Console.WriteLine("Please input the year you were born");
            string YOB = Console.ReadLine();
            Console.WriteLine("\n" + YOB);

            Console.WriteLine("Please input the current year");
            string CurrentYear = Console.ReadLine();
            Console.WriteLine("\n" + CurrentYear);

            int year = int.Parse(YOB);
            int TheCurrentYear = int.Parse(CurrentYear);

            Console.WriteLine($"Hi There {FirstName} {LastName}, it seems you are {TheCurrentYear - year} years old.");
            

        }
    }
}

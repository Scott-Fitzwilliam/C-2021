using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserName = "Admin";
            string CorrectPass = "1234";

            Console.WriteLine("Please put in your Username and then your Password. \n psst.... the username is Admin \n the password is 1234");
            string Name = Console.ReadLine();
            string Pass = Console.ReadLine();
            
            if (Name == UserName)
            {
                if (Pass == "1234")
                {
                    Console.WriteLine("login successful");
                }
                else
                {
                    Console.WriteLine("login unsuccessful");
                }
            }
            else
            {
                Console.WriteLine("login unsuccessful");
            }

        }
    }
}

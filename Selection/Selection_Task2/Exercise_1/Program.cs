using System;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Uncomment the one you need to check
            // Task1();
            // Task2();
            Task3();
        }
        
        public static void Task1()
        {
            Console.WriteLine("Please input your age.");
            int age = Int32.Parse(Console.ReadLine());

            if (age > 17)
            {
                Console.WriteLine("Legally of adult age");
            }
            else if (age == 17)
            {
                Console.WriteLine("Legally not of adult age, but quite close");
            }
            else
            {
                Console.WriteLine("Legally not of adult age");
            }
        }

        public static void Task2()
        {

            Console.WriteLine("What is your gender? Please input M or F");
            string gender = Console.ReadLine();

            if (gender == "M" )
            {
                gender = " male";
            }
            else if (gender == "F")
            {
                gender = " female";
            }
            else if (gender == "I sexually identify as an Attack helicopter")
            {
                Console.WriteLine("ok there buddy. <_<");
                gender = "n Attack Helicoper";
            }
            else
            {
                Console.WriteLine("I am sorry there are only 3 genders. Male, female and sexually identifying as an Attack helicopter. You may not like it but this is peak gender. Is will make you an attack helicopter for now. You're welcome");
                gender = "n Attack Helicoper";
            }

            Console.WriteLine("Please input your age.");
            int age = Int32.Parse(Console.ReadLine());

            
            if (age > 17)
            {
                Console.WriteLine($" You are a{gender} that is legally of adult age");
            }
            else if (age == 17)
            {
                Console.WriteLine($"You are a{gender} that is Legally not of adult age, but quite close");
            }
            else
            {
                Console.WriteLine($"You are a{gender} that is Legally not of adult age");
            }

        }

        public static void Task3()
        {
            Console.WriteLine("I am am a program that adds numbers. \n Please enter a number.");
            int num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine(" Please enter the second number to add");
            int num2 = Int32.Parse(Console.ReadLine());

            int num3 = num1 + num2;

            if (num3 > 10)
            {
                Console.WriteLine("Your number is larger than 10");
            }
            else if (num3 < 10)
            {
                Console.WriteLine("Your number is smaller than 10");
            }
            else
            {
                Console.WriteLine("Your number is equal than 10");
            }

        }
    }
}



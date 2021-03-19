using System;

namespace Selection_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please put in your Username. \n psst.... the AllThisC#IsMakingMyD#");
            string Name = Console.ReadLine();
            string CorrectName = "AllThisC#IsMakingMyD#";
            if (Name == CorrectName)
            {
                Console.WriteLine("Please put your password in now. \n psst... the password is CumAsFarAsYouCanC#");
                string Pass = Console.ReadLine();
                string CorrectPass = "CumAsFarAsYouCanC";
                
                if (Pass == CorrectPass)
                {
                    Console.WriteLine("You did it. You crazy son of bitch you did it.");
                }
                else
                {
                    Console.WriteLine("Sorry your log in details were incorrect");
                }
            }
            else
            {
               Console.WriteLine("Please put your password in now.");
               string Pass = Console.ReadLine();
               Console.WriteLine("Sorry your log in details were incorrect");
            }
            // I purposely wrote an if statement for both Username whether it was wrong or right, as it is an important security measure and good practice against hackers as if they are immediately told the username is wrong, they can keep trying until its right then move onto the password. This method prevents. Also crude passwords can be effective. ;)
            
        }
    }
}

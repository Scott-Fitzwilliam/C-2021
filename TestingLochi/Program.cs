using System;

namespace selectionassignment
{
    class Program
    {
        static void Main(string[] args)

            //"Exercise 1
        {
        /*
        
            
            Console.WriteLine("Enter age");
            int ageNum =Convert.ToInt32(Console.ReadLine());
                     
            //true Branch
            if (ageNum >= 17)
            {   
                Console.WriteLine("Legally adult age");
                Console.WriteLine("Press enter Button To Continue");
                Console.ReadLine();

                Console.Write("Enter Gender Here :  ");
                string gender = Console.ReadLine();

                Console.WriteLine($"{gender} is an adult");
                Console.WriteLine("Press enter Button To Continue");
                Console.ReadLine();
            }

            //False Branch
            else 
            {
                Console.WriteLine("Legally not adult age");
                Console.WriteLine("Press enter Button To Continue");
                Console.ReadLine();

                Console.Write("Enter Gender Here :  ");
                string gender = Console.ReadLine();

                Console.WriteLine($"{gender} is not an adult");
                Console.WriteLine("Press enter Button To Continue");
                Console.ReadLine();
            }
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                
                Console.Write("Enter a second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                
                if ((num1 + num2) > 10)
                {
                    Console.WriteLine($"{ num1 + num2 } is greater than 10");
                    Console.WriteLine("Press enter button to end the Program");
                    Console.ReadLine();
                }

                else
                {
                    Console.WriteLine($"{ num1 + num2 } is less than 10");
                    Console.WriteLine("Press enter button to end the Program");
                    Console.ReadLine();
                }
            
                */


            //"Exercise 2" USER LOGIN PROGRAM 
            
            Console.Write("enter username: ");
            string username =Console.ReadLine();
            string SavedUser = "LachMcle";
            
            int test = 10;
            
                //if (username = SavedUser)
                 if (test == 10)
            {
                
                Console.Write("Enter Password: ");
                string password =Console.ReadLine();
                string SavedPassWord = "Jamie1974";            
                
                if (password == SavedPassWord)
                {
                    Console.WriteLine("login successful");
                    Console.WriteLine("press enter to continue");
                    Console.ReadLine();
                }

                else 
                {
                    Console.WriteLine("login unsuccessful");
                    Console.WriteLine("press enter to continue");
                    Console.ReadLine();
                }
                
            }
            
            else
            {
                Console.WriteLine("login unsuccessful");
                Console.WriteLine("press enter to finish");
                Console.ReadLine();
            } 
            
        
        }       
    }
} 
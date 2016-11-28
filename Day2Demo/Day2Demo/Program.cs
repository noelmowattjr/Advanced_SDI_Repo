using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of users {0}", User.GetNumUsers());

            User user1 = new User("boB");

            Console.WriteLine("User1's name is {0}", user1.Name);

            user1.Name = "boB";

            Console.WriteLine("User1's name is {0}", user1.Name);

            Console.WriteLine("\nNumber of users {0}", User.GetNumUsers());

            Console.WriteLine("\n\nWhat is {0}'s starting account balance? (enter a number)", user1.Name);
            string input = Console.ReadLine();
            decimal startingBalance; // = Convert.ToDecimal(input);  <- this will allow program to crash on bad input

            while(Decimal.TryParse(input, out startingBalance) != true)
            {
                Console.WriteLine("Input was not a valid number please try again: ");
                input = Console.ReadLine();
            }

            Account account1 = new Account(true, startingBalance);

            user1.Acct = account1;

            Console.WriteLine("\n\nBob's account:\n");
            if(user1.Acct.IsCheckingAccount)
            {
                Console.WriteLine("  Checking balance: {0}", user1.Acct.Balance);
            }
            else
            {
                Console.WriteLine("  Savings balance: {0}", user1.Acct.Balance);
            }

            // Switch demo
            bool keepLooping = false;
            while(keepLooping) // infinite loop
            {
                Console.WriteLine("1. first");
                Console.WriteLine("2. second");
                Console.WriteLine("3. choice 3");
                Console.WriteLine("4. do something");
                Console.WriteLine("5. exit");

                string choice = Console.ReadLine().ToLower();
                switch(choice)
                {
                    case "first":
                    case "1":
                        {
                            Console.WriteLine("chose first option");
                            break;
                        }
                    case "second":
                    case "2":
                        {
                            Console.WriteLine("chose second option");
                            break;
                        }
                    case "third":
                    case "3":
                        {
                            Console.WriteLine("chose third option");
                            break;
                        }
                    case "fourth":
                    case "4":
                        {
                            Console.WriteLine("chose fourth option");
                            break;
                        }
                    case "exit":
                    case "5":
                        {
                            Console.WriteLine("chose to exit");
                            keepLooping = false;
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Bad choice try again");
                            break;
                        }

                }
            }

            //Console.WriteLine("\n\nPress any key to continue...");
            //Console.ReadKey();
        }
    }
}

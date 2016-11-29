using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoelMowatt_CE02
{
    class Program
    {
        static Character superHero;
        

        static void Main(string[] args)
        {
            bool continueGame = true;

            //--GAME BEGINS
            while (continueGame)
            {
                //--Prompt user to begin program or exit
                Console.Write("Enter \"Yes\" to continue or \"No\" to exit (YES/NO): ");
                string yes_no = Console.ReadLine();

                //--VALIDATION - (YES/NO)---//
                while (yes_no.ToLower() != "yes" && yes_no.ToLower() != "no")
                {
                    Console.Write("Invalid Entry!\r\nEnter (YES/NO) to proceed: ");
                    yes_no = Console.ReadLine();
                }

                //--Conditions to Begin
                if (yes_no.ToLower() == "yes")
                {
                    //--BEGIN
                    //------------CHOICES----------------------------------------------------//
                    Console.WriteLine("Welcome to the Game! Choose 1 of the following to proceed");
                    Console.WriteLine("Enter \"1\" to Create Character");
                    Console.WriteLine("Enter \"2\" to Modify Character");
                    Console.WriteLine("Enter \"3\" to Create & Equip Weapon");
                    Console.WriteLine("Enter \"4\" to Display Character Data");
                    Console.WriteLine("Enter \"5\" to Exit program");
                    string userChoice = Console.ReadLine().ToUpper();
                    
                    //--Do something with user's choice
                    switch (userChoice)
                    {
                        case "1":
                            {
                                //--Create Character
                                Console.WriteLine("Let's create a Character! Ready!");
                                Console.Write("Enter character\'s name: ");
                                string cName = Console.ReadLine();

                                Console.WriteLine("Your character\'s name is {0}", cName);
                                break;
                            }
                        case "2":
                            {
                                //--Modify Character
                                break;
                            }
                        case "3":
                            {
                                //--Create and Equip Weapon
                                break;
                            }
                        case "4":
                            {
                                //--Display Character data
                                break;
                            }
                        case "5":
                            {
                                //--Exit Program
                                break;
                            }
                    }
                } //--Condition to exit
                else if (yes_no.ToLower() == "no")
                {
                    //--EXIT the loop
                    continueGame = false;
                    break;
                }
            }
            //--Goodbye msg
            Console.WriteLine("Sorry to see you go. =(");
        }
        
        //--convert only first letter of string to upper case
        public static string CapFirstLetter(string convertThis)
        {
            //--If string is empty then nothing happens
            if (convertThis == null)
                return null;

            //--If string length is longer than 1
            if (convertThis.Length > 1)

                //--then capitalize the the initial index of string and append the rest of the string back onto itself
                return char.ToUpper(convertThis[0]) + convertThis.Substring(1);

            //--the result I want =)
            return convertThis.ToUpper();
        }
    }
}

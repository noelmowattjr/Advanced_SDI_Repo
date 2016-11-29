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
            //--Prompt user for favorite hero
            Console.Write("Choose one of the following as your favorite superhero\r\n1) Superman\r\n2) Batman\r\n3) Wonder Woman\r\n ");
            string entryHero = Console.ReadLine();  //--Catch user's response

            //------------------VALIDATION---------------------------//
            while (entryHero.ToLower() != "superman" && entryHero.ToLower() != "batman" && entryHero.ToLower() != "wonder woman")
            {
                Console.WriteLine("INVALID Entry!\r\nPlease choose \"1)Superman 2)Batman! 3)Wonder Woman)\" and press enter: ");
                entryHero = Console.ReadLine();
            }
            //------------------------------------------------------//

            string hero = CapFirstLetter(entryHero);     //--Conververt user's response to where first letter is upper case
            
            //--Give user feedback
            Console.WriteLine("You chose {0} as your favorite superhero!", hero);
            
            
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

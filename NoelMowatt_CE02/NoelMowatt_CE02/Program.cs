using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoelMowatt_CE02
{
    class Program
    {
        static void Main(string[] args)
        {
            Character Superman = new Character(name:"Clark Kent",baseattack:100,health:95,age:30,gender:'M');


            Console.Write("How strong is Superman? type a number and press enter: ");
            string entry = Console.ReadLine();
            int supesStrength;  //--converted string to be stored here

            //--Validate user entered a number
            while (!(int.TryParse(entry, out supesStrength)))
            {
                Console.Write("Enter a whole number: ");
                entry = Console.ReadLine();
            }

            Weapon strength = new Weapon(attack: supesStrength, shield: true);
            var a = strength.Attack_GS;
            Console.WriteLine("Superman's strength is {0}", a);

        }
    }
}

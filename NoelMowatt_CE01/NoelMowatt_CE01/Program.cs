using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoelMowatt_CE01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Noel Mowatt
                Classes & Methods Review
                Lab 1
                Monday, 11/21/2016 */
            Human iHuman = new Human(Age: 28, Gender: 'M', Name: null, Student: true);

            Console.WriteLine("iHuman: {0}", iHuman);
            
        }
    }
}

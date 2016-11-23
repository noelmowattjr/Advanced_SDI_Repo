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

            //-----------------------------------------------------------------------------------------//
            Musician iMusician = new Musician();
            iMusician.Genre = "Country";
            iMusician.Albums = 9;
            iMusician.Guitarist = false;
            Console.WriteLine("\r\n\r\nMusician Class objects!\r\nGenre: {0}.\r\nAlbums: {1}.\r\nIs a Guitarist: {2}", iMusician.Genre, iMusician.Albums, iMusician.Guitarist);

            Human iHuman = new Human();
            iHuman.Age = 28;
            iHuman.Gender = 'M';
            iHuman.Name = "Noel Mowatt, Jr.";
            Console.WriteLine("\r\n\r\nnHuman Class objects!\r\nAge: {0}.\r\nGender: {1}.\r\nName: {2}", iHuman.Age, iHuman.Gender, iHuman.Name);

            Car iCar = new Car();
            iCar.Make = "McLaren";
            iCar.Yearr = 2017;
            iCar.AllWheelDr = true;
            Console.WriteLine("\r\n\r\nCar Class objects!\r\nMake: {0}.\r\nYear: {1}.\r\nAll wheel drive: {2}", iCar.Make, iCar.Yearr, iCar.AllWheelDr);
            //-----------------------------------------------------------------------------------------//
            
            

            

            
        }
    }
}

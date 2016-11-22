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
            Console.WriteLine("Musicain Class: {0}", iMusician);    //--Prints class name: Musician

            Human iHuman = new Human();
            Console.WriteLine("Human Class: {0}", iHuman);           //--Prints class name: Human

            Car iCar = new Car();
            Console.WriteLine("Car Class: {0}", iCar);              //--Prints class name: Car
            
            //-----------------------------------------------------------------------------------------//

            //--Musician Class Instances
            bool isGuitarist = iMusician.Guitarist;
            string myGenre = iMusician.Genre;
            int albumsReleased = iMusician.Albums;

            //--Car Class Instances
            string myCar = iCar.Make;
            myCar = "Ferrari";
            int theYear = iCar.Yearr;
            theYear = 2017;
            bool fourWheelDR = iCar.AllWheelDr;
            Human Marium = iCar.MariumShene;
            Marium.Name = "Marium Shene I.Abidi";
            

            //--Printed instances of Car Class to console
            Console.WriteLine("Make of car: {0}. The Year: {1}. Is 4-wheel drive: {2}. The person: {3}", myCar, theYear, fourWheelDR, Marium);

            //--Human Class Instances
            int noelsAge = iHuman.Age;
            char noelsGender = iHuman.Gender;
            string noelsName = iHuman.Name;

            //--Printed instances of Musician Class to console
            Console.WriteLine("\r\nIs Guitarist: {0}. What's the genre? {2}. Albums released? {3}", isGuitarist, myGenre, albumsReleased);

            

            //--Printed instances of Human Class to console
            Console.WriteLine("Name: {0} Age: {1} yrs old. Gender: {2}", noelsName, noelsAge, noelsGender);

            
        }
    }
}

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

            Musician iMusician = new Musician(Guitarist:true, BandMember:true, Genre:"Reggae", Albums:15);
            Car iCar = new Car(Make:"Ferrari", Year: 2017, AllWheelsDrive: true);
            Human iHuman = new Human(Age: 28, Gender: 'M', Name: "Noel Mowatt, Jr.", Student: true);

            //--Musician Class Instances
            bool isGuitarist = iMusician.guitarist;
            bool inBand = iMusician.bandMember;
            string myGenre = iMusician.genre;
            int albumsReleased = iMusician.albums;

            //--Car Class Instances
            string myCar = iCar.make;
            int theYear = iCar.year;
            bool fourWheelDR = iCar.allWheelDrive;

            //--Human Class Instances
            int noelsAge = iHuman.age;
            char noelsGender = iHuman.gender;
            string noelsName = iHuman.name;
            bool isStudent = iHuman.student;

            //--Printed instances of Musician Class to console
            Console.WriteLine("\r\nIs Guitarist: {0}. In a band: {1}. What's the genre? {2}. Albums released? {3}", isGuitarist, inBand, myGenre, albumsReleased);

            //--Printed instances of Car Class to console
            Console.WriteLine("Make of car? {0}. What is the year? {1}. Is 4-wheel drive: {2}.", myCar, theYear, fourWheelDR);

            //--Printed instances of Human Class to console
            Console.WriteLine("Name: {0} Age: {1} yrs old. Gender: {2}. Is a Student: {3}", noelsName, noelsAge, noelsGender, isStudent);

            
        }
    }
}

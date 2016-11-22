using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoelMowatt_CE01
{
    class Car
    {
        //--Car Class blueprints
        public string make;
        public int year;
        public bool allWheelDrive;

        //--Two additional blueprints
        Human mariumShene;
        Musician JimiHendrix;

        //--Car Constructor
        public Car(string Make, int Year, bool AllWheelsDrive)
        {
            make = Make;
            year = Year;
            allWheelDrive = AllWheelsDrive;
        }
        
    }
}

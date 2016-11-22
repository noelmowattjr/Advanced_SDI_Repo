using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoelMowatt_CE01
{
    class Car
    {
        //--Car Class fields - blueprints
        private string make;
        private int year;
        private bool allWheelDrive;

        //--Two additional blueprints
        private Human mariumShene;
        private Musician jimiHendrix;

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public int Yearr
        {
            get { return year; }
            set { year = value; }
        }

        public bool AllWheelDr
        {
            get { return allWheelDrive; }
            set { allWheelDrive = value; }
        }

        public Human MariumShene
        {
            get { return mariumShene; }
            set { mariumShene = value; }
        }

        public Musician JimiHendrix
        {
            get { return jimiHendrix; }
            set { jimiHendrix = value; }
        }
        /*
        //--Car Constructor
        public Car(string Make, int Year, bool AllWheelsDrive, Human studentHuman)
        {
            

            
            make = Make;
            year = Year;
            allWheelDrive = AllWheelsDrive;

            mariumShene = studentHuman;
            //--this.jimiHendrix = jimiHendrixMusician;
            
        }
        */
        
    }
}

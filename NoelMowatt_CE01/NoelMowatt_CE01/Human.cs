using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoelMowatt_CE01
{
    class Human
    {
        //--Human Class fields - blueprints
        private int age;
        private char gender;
        private string name;

        //--Two additional blueprints
        private Car maserati;
        private Musician rKelly;


        //--GETTERS & SETTERS--//
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public char Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Car Maserati
        {
            get { return maserati; }
            set { maserati = value; }
        }

        public Musician RKelly
        {
            get { return rKelly; }
            set { rKelly = value; }
        }


        
    }
}

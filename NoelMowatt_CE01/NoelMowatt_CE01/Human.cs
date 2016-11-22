using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoelMowatt_CE01
{
    class Human
    {
        //--Human Class blueprints
        public int age;
        public char gender;
        public string name;
        public bool student;

        //--Two additional blueprints
        Car Maserati;
        Musician RKelly;

        //--Human Constructor
        public Human(int Age, char Gender, string Name, bool Student)
        {
            age = Age;
            gender = Gender;
            name = Name;
            student = Student;
        }
    }
}

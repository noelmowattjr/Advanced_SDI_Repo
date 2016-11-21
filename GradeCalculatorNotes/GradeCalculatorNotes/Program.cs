using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculatorNotes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Primitve type
            // int, bool, char, short, double, float,
            // string
            int myNumber = 5;
            string name = "Sue";
            char oneCharacter = 'A';

            // Reference type
            // Class
            Grade_Calculator gc;
            gc = new Grade_Calculator();
            if (gc == null)
            {
            }

            // Declare a variable
            Grade_Calculator Adam;

            // Instantiate an object of type GradeCalculator
            Adam = new Grade_Calculator("Adam");

            // Declare a varialbe and instantiate an object
            // of type GradeCalculator.
            Grade_Calculator Bob = new Grade_Calculator("Bob");
            Adam._Grades[0] = 100;
            Adam._Grades[1] = 47;
            Adam._Grades[2] = 82;
            Adam._Grades[3] = 70;
            Adam._Grades[4] = 70;
            Adam._Grades[5] = 32;
            Adam._Grades[6] = 60;
            Adam._Grades[7] = 80;
            Adam._Grades[8] = 90;
            Adam._Grades[9] = 47;
            Adam._Grades[10] = 50;
            Adam._Grades[11] = 17;
            Adam._Grades[12] = 23;
            Adam._Grades[13] = 57;
            Adam._Grades[14] = 42;
            Adam._Grades[15] = 80;
            Bob._Grades[0] = 100;
            Bob._Grades[1] = 90;
            Bob._Grades[2] = 82;
            Bob._Grades[3] = 85;
            Bob._Grades[4] = 69;
            Bob._Grades[5] = 70;
            Bob._Grades[6] = 90;
            Bob._Grades[7] = 100;
            Bob._Grades[8] = 90;
            Bob._Grades[9] = 55;
            Bob._Grades[10] = 50;
            Bob._Grades[11] = 47;
            Bob._Grades[12] = 85;
            Bob._Grades[13] = 57;
            Bob._Grades[14] = 90;
            Bob._Grades[15] = 80;

            // cw + tab x 2 fills in Console.WriteLine()
            Console.WriteLine("{0}'s grade was: {1}", Adam._Name, Adam.GetFinalGrade());
            Console.WriteLine("{0}'s grade was: {1}", Bob._Name, Bob.GetFinalGrade(true));
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}

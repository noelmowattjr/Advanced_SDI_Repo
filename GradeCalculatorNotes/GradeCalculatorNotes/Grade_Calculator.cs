using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculatorNotes
{
    class Grade_Calculator
    {
        // Hard coded values should be placed in
        // variables at the top of the file they are
        // used in for ease of modification to the program.
        static int _NumAssignments = 16;
        static int[] _AssignmentWeights =
        {
1, // Course info quiz
10, // Professionalism
5, // CE01
6, // CE02
6, // CE03
5, // Quiz 1
6, // CE04
5, // CE05
10, // CE06
5, // Quiz 2
7, // CE07
7, // CE08
7, // CE09
5, // Quiz 3
10, // Synth
5 // Final
};
        // Declare an array member varialbe of type floats
        public float[] _Grades;
        public string _Name;
        // Default constuctor
        public Grade_Calculator()
        {
            // Instantiate an array of floats and assign it
            // to the _Grades member variable.
            _Grades = new float[_NumAssignments];
        }
        public Grade_Calculator(string Name)
        {
            // Showing the hidden this parameter
            this._Name = Name;
            _Grades = new float[_NumAssignments];
        }
        // Method signature
        // (Access modifer) (return type) (Method Name) (Parameter(s))
        public float GetFinalGrade()
        ///////////////////////////////
        {
            float total = 0;

            // loop through all of the grades and multiply
            // by the assignment weight and total it up
            // to get the final grade.
            for (int i = 0; i < _NumAssignments; ++i)
            {
                total += (_Grades[i] * _AssignmentWeights[i]);
            }
            total /= 100;
            return total;
        }
        // Overload method
        public float GetFinalGrade(bool autoFail)
        {
            float total = 0;

            return total;
        }
    }
}

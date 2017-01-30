using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoelMowatt__CE01
{
    class Paper
    {
        private string _Color;
        private int _NumOfSheets;
        private bool _IsPrintingPaper;

        private Scissors _KindergardenScissor;
        private Rock _BeachRock;

        //--Constructor
        public Paper(string color, int numOfSheets, bool isPrintingPaper)
        {
            _Color = color;
            _NumOfSheets = numOfSheets;
            _IsPrintingPaper = isPrintingPaper;
        }
    }
}

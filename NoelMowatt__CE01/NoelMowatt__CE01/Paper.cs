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

        //--Getters & Setters
        public string GS_color
        {
            get { return _Color; }
            set { _Color = value; }
        }

        public int GS_numOfSheets
        {
            get { return _NumOfSheets; }
            set { _NumOfSheets = value; }
        }

        public bool GS_printablePaper
        {
            get { return _IsPrintingPaper; }
            set { _IsPrintingPaper = value; }
        }
    }
}

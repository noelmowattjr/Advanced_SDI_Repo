using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoelMowatt__CE01
{
    class Rock
    {
        private string _Texture;
        private bool _Roll;
        private int _NumOfSides;

        private Scissors _AdultScissors;
        private Paper _LinedPaper;

        //--Constructor
        public Rock(string texture, bool roll, int numOfSides)
        {
            _Texture = texture;
            _Roll = roll;
            _NumOfSides = numOfSides;
        }

        //--Getters and Setters
        public string GS_texture
        {
            get { return _Texture; }
            set { _Texture = value; }
        }

        public bool GS_roll
        {
            get { return _Roll; }
            set { _Roll = value; }
        }

        public int GS_numOfSides
        {
            get { return _NumOfSides; }
            set { _NumOfSides = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoelMowatt__CE01
{
    class Scissors
    {
        private bool _IsSharp;
        private string _HandleMaterial;
        private int _NumOfBlades;

        private Paper Poster;
        private Rock Stone;

        //--Constructor
        public Scissors(bool isSharp, string materialOfHandle, int numOfBlades)
        {
            _IsSharp = isSharp;
            _HandleMaterial = materialOfHandle;
            _NumOfBlades = numOfBlades;
        }

        //--Getters and Setters
        public bool GS_isSharp
        {
            get { return _IsSharp; }
            set { _IsSharp = value; }
        }

        public string GS_materialOfhandle
        {
            get { return _HandleMaterial; }
            set { _HandleMaterial = value; }
        }

        public int GS_numBlades
        {
            get { return _NumOfBlades; }
            set { _NumOfBlades = value; }
        }
    }
}

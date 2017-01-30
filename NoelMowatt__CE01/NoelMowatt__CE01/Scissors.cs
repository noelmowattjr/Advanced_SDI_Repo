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
    }
}

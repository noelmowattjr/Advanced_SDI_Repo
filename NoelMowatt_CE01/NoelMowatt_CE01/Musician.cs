using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoelMowatt_CE01
{
    class Musician
    {
        //--Musician Class blueprints
        static bool guitarist = true;
        static bool bandMember = true;
        static string genre;
        static int albums;

        //--Two additional blueprints
        Car Ferrari;
        Human NoelMowattJr;

        //--Musician Constructor
        public Musician()
        {
            bool Guitarist = guitarist;
            bool BandMember = bandMember;
            string Genre = genre;
            int Albums = albums;
        }
    }
}

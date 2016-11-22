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
        public bool guitarist = true;
        public bool bandMember = true;
        public string genre;
        public int albums;

        //--Two additional blueprints
        Car Ferrari;
        Human NoelMowattJr;

        //--Musician Constructor
        public Musician(bool Guitarist, bool BandMember, string Genre, int Albums)
        {
            guitarist = Guitarist;
            bandMember = BandMember;
            genre = Genre;
            albums = Albums;
        }
    }
}

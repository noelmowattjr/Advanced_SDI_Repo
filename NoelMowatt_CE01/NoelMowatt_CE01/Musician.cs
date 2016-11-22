using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoelMowatt_CE01
{
    class Musician
    {
        //--Musician Class fields - blueprints
        private bool guitarist = true;
        private string genre;
        private int albums;

        //--Two additional blueprints
        private Car ferrari;
        private Human noelMowattJr;


        //------GETTERS & SETTERS--------//
        public bool Guitarist
        {
            get { return guitarist; }
            set { guitarist = value; }
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public int Albums
        {
            get { return albums; }
            set { albums = value; }
        }

        public Car Ferrari
        {
            get { return ferrari; }
            set { ferrari = value; }
        }

        public Human NoelMowattJr
        {
            get { return noelMowattJr; }
            set { noelMowattJr = value; }
        }

        /*
        //--Musician Constructor
        public Musician(bool Guitarist, bool BandMember, string Genre, int Albums)
        {
            guitarist = Guitarist;
            bandMember = BandMember;
            genre = Genre;
            albums = Albums;
        }
        */
    }
}

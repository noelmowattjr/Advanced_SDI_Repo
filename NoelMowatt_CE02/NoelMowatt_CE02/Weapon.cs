using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoelMowatt_CE02
{
    class Weapon
    {
        static int Swords = 0;

        //--Class member fields
        private int Attack;
        private bool Shield;

        //--Constructor
        public Weapon(int attack, bool shield)
        {
            Swords += 1;
            Attack = attack;
            Shield = shield;
        }

        //---------Getters and Setters------------------//
        public static int Swords_G
        {
            get { return Swords; }
        }

        public int Attack_GS
        {
            get { return Attack; }
            set { Attack = value; }
        }

        public bool Shield_GS
        {
            get { return Shield; }
            set { Shield = value; }
        }
        //-------------------------------------------------//
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoelMowatt_CE02
{
    class Weapon
    {
        //--Class member fields
        private int Attack;
        private int RegenrateHealth;

        //--Constructor
        public Weapon(int attack, int regenerateHealth)
        {
            Attack = attack;
            RegenrateHealth = regenerateHealth;
        }

        //---------Getters and Setters------------------//
        public int Attack_GS
        {
            get { return Attack; }
            set { Attack = value; }
        }

        public int RegenrateHealth_GS
        {
            get { return RegenrateHealth; }
            set { RegenrateHealth = value; }
        }
        //-------------------------------------------------//
    }
}

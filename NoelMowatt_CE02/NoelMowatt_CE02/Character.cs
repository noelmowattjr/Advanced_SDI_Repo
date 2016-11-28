using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoelMowatt_CE02
{
    class Character
    {
        //--Class member fields
        private string Name;
        private int BaseAttack;
        private int Health;
        //--private Weapon Equipped;
        private int Age;
        private char Gender;
        
        //--Constructor--//
        public Character(string name, int baseattack, int health, Weapon equipped, int age, char gender)
        {
            Name = name; BaseAttack = baseattack;
            Health = health; //--Equipped = equipped;
            Age = age; Gender = gender;
        }

        //-----------Getters & Setters-------------//
        public string Name_GS
        {
            get { return Name; }
            set { Name = value; }
        }

        public int BaseAttack_GS
        {
            get { return BaseAttack; }
            set { BaseAttack = value; }
        }

        public int Health_GS
        {
            get { return Health; }
            set { Health = value; }
        }
        /*
        public Weapon Equipped_GS
        {
            get { return Equipped; }
            set { Equipped = value; }
        }
        */
        public int Age_GS
        {
            get { return Age; }
            set { Age = value; }
        }

        public char Gender_GS
        {
            get { return Gender; }
            set { Gender = value; }
        }


    }
}

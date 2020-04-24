using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    abstract class Weapon
    {
        public abstract double Ammunition
        {
            get;
            set;
        }
        public abstract double MaxAmmunition
        {
            get;
            set;
        }

       public abstract double Wear
        {
            get;
            set;
        }
        public abstract void RefillAmmo();

        public abstract void ResetAmmo();

        public abstract double PercentOfAmmo();

        public abstract void RepairWeapon();
        public abstract void BreakWeapon();


    }
}

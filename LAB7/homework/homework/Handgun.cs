using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class Handgun : Weapon 
    {
        public override double Ammunition
        {
            get;
            set;
        }
        public override double MaxAmmunition
        {
            get;
            set;
        }

        public override double Wear
        {
            get;
            set;
        }

        public override void RefillAmmo()
        {
            Ammunition = MaxAmmunition;
        }
        public override void ResetAmmo()
        {
            Ammunition = 0;
        }
        public override void RepairWeapon()
        {
            Wear = 100; 
        }
        public override void BreakWeapon()
        {
            Wear = 0;
        }
        public override double PercentOfAmmo()
        {
            if (this.MaxAmmunition == 0)
                return 0;
            else
                return (Ammunition / MaxAmmunition) * 100;
        }
        public Handgun(double m_ammunition, double m_max, double m_wear)
        {
            Ammunition = m_ammunition;
            MaxAmmunition = m_max;
            Wear = m_wear;
        }
        public override string ToString()
        {
            return "Handgun ammunition " + PercentOfAmmo() + " %." + "\r\n" + "Handgun wear: " + this.Wear + "%." ;
        }
       
    }
}

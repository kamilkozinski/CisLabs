using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class Handgun : Weapon , IAlterAmmunition
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
        public override  IAlterWeapon Addon
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
        public override double PercentOfAmmo()
        {
            if (this.MaxAmmunition == 0)
                return 0;
            else
                return (Ammunition / MaxAmmunition) * 100;
        }
        public Handgun(double m_ammunition, double m_max, IAlterWeapon m_extra)
        {
            Ammunition = m_ammunition;
            MaxAmmunition = m_max;
            Addon = m_extra;
        }
        public override string ToString()
        {
            return "Handgun ammunition " + PercentOfAmmo() + " %." ;
        }
        public void PrintAddonInfo()
        {
            Addon.AddUpgrade();
        }
    }
}

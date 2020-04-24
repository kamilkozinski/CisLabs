using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    abstract class WeaponDecorator : IAlterWeapon
    {
        private IAlterWeapon Extra
        {
            get;
            set;
        }
        public double Weight
        {
            get;
            set;
        }
        public abstract void AddUpgrade();
    }
       

    }


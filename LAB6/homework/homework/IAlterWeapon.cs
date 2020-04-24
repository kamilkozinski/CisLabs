using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    interface IAlterWeapon
    {
        double Weight
        {
            get;
            set;
        }
        void AddUpgrade();
    }

}

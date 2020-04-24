using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class ZoomX4 : IAlterWeapon
    {
        public double Weight
        {
            get;
            set;
        }
        public void AddUpgrade()
        {
            Console.WriteLine("Added X4 telescope zoom ");
        }

    }
}

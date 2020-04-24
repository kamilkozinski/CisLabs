using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class Silencer : IAlterWeapon
    {
        public double Weight
        {
            get;
            set;
        }
        public void AddUpgrade()
        {
            Console.WriteLine("Added extended magazine ");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class UsageCommand : ICommand
    {
        public void Execute(Weapon weapon)
        {
            Random rnd = new Random();
            double ammoUsage = rnd.Next(0,200);
            double weaponUsage = rnd.Next(0, 100);
            weapon.Wear -= weaponUsage;
            weapon.Ammunition -= ammoUsage;
        }
    }
}

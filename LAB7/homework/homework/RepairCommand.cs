using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class RepairCommand : ICommand
    {
        public void Execute(Weapon weapon)
        {
            weapon.RepairWeapon();
        }
    }
}

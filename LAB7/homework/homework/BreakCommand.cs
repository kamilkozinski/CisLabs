using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class BreakCommand : ICommand
    {
        public void Execute(Weapon weapon)
        {
            weapon.BreakWeapon();
        }
    }
}
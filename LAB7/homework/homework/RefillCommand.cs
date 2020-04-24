using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class RefillCommand : ICommand
    {
        public void Execute(Weapon weapon)
        {
            weapon.RefillAmmo();
        }
    }
}

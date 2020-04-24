using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class ResetCommand : ICommand
    {
        public void Execute(Weapon weapon)
        {
            weapon.ResetAmmo();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class ZoomX4Decorator : WeaponDecorator
    {
        private IAlterWeapon Extra
        {
            get;
            set;
        }
        new public double Weight
        {
            get;
            set;
        }
        public override void AddUpgrade()
        {
            Extra.AddUpgrade();
            Console.WriteLine("Added X4 telescope zoom ");
        }
        public ZoomX4Decorator(IAlterWeapon extra)
        {
            this.Extra = extra;
        }

    }
}

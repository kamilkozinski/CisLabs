using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class SilencerDecorator : WeaponDecorator
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
            Console.WriteLine("Added silencer ");
        }
        public SilencerDecorator(IAlterWeapon extra)
        {
            this.Extra = extra;
        }

    }
}

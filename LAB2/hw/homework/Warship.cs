using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    public class Warship : Navigate , Aggresion
    {
        public int PosX
        {
            get;
            set;
        }
        public int PosY
        {
            get;
            set;
        }
        public double Health
        {
            get;
            set;
        }
        public void Move(int shiftX, int shiftY)
        {
            this.PosX += shiftX;
            this.PosY += shiftY;
        }
        public void Attack(Warship obj, double dmg)
        {
            obj.Health -= dmg;  
        }

    }
}

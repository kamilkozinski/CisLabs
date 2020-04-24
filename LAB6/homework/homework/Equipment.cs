using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class Equipment : IAlterAmmunition
    {
        public List<Weapon> eq = new List<Weapon>();

        public List<string> info = new List<string>();
        public void Add(Weapon w)
        {
            eq.Add(w);

        }
        public void RefillAmmo()
        {
            foreach (Weapon element in eq)
            {
                element.RefillAmmo();
                
            }
        }
        public void ResetAmmo()
        {
            foreach (Weapon element in eq)
            {
                element.ResetAmmo();
                
            }

        }
        public override string ToString()
        {
            info.Clear();
            foreach (Weapon element in eq)
            {
                info.Add(element.ToString());
 
            }
            
            return String.Join("\n", info);
            
        }

    }
}

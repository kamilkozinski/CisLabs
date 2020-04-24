using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Przesylka
    {
        private double waga;
        private bool doreczona;
        private bool odebrana;

        public virtual Lokalizacja Status
        {
            get => default;
            set
            {
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Paczka : Przesylka
    {
        private double waga;
        private double wymiarX;
        private double wymiarY;
        private double wymiarZ;
        private bool doreczona;
        private bool odebrana;
        public override Lokalizacja Status
        {
            get => default;
            set
            {
            }
        }
    }
}
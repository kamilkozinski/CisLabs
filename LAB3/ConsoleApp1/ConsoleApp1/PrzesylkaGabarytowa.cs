using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class PrzesylkaGabarytowa : Przesylka
    {
        private double waga;
        private double wymiarX;
        private double wymiarY;
        private double wymiarZ;
        private bool doreczona;
        public override Lokalizacja Status
        {
            get => default;
            set
            {
            }
        }
    }
}
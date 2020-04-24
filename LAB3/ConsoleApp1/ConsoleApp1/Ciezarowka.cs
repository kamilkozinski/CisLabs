using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Ciezarowka : Pojazd
    {
        int id;
        private int pojemnosc;

        public Kurier Kierowca
        {
            get => default;
            set
            {
            }
        }

        public Sortownia Lokalizacja
        {
            get => default;
            set
            {
            }
        }
    }
}
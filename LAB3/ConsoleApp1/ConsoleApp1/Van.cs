using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Van : Pojazd
    {
        int id;
        int przebieg;
        int nrRejestracyjny;
        private int pojemnosc;

   

        public Sortownia Lokalizacja
        {
            get => default;
            set
            {
            }
        }
    }
}
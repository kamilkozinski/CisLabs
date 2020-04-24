using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Klient : Osoba
    {
        private string imie;
        private string nazwisko;
        public void StworzPaczke(double waga, double wymiarX, double wymiarY, double wymiarZ)
        {
            Przesylka paka = new Paczka()
            {
            
            }
            
            ;
        }
        public void StworzList(double waga)
        {}
        public void StworzPrzesylkeGabarytowa(double waga, double wymiarX, double wymiarY, double wymiarZ)
        { }

        public void NadajList(List list,Lokalizacja lokalizacja)
        {
           
        }

        public void NadajPaczke(Paczka paczka, Lokalizacja lokalizacja)
        {
            
        }

        public void NadajPrzesylkeGabarytowa(PrzesylkaGabarytowa przesylka, Lokalizacja lokalizacja)
        {
            
        }
    }
}
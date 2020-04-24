using System;
using System.Collections.Generic;
using System.Text;

namespace lab1._2
{
    class RightTriangle
    {
        // pola klasy przechowujace dlugosci przyprostokatnych
        private double a;
        private double b;

        // wlasciwosci klasy odpowiadajace powyzszym polom
        public double A
        {
            get { return a; } // prosty getter - tylko zwraca wartosc
            set // setter - pozwoli ustawic wartosc tylko jesli jest dodatnia
            {
                if (value > 0) a = value; // prosze zwrocic uwage na slowo kluczowe value
            }
        }
        public double B
        {
            get { return b; } // prosty getter - tylko zwraca wartosc
            set // setter - pozwoli ustawic wartosc tylko jesli jest dodatnia
            {
                if (value > 0) b = value;
            }
        }
        public double Color
        {
            get;
            set;
        }
        // metoda klasy obliczajaca tangens kata w trojkacie A/B
        public double ComputeTangent()
        {
            return A / B;
        }
        private double ComputeC()
        {
            return Math.Sqrt(A * A + B * B);
        }
        public double ComputeSine()
        {
            return ComputeC() / A;
        }
        public double Circumfence
        {
            get 
            {
                return a + b + ComputeC();
            }
          
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class CarForSale
    {
        public string Make
        {
            get;
            set;
        }
        public string Model
        {
            get;
            set;
        }
        public int ProductionYear
        {
            get;
            set;
        }
        public int Mileage
        {
            get;
            set;
        }
        public bool Damaged
        {
            get;
            set;
        }
        public double Price
        {
            get;

        }
        public CarForSale()
        {
            Make = "Unknown";
            Model = "Unknown";
            ProductionYear = 0;
            Mileage = 0;
            Damaged = false;
            Price = 0;

        }
        public CarForSale(string m_make, string m_model, int m_productionYear, int m_mileage, bool m_damaged, double m_price)
        {
            Make = m_make;
            Model = m_model;
            if (m_productionYear > 1800) { ProductionYear = m_productionYear; }
            if (m_mileage >= 0) { Mileage = m_mileage; }
            Damaged = m_damaged;
            if (m_price >= 1) { Price = m_price; }


        }
        public string PrintCarInfo()
        {
            return "Make:" + Make + " Model:" + Model + " Mileage:" + Mileage;

        }

    }
}

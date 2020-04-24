using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class CarSaloon
    {
        public CarForSale Car
        {
            get;
            set;
        }
        public CarSaloon(CarForSale obj)
        {
            Car = obj;
        }
    }
}

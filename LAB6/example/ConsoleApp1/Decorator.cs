using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    abstract class Decorator : IWeatherAlert
    {
        private IWeatherAlert Dec
        {
            get;
            set;
        }
        public string CurrentDate { get; set; }
        public virtual void Alert()
        {

        }
      
    }
}

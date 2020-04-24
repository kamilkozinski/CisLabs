using System;
using System.Collections.Generic;
using System.Text;

namespace C6
{
    class SnowDecorator : Decorator
    {
        private IWeatherAlert Dec
        {
            get;
            set;
        }
        new public string CurrentDate { get; set; }
        public override void Alert()
        {
            Dec.Alert();
            Console.WriteLine("Today expexted: sniw");
        }
        public SnowDecorator(IWeatherAlert alert)
        {
            this.Dec = alert;
        }

    }
}

using System;

namespace C6
{
	interface IWeatherAlert
    {
        string CurrentDate { get; set; }
        void Alert();
    }

    class NoAlert : IWeatherAlert
    {
        public string CurrentDate { get; set; }
        public void Alert() { }
    }
    class RainAlert : IWeatherAlert
    {
        public string CurrentDate { get; set; }
        public void Alert()
        {
            Console.WriteLine("Today expexted: rain");
        }
    }
    class SnowAlert : IWeatherAlert
    {
        public string CurrentDate { get; set; }
        public void Alert()
        {
            Console.WriteLine("Today expexted: snow");
        }
    }
    class Windlert : IWeatherAlert
    {
        public string CurrentDate { get; set; }
        public void Alert()
        {
            Console.WriteLine("Today expexted: wind");
        }
    }
    class StormAlert : IWeatherAlert
    {
        public string CurrentDate { get; set; }
        public void Alert()
        {
            Console.WriteLine("Today expexted: storm");
        }
    }
}
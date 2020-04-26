using System;
using System.Collections.Generic;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            MySubscriptions myList = new MySubscriptions();
            YoutubeChannel channel1 = new YoutubeChannel("ElectroBOOM", "Science");
            YoutubeChannel channel2 = new YoutubeChannel("Techzone", "Science");
            YoutubeChannel channel3 = new YoutubeChannel("VEVO", "Entertainment");

            myList.Subscribed(channel1);
            myList.Subscribed(channel2);
            myList.Subscribed(channel3);

            myList.UpdateMeOnMyChannels();

            List<int> numbers = new List<int> { 2, 5, 7, 10, 15, 200 };
            MinimumFinder minFinder = new MinimumFinder();
            minFinder.SetStrategy(new FindMinimumByLoop());
            Console.WriteLine($"Minimum value: {minFinder.FindMin(numbers)} found using first method.");
            minFinder.SetStrategy(new FindMinimumLINQ());
            Console.WriteLine($"Minimum value: {minFinder.FindMin(numbers)} found using different method.");

        }

    }
}

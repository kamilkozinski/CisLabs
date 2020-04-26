using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class MySubscriptions : IChannel
    {
        public List<YoutubeChannel> observers;


        public void Subscribed(YoutubeChannel observer)
        {
            observers.Add(observer);
        }
        public void Unsubscribed(YoutubeChannel observer)
        {
            observers.Remove(observer);
        }
        public void UpdateMeOnMyChannels()
        {
            foreach (YoutubeChannel obs in observers)
            {
                if(obs.videoCategory == "Science")
                obs.Update();
            }
        }
        public MySubscriptions()
        {
            observers = new List<YoutubeChannel>();
        }
    }
}

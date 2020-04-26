using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    interface IChannel
    {
        void Subscribed(YoutubeChannel observer);
        void Unsubscribed(YoutubeChannel observer);
        void UpdateMeOnMyChannels();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    class YoutubeChannel
    {
       
       public string channelName;
       public string videoCategory;
        public YoutubeChannel(string chanel, string category)
        {
            
            channelName = chanel;
            videoCategory = category;
        }
        public void Update()
        {
            Console.WriteLine("Channel " + channelName + " uploaded new video!");
        }

    }
}

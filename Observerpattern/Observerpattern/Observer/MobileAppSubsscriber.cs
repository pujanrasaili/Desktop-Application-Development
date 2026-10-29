using System;
using System.Collections.Generic;
using System.Text;

namespace Observerpattern.Observer
{
    internal class MobileAppSubscriber : ISubscriber
    {
        private readonly String _username;
        public MobileAppSubscriber(string username)
        {
            _username = username;
        }

        public void Update(string channelName, string videoTitle)
        {
            Console.WriteLine($"\n>>> {_username} received Mobile APP Notification." + $"{channelName}has uploaded a new video: \"{videoTitle}\"");
        }
    }
}

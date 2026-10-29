using Observerpattern.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observerpattern.Subject
{
    internal class YouTubeChannel: IChannel
    {
        private readonly List <ISubscriber>_subscribers = new List<ISubscriber>();
        private readonly string _channelName;
        public YouTubeChannel(string channelName)
        {
            _channelName = channelName;
        }

        public void Subscribe(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
            Console.WriteLine($"[+] New Subscriber Added to {_channelName}");
        }

        public void Unsubscribe(ISubscriber subscriber)
        {

            _subscribers.Remove(subscriber);
            Console.WriteLine($"[-] Subscriber Removed from {_channelName}");
        }

        public void NotifySubscribers(string videoTitle)
        {
            foreach (var subscriber in _subscribers)
            {
                subscriber.Update(_channelName, videoTitle);
            }
        }

        public void UploadVideo(string videoTitle)
        {
            Console.WriteLine($"\n>>> {_channelName} uploaded a new video: \"{videoTitle}\"");
            NotifySubscribers(videoTitle);
        }
    }
}

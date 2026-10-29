using Observerpattern.Observer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observerpattern.Subject
{
    internal interface IChannel
    {
        void Subscribe(ISubscriber subscriber);
        void Unsubscribe(ISubscriber subscriber);
        void NotifySubscribers(string videoTitle);
    }
}

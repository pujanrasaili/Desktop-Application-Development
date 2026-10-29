using System;
using System.Collections.Generic;
using System.Text;

namespace Observerpattern.Observer
{
    internal interface ISubscriber
    {
        void Update(string channelName, string videoTitle);

    }
}

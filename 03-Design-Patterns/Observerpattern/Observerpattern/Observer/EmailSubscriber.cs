using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Observerpattern.Observer
{
    internal class EmailSubscriber: ISubscriber
    {
        private readonly string _email;
        public EmailSubscriber(string email)
            { _email = email;
        }
        
        public void Update(string channelName, string videoTitle)
            {
                Console.WriteLine($"\n>>> {_email} uploaded a new video: \"{videoTitle}\"");
            }
    }
}

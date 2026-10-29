using Observerpattern.Observer;
using Observerpattern.Subject;

namespace Observerpattern
{
    internal class Program
{
    static void Main(string[] args)
    {
        // Create a YouTube channel
        var channel = new Subject.YouTubeChannel("TechWorld");
        // Create subscribers
        var subscriber1 = new MobileAppSubscriber("Alice");
        var subscriber2 = new MobileAppSubscriber("Bob");
        // Subscribe to the channel
        channel.Subscribe(subscriber1);
        channel.Subscribe(subscriber2);
        // Upload a video
        channel.UploadVideo("Introduction to Observer Pattern");
        // Unsubscribe a subscriber
        channel.Unsubscribe(subscriber1);
        // Upload another video
        channel.UploadVideo("Advanced Observer Pattern Techniques");
    }
}
}
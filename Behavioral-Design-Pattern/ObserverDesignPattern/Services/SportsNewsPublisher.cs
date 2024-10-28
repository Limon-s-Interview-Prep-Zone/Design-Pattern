using System;
using System.Collections.Generic;

namespace ObserverDesignPattern.Services
{
    /*
     *
     * Imagine you are building a news app that delivers breaking news to subscribers.
     * Users can subscribe to topics like Politics, Sports, Technology, or Entertainment.
     * Whenever there’s new content on a topic, subscribers are notified immediately.
     */
    internal static class SportsNewsPublisherFactory
    {
        internal static void DriverCode()
        {
            INewsPublisher publisher = new SportsNewsPublisher();

            var user1 = new Subscriber("Limon");
            var user2 = new Subscriber("Bob");
            publisher.Subscribe(user1);
            publisher.Subscribe(user2);

            //publish message
            publisher.NotifySubscribers("Breaking: Local team wins championship!");
            publisher.Unsubscribe(user2);
            publisher.NotifySubscribers("Shocking: Barcelona wins championship!");
        }
    }

    // Subject or publisher that manage subscription
    internal interface INewsPublisher
    {
        void Subscribe(ISubscriber observer);
        void Unsubscribe(ISubscriber observer);
        void NotifySubscribers(string news);
    }

    public class SportsNewsPublisher : INewsPublisher
    {
        private readonly List<ISubscriber> subscribers = new();

        public void Subscribe(ISubscriber observer)
        {
            subscribers.Add(observer);
        }

        public void Unsubscribe(ISubscriber observer)
        {
            subscribers.Remove(observer);
        }

        public void NotifySubscribers(string news)
        {
            foreach (var subscriber in subscribers) subscriber.ReceiveNews(news);
        }
    }

    // Observer interface
    public interface ISubscriber
    {
        string Name { get; }
        void ReceiveNews(string news);
    }

    // Concrete Observer or subscriber
    public class Subscriber : ISubscriber
    {
        public Subscriber(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public void ReceiveNews(string news)
        {
            Console.WriteLine($"{Name} received: {news}");
        }
    }
}
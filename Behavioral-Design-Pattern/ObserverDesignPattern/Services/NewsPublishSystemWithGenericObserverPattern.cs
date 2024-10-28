using System;

namespace ObserverDesignPattern.Services
{
    // Concrete Subscriber Implementation
    public class UserSubscriber : IGenericSubscriber<string, string>
    {
        public void ReceivedMessage(string message, string userDetails)
        {
            Console.WriteLine($"User '{userDetails}' received message: {message}");
        }
    }

    public enum NewsType
    {
        Sports,
        Politics,
        Technology
    }

    public class NewsPublishSystemWithGenericObserverPattern
    {
        internal static void DriverCode()
        {
            // Create a publisher with enum keys
            var enumPublisher = new GenericPublisher<string, string, NewsType>();

            var user1 = new UserSubscriber();
            var user2 = new UserSubscriber();

            // Subscribing users to different topics
            enumPublisher.Subscribe(user1);
            enumPublisher.Subscribe(user2, NewsType.Technology);

            // Notify subscribers
            enumPublisher.NotifySubscribers("Big game tonight!", "Alice");
            enumPublisher.NotifySubscribers("New AI chip released.", "Bob", NewsType.Technology);

            // Create a publisher without using enums (using string-based keys)
            var stringPublisher = new GenericPublisher<string, string, string>();

            stringPublisher.Subscribe(user1, "General News");
            stringPublisher.NotifySubscribers("General News", "This is a general announcement.", "Charlie");
        }
    }
}
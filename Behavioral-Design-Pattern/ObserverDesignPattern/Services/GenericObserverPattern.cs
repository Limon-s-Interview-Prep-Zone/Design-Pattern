using System;
using System.Collections.Generic;

namespace ObserverDesignPattern.Services
{
    #region Generic Observer Pattern

    internal interface IGenericPublisher<TMessage, TUser, in TKey>
    {
        void Subscribe(IGenericSubscriber<TMessage, TUser> subscriber, TKey? key = default);
        void Unsubscribe(IGenericSubscriber<TMessage, TUser> subscriber, TKey? key = default);
        void NotifySubscribers(TMessage message, TUser user, TKey? key = default);
    }

    internal interface IGenericSubscriber<TMessage, TUser>
    {
        void ReceivedMessage(TMessage message, TUser user);
    }

    internal class GenericPublisher<TMessage, TUser, TKey> : IGenericPublisher<TMessage, TUser, TKey>
    {
        private readonly Dictionary<TKey, List<IGenericSubscriber<TMessage, TUser>>> _subscribers;

        public GenericPublisher()
        {
            _subscribers = new Dictionary<TKey, List<IGenericSubscriber<TMessage, TUser>>>();
            // If TKey is an enum, initialize dictionary with enum values.
            if (typeof(TKey).IsEnum)
                foreach (TKey key in Enum.GetValues(typeof(TKey)))
                    _subscribers[key] = new List<IGenericSubscriber<TMessage, TUser>>();
        }

        public void Subscribe(IGenericSubscriber<TMessage, TUser> subscriber, TKey? key = default)
        {
            if (key == null)
            {
                Console.WriteLine("Subscription failed: Key cannot be null.");
                return;
            }

            if (!_subscribers.ContainsKey(key)) _subscribers[key] = new List<IGenericSubscriber<TMessage, TUser>>();

            _subscribers[key].Add(subscriber);
            Console.WriteLine($"{subscriber.GetType().Name} subscribed to {key}.");
        }

        public void Unsubscribe(IGenericSubscriber<TMessage, TUser> subscriber, TKey? key = default)
        {
            if (key != null && _subscribers.TryGetValue(key, out var list))
            {
                list.Remove(subscriber);
                Console.WriteLine($"{subscriber.GetType().Name} unsubscribed from {key}.");
            }
            else
            {
                Console.WriteLine("Unsubscription failed: Invalid key.");
            }
        }

        public void NotifySubscribers(TMessage message, TUser user, TKey? key = default)
        {
            if (key != null && _subscribers.TryGetValue(key, out var list))
            {
                Console.WriteLine($"\nBroadcasting {key} news: {message}");
                foreach (var subscriber in list) subscriber.ReceivedMessage(message, user);
            }
            else
            {
                Console.WriteLine("No subscribers for this key.");
            }
        }
    }

    #endregion GenericObserver Pattern
}
using System;
using System.Collections.Generic;

namespace ObserverDesignPattern.Services
{
    internal class NotificationSystem
    {
        internal static void DriverMethod()
        {
            var Limon = new User("Limon");
            var Likhon = new User("Likhon");
            var saad = new Follower("Saad");
            var sarah = new Follower("Sarah");
            Limon.Subscribe(saad); // saad follows Limon
            Likhon.Subscribe(sarah); // sarah follows Likhon
            Limon.Subscribe(sarah); // sarah follows Limon
            Limon.PostMessage("Hello from Limon!");
            Likhon.PostMessage("Rout's first post.");
        }
    }

    /// <summary>
    ///     Observer Interface
    /// </summary>
    public interface IObserver
    {
        void Update(User user, string message);
    }

    /// <summary>
    ///     Concrete Observer: Follower
    /// </summary>
    public class Follower : IObserver
    {
        public Follower(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public void Update(User user, string message)
        {
            Console.WriteLine($"{Name} received a new post from {user.Name}: {message} time: {DateTime.Now}");
        }
    }

    /// <summary>
    ///     Subject Interface
    /// </summary>
    public interface IUserSubject
    {
        void Subscribe(IObserver observer);
        void UnSubscribe(IObserver observer);
        void NotifyObservers(string message);
    }


    public class User : IUserSubject
    {
        private readonly List<IObserver> _observers = new();

        public User(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public void Subscribe(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void UnSubscribe(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers(string message)
        {
            _observers.ForEach(observer =>
                observer.Update(this, message));
        }

        public void PostMessage(string message)
        {
            Console.WriteLine($"{Name} posted: {message}");
            NotifyObservers(message);
        }
    }
}
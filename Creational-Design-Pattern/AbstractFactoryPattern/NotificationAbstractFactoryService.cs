using System;
using System.Collections.Generic;
using System.Linq;

namespace AbstractFactoryPattern
{

    /// <summary>
    /// Product Interface
    /// </summary>
    public interface INotificationService
    {
        void Send(string message);
    }

    // Concrete EmailNotificationService Implementation
    public class EmailNotificationService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }

    // Concrete SMSNotificationService Implementation
    public class SMSNotificationService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS sent: {message}");
        }
    }

    #region Factory Method

    // Factories Interfaces: Each factory will create a specific notification service.
    public interface INotificationServiceFactory
    {
        INotificationService CreateNotificationService();
    }
    
    // Concrete Service Factory
    public class EmailNotificationServiceFactory : INotificationServiceFactory
    {
        public INotificationService CreateNotificationService()
        {
            return new EmailNotificationService();
        }
    }

    // Concrete Service Factory
    public class SMSNotificationServiceFactory : INotificationServiceFactory
    {
        public INotificationService CreateNotificationService()
        {
            return new SMSNotificationService();
        }
    }

    #endregion Factory Method
    

    #region Abstract Factory
    /// <summary>
    /// Abstract Factory Method: which will be responsible for creating
    /// However, the bellow example does not maintain open-closed principals
    /// </summary>
    public interface INotificationFactory
    {
        INotificationServiceFactory CreateEmailNotificationServiceFactory();
        INotificationServiceFactory CreateSMSNotificationServiceFactory();
    }


    // Implementations of Factories
    public class NotificationFactory : INotificationFactory
    {
        public INotificationServiceFactory CreateEmailNotificationServiceFactory()
        {
            return new EmailNotificationServiceFactory();
        }

        public INotificationServiceFactory CreateSMSNotificationServiceFactory()
        {
            return new SMSNotificationServiceFactory();
        }
    }
    
    /// <summary>
    /// This follow code will automatically add appropriate services based on given type
    /// </summary>
    public interface INotificationFactoryWithSolid
    {
        INotificationServiceFactory GetFactory(string notificationType);
    }

    public class NotificationFactoryWithSolid : INotificationFactoryWithSolid
    {
        private readonly IEnumerable<INotificationServiceFactory> _factories;

        // Constructor injection using ASP.NET Core DI
        public NotificationFactoryWithSolid(IEnumerable<INotificationServiceFactory> factories)
        {
            _factories = factories;
        }

        // Returns the appropriate factory based on the notification type
        public INotificationServiceFactory GetFactory(string notificationType)
        {
            return _factories.FirstOrDefault(f =>
                       f.GetType().Name.Contains(notificationType, StringComparison.OrdinalIgnoreCase))
                   ?? throw new ArgumentException("Invalid notification type.");
        }
    }

    #endregion end of Abstract Factory
}
using System;

namespace DecoratorPattern.Services
{
    public interface INotificationService
    {
        void Send(string message);
    }

    public class BasicNotificationService : INotificationService
    {
        public void Send(string message)
        {
            Console.WriteLine($"[BASIC] Sending message: {message}");
        }
    }

    public abstract class NotificationServiceDecorator : INotificationService
    {
        private readonly INotificationService _notificationService;

        protected NotificationServiceDecorator(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        public virtual void Send(string message)
        {
            _notificationService.Send(message);
        }
    }

    public class EmailNotificationServiceDecorator : NotificationServiceDecorator
    {
        public EmailNotificationServiceDecorator(INotificationService notificationService) : base(notificationService)
        {
        }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine($"[EMAIL] Sending email: {message}");
        }
    }
}
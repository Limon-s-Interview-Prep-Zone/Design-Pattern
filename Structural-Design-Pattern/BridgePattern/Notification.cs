using System;

namespace BridgePattern
{
    public interface INotificationSender
    {
        void Send(string message);
    }
    
    public class EmailSender : INotificationSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending Email Notification: {message}");
        }
    }

    public class SmsSender : INotificationSender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending SMS Notification: {message}");
        }
    }
    
    /// <summary>
    /// Create a abstraction
    /// </summary>
    public abstract class Notification
    {
        protected readonly INotificationSender _notificationSender;

        protected Notification(INotificationSender notificationSender)
        {
            _notificationSender = notificationSender;
        }

        public abstract void SendNotification(string message);
    }

    public class AlertNotification : Notification
    {
        public AlertNotification(INotificationSender notificationSender) : base(notificationSender) { }

        public override void SendNotification(string message)
        {
            Console.WriteLine("Alert Notification:");
            _notificationSender.Send(message);
        }
    }

    public class ReminderNotification : Notification
    {
        public ReminderNotification(INotificationSender notificationSender) : base(notificationSender) { }

        public override void SendNotification(string message)
        {
            Console.WriteLine("Reminder Notification:");
            _notificationSender.Send(message);
        }
    }

    public class PromotionNotification : Notification
    {
        public PromotionNotification(INotificationSender notificationSender) : base(notificationSender) { }

        public override void SendNotification(string message)
        {
            Console.WriteLine("Promotion Notification:");
            _notificationSender.Send(message);
        }
    }

}
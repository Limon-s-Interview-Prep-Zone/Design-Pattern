using System;
using System.Collections.Generic;

namespace CommandPattern.Services
{
    public class FactoryNotificationSystem
    {
        internal static void DriverMethod()
        {
            // Create the receiver (Notification Service)
            var notificationService = new NotificationService();

            // Create concrete commands
            var emailCommand = new EmailNotificationCommand(notificationService);
            var smsCommand = new SmsNotificationCommand(notificationService);
            var pushCommand = new PushNotificationCommand(notificationService);

            // Create the invoker
            var invoker = new NotificationInvoker();

            // Add commands to the invoker's queue
            invoker.AddCommand(emailCommand);
            invoker.AddCommand(smsCommand);
            invoker.AddCommand(pushCommand);

            // Execute all commands
            Console.WriteLine("Executing all notifications:");
            invoker.ExecuteCommands();
        }
    }

    public interface ICommand
    {
        void Execute();
    }

    public class NotificationService
    {
        public void SendEmail(string message)
        {
            Console.WriteLine(message);
        }

        public void SendSms(string message)
        {
            Console.WriteLine(message);
        }

        public void SendPush(string message)
        {
            Console.WriteLine(message);
        }
    }

    public class EmailNotificationCommand : ICommand
    {
        private readonly NotificationService _service;

        public EmailNotificationCommand(NotificationService service)
        {
            _service = service;
        }

        public void Execute()
        {
            _service.SendEmail("Sending email notification...");
        }
    }

    public class PushNotificationCommand : ICommand
    {
        private readonly NotificationService _service;

        public PushNotificationCommand(NotificationService service)
        {
            _service = service;
        }

        public void Execute()
        {
            _service.SendPush("Sending push notification...");
        }
    }

    public class SmsNotificationCommand : ICommand
    {
        private readonly NotificationService _service;

        public SmsNotificationCommand(NotificationService service)
        {
            _service = service;
        }

        public void Execute()
        {
            _service.SendSms("Sending SMS notification...");
        }
    }

    public class NotificationInvoker
    {
        private readonly List<ICommand> _commands = new();

        public void AddCommand(ICommand command)
        {
            _commands.Add(command);
        }

        public void ExecuteCommands()
        {
            foreach (var command in _commands) command.Execute();
            _commands.Clear();
        }
    }
}
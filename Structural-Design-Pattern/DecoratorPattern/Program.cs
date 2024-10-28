using System;
using DecoratorPattern.Services;

namespace DecoratorPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IUserService userService = new UserService();

            userService = new AuthenticationDecorator(userService, true);
            userService = new AuthorizationDecorator(userService, "Admin", "admin");

            try
            {
                Console.WriteLine(userService.GetUserDetails(1));
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            // Notification Service
            INotificationService notificationService = new BasicNotificationService();
            notificationService = new EmailNotificationServiceDecorator(notificationService);
            notificationService.Send("You have an interview in the very next day");
        }
    }
}
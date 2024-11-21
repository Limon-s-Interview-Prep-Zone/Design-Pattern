using System;

namespace PrototypePattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var templateFactory = new EmailTemplateFactory();
            IEmailService emailService = new EmailService(templateFactory);

            // Send a welcome email
            Console.WriteLine("Sending Welcome Email:");
            emailService.SendEmail("WelcomeEmail", "John Doe");
            emailService.SendEmail("WelcomeEmail", "Limon");

            // Send a password reset email
            Console.WriteLine("\nSending Password Reset Email:");
            emailService.SendEmail("PasswordResetEmail", "Jane Smith", "https://example.com/reset");
        }
    }
}
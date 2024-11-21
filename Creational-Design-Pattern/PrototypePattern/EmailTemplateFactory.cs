using System;
using System.Collections.Generic;

namespace PrototypePattern
{
    public interface IEmailTemplatePrototype
    {
        string Subject { get; set; }
        IEmailTemplatePrototype Clone();
        string GetContent();
    }

    /// <summary>
    ///     Concrete Welcome Email
    /// </summary>
    public class WelcomeEmail : IEmailTemplatePrototype
    {
        public string Content { get; set; } = "Dear [UserName], thank you for joining us!";
        public string Subject { get; set; } = "Welcome to Our Service!";

        public IEmailTemplatePrototype Clone()
        {
            var temp = (IEmailTemplatePrototype)MemberwiseClone();
            return temp;
        }

        public string GetContent()
        {
            return Content;
        }
    }

    /// <summary>
    ///     Concrete Password Reset Email
    /// </summary>
    public class PasswordResetEmail : IEmailTemplatePrototype
    {
        public string Content { get; set; } =
            "Hello [UserName], please use the following link to reset your password: [Link]";

        public string Subject { get; set; } = "Password Reset Request";

        public IEmailTemplatePrototype Clone()
        {
            var temp = (IEmailTemplatePrototype)MemberwiseClone();
            return temp;
        }

        public string GetContent()
        {
            return Content;
        }
    }

    /// <summary>
    ///  Prototype registry
    /// </summary>
    public class EmailTemplateFactory
    {
        private readonly Dictionary<string, IEmailTemplatePrototype> _templates = new();

        public EmailTemplateFactory()
        {
            _templates["WelcomeEmail"] = new WelcomeEmail();
            _templates["PasswordResetEmail"] = new PasswordResetEmail();
        }

        public IEmailTemplatePrototype GetTemplate(string templateType)
        {
            var temp = _templates[templateType].Clone();
            return temp;
        }
    }

    public interface IEmailService
    {
        public string SendEmail(string templateType, string userName, string link = null);
    }
    /// <summary>
    /// Client Code
    /// </summary>
    public class EmailService: IEmailService
    {
        private readonly EmailTemplateFactory _templateFactory;

        public EmailService(EmailTemplateFactory templateFactory)
        {
            _templateFactory = templateFactory;
        }

        public string SendEmail(string templateType, string userName, string link = null)
        {
            var template = _templateFactory.GetTemplate(templateType);

            // Customize the cloned template with user data
            var content = template.GetContent().Replace("[UserName]", userName);

            if (link != null) content = content.Replace("[Link]", link);

            // Simulate sending an email
            Console.WriteLine($"Sending Email - Subject: {template.Subject}, Content: {content}");

            return content; // For testing purposes
        }
    }
}
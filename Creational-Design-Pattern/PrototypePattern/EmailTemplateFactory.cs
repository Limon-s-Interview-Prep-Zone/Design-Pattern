using System;
using System.Collections.Generic;

namespace PrototypePattern
{
    public interface IEmailTemplatePrototype
    {
        IEmailTemplatePrototype Clone();
        string Subject { get; set; }
        string GetContent();
    }
    
    public class WelcomeEmail : IEmailTemplatePrototype
    {
        public string Subject { get; set; } = "Welcome to Our Service!";
        public string Content { get; set; } = "Dear [UserName], thank you for joining us!";

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
    public class PasswordResetEmail : IEmailTemplatePrototype
    {
        public string Subject { get; set; } = "Password Reset Request";
        public string Content { get; set; } = "Hello [UserName], please use the following link to reset your password: [Link]";

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
    
    public class EmailService
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
            string content = template.GetContent().Replace("[UserName]", userName);

            if (link != null)
            {
                content = content.Replace("[Link]", link);
            }

            // Simulate sending an email
            Console.WriteLine($"Sending Email - Subject: {template.Subject}, Content: {content}");
        
            return content; // For testing purposes
        }
    }

}
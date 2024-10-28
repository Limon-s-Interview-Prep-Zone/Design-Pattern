namespace BridgePattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            INotificationSender emailSender = new EmailSender();
            INotificationSender smsSender = new SmsSender();

            Notification alertNotification = new AlertNotification(emailSender);
            alertNotification.SendNotification("This is an alert notification via Email.");
        }
    }
}
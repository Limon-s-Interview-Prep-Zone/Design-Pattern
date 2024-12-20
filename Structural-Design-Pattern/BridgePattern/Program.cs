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
            
            // payment gateway

            IPaymentGateway paypalGateway = new PaypalGateway();
            Payment onlinePayment = new OnlinePayment(paypalGateway);
            onlinePayment.ProcessPayment(12.2m);
        }
    }
}
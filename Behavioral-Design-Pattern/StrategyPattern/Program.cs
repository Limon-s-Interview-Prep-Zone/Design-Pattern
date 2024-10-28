using StrategyPattern.Services;

namespace StrategyPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var paymentService = new PaymentService(new CreditCardPayment());

            // Process payment using Credit Card
            paymentService.Pay(100.50m);

            // Switch to PayPal payment
            paymentService.SetPaymentStrategy(new PaypalPayment());
            paymentService.Pay(75.25m);

            // Switch to Bank Transfer payment
            paymentService.SetPaymentStrategy(new BankTransferPayment());
            paymentService.Pay(150.00m);
        }
    }
}
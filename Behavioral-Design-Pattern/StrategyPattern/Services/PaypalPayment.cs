using System;

namespace StrategyPattern.Services
{
    public class PaypalPayment : IPaymentStrategy
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Paypal card payment of {amount:C}.");
        }
    }
}
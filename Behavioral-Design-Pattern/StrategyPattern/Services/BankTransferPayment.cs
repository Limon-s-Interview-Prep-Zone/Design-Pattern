using System;

namespace StrategyPattern.Services
{
    public class BankTransferPayment : IPaymentStrategy
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine($"Processing Bank transfer payment of {amount:C}.");
        }
    }
}
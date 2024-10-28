namespace StrategyPattern.Services
{
    public class PaymentService
    {
        private IPaymentStrategy _paymentStrategy;

        public PaymentService(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void SetPaymentStrategy(IPaymentStrategy strategy)
        {
            _paymentStrategy = strategy;
        }

        public void Pay(decimal amount)
        {
            _paymentStrategy.ProcessPayment(amount);
        }
    }
}
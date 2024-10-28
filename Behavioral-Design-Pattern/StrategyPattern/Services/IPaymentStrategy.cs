namespace StrategyPattern.Services
{
    public interface IPaymentStrategy
    {
        void ProcessPayment(decimal amount);
    }
}
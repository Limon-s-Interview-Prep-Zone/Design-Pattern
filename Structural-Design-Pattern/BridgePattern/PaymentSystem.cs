using System;

namespace BridgePattern
{
    public interface IPaymentGateway
    {
        void MakePayment(decimal amount);
    }
    public class PaypalGateway: IPaymentGateway
    {
        public void MakePayment(decimal amount)
        {
           Console.WriteLine($"Paypal: {amount}");
        }
    }

    public class StripGateway : IPaymentGateway
    {
        public void MakePayment(decimal amount)
        {
            Console.WriteLine($"Stripe: {amount}");
        }
    }

    public abstract class Payment
    {
        private readonly IPaymentGateway _gateway;

        protected Payment(IPaymentGateway gateway)
        {
            _gateway = gateway;
        }

        public abstract void ProcessPayment(decimal amount);
    }

    public class OnlinePayment:Payment
    {
        private readonly IPaymentGateway _gateway;

        public OnlinePayment(IPaymentGateway gateway): base(gateway)
        {
            _gateway = gateway;
        }

        public override void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Initiating online payment...");
            _gateway.MakePayment(amount);
        }
    }
}
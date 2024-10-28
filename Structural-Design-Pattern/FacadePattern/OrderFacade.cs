using System;

namespace FacadePattern
{
    public class OrderFacade
    {
        private readonly InventoryManager _inventoryManager;
        private readonly PaymentProcessor _paymentProcessor;
        private readonly ShippingService _shippingService;

        public OrderFacade()
        {
            _inventoryManager = new InventoryManager();
            _paymentProcessor = new PaymentProcessor();
            _shippingService = new ShippingService();
        }

        public void PlaceOrder(string item, string creditCard, decimal amount)
        {
            if (!_inventoryManager.CheckStock(item))
            {
                Console.WriteLine("Item is out of stock.");
                return;
            }

            _inventoryManager.ReserveItem(item);
            if (_paymentProcessor.ProcessPayment(creditCard, amount))
            {
                _shippingService.ShipItem(item);
                Console.WriteLine("Order placed successfully!");
            }
            else
            {
                Console.WriteLine("Payment failed. Order could not be completed.");
            }
        }
    }

    // Inventory Management Subsystem
    public class InventoryManager
    {
        public bool CheckStock(string item)
        {
            Console.WriteLine($"Checking stock for {item}");
            return true; // Assume the item is in stock
        }

        public void ReserveItem(string item)
        {
            Console.WriteLine($"Reserving {item} in inventory");
        }
    }

    // Payment Processing Subsystem
    public class PaymentProcessor
    {
        public bool ProcessPayment(string creditCard, decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount} on card {creditCard}");
            return true; // Assume payment is successful
        }
    }

    // Shipping Subsystem
    public class ShippingService
    {
        public void ShipItem(string item)
        {
            Console.WriteLine($"Shipping {item} to customer");
        }
    }
}
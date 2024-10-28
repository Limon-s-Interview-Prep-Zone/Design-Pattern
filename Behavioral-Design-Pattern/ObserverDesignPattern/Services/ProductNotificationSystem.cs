using System;
using System.Collections.Generic;

/*
an e-commerce platform notifies all users (observers) when a product’s status (subject) is updated.
This could involve changes in availability, such as "In Stock," "Out of Stock," or "Coming Soon."
*/
namespace ObserverDesignPattern.Services
{
    public class ProductNotificationSystem
    {
        internal static void DriverMethod()
        {
            var product = new Product(1, "IMAC", 300);
            var productPublisher = new ProductPublisher();
            IWatcher<Product> productSubscriber1 = new ProductSubscriber("Limon");
            IWatcher<Product> productSubscriber2 = new ProductSubscriber("XXXX");

            productPublisher.RegisterObserver(productSubscriber1);
            productPublisher.RegisterObserver(productSubscriber2);

            productPublisher.UpdateProductStocks(product, "New product is created");
        }
    }

    public interface IPublisher<T>
    {
        void RegisterObserver(IWatcher<T> observer);
        void RemoveObserver(IWatcher<T> observer);
        void NotifyObservers();
    }

    public interface IWatcher<T>
    {
        void Update(string message, T entity = default);
    }

    public class ProductPublisher : IPublisher<Product>
    {
        private readonly List<IWatcher<Product>> observers = new();
        private string productUpdateMessage = "";

        public void NotifyObservers()
        {
            foreach (var observer in observers) observer.Update(productUpdateMessage);
        }

        public void RegisterObserver(IWatcher<Product> observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IWatcher<Product> observer)
        {
            observers.Remove(observer);
        }

        public void UpdateProductStocks(Product product, string message)
        {
            productUpdateMessage = message;
            NotifyObservers();
        }
    }

    public class ProductSubscriber : IWatcher<Product>
    {
        private readonly string Name;

        public ProductSubscriber(string name)
        {
            Name = name;
        }

        void IWatcher<Product>.Update(string message, Product product)
        {
            Console.WriteLine($"Hello!{Name} Here is upadte{message} ");
        }
    }

    public class Product
    {
        public Product(int id, string productName, int price)
        {
            Id = id;
            ProductName = productName;
            Price = price;
        }

        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
    }
}
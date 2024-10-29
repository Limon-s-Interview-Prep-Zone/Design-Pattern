# SOLID Principles

## `1#Single Responsibility Principle (SRP):`
A class should have only one reason to change.
In an order management system, we can separate order processing and notification responsibilities.
```c#
public class OrderService
{
    public void ProcessOrder(Order order)
    {
        // Logic to process the order
        Console.WriteLine($"Processing order {order.OrderId}.");
        SendOrderConfirmation(order);
    }

    private void SendOrderConfirmation(Order order)
    {
        Console.WriteLine($"Order confirmation sent for order {order.OrderId}.");
    }
}
// corrected form
public class OrderService
{
    private readonly NotificationService _notificationService;

    public OrderService(NotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    public void ProcessOrder(Order order)
    {
        // Logic to process the order
        Console.WriteLine($"Processing order {order.OrderId}.");
        _notificationService.SendOrderConfirmation(order);
    }
}

public class NotificationService
{
    public void SendOrderConfirmation(Order order)
    {
        Console.WriteLine($"Order confirmation sent for order {order.OrderId}.");
    }
}

```
---

## `2#Open/Closed Principle (OCP):`
Software entities should be open for extension but closed for modification.

```c#
public class OrderProcessor
{
    public void ProcessOrder(string orderType)
    {
        if (orderType == "Standard")
            Console.WriteLine("Processing standard order.");
        else if (orderType == "Express")
            Console.WriteLine("Processing express order.");
    }
}
// corrected form
public interface IOrder
{
    void Process();
}

public class StandardOrder : IOrder
{
    public void Process() => Console.WriteLine("Processing standard order.");
}

public class ExpressOrder : IOrder
{
    public void Process() => Console.WriteLine("Processing express order.");
}

public class OrderProcessor
{
    public void ProcessOrder(IOrder order) => order.Process();
}

// Usage
var processor = new OrderProcessor();
processor.ProcessOrder(new StandardOrder());
processor.ProcessOrder(new ExpressOrder());

```
---

## `3#Liskov Substitution Principle (LSP):`
Objects of a superclass should be replaceable with objects of its subclasses without altering the behavior of the program.

```c#
public class Order
{
    public virtual void Confirm()
    {
        Console.WriteLine("Order confirmed.");
    }
}

public class PreOrder : Order
{
    public override void Confirm()
    {
        throw new NotImplementedException("Pre-orders cannot be confirmed directly.");
    }
}

// corrected form
public abstract class Order
{
    public abstract void Confirm();
}

public class StandardOrder : Order
{
    public override void Confirm() => Console.WriteLine("Standard order confirmed.");
}

public class PreOrder : Order
{
    public override void Confirm() => Console.WriteLine("Pre-order placed, cannot be confirmed immediately.");
}

```

---

## `4#Interface Segregation Principle (ISP):`
Clients should not be forced to depend on interfaces they do not use.

```c#
public interface IOrderService
{
    void ProcessOrder(Order order);
    void RefundOrder(Order order);
}

public class OrderService : IOrderService
{
    public void ProcessOrder(Order order) => Console.WriteLine($"Processing order {order.OrderId}.");
    public void RefundOrder(Order order) => Console.WriteLine($"Refunding order {order.OrderId}.");
}
//corrected  form
public interface IOrderProcessor
{
    void ProcessOrder(Order order);
}

public interface IOrderRefund
{
    void RefundOrder(Order order);
}

public class OrderService : IOrderProcessor, IOrderRefund
{
    public void ProcessOrder(Order order) => Console.WriteLine($"Processing order {order.OrderId}.");
    public void RefundOrder(Order order) => Console.WriteLine($"Refunding order {order.OrderId}.");
}

// Usage
IOrderProcessor orderProcessor = new OrderService();
orderProcessor.ProcessOrder(new Order { OrderId = 1 });


```
---

## `5#Dependency Inversion Principle (DIP):`
High-level modules should not depend on low-level modules. Both should depend on abstractions.
Decouple services from their dependencies.

```c#
public class EmailService
{
    public void SendEmail(string message) => Console.WriteLine($"Sending email: {message}");
}

public class OrderService
{
    private readonly EmailService _emailService = new EmailService();

    public void ConfirmOrder(Order order)
    {
        Console.WriteLine($"Order {order.OrderId} confirmed.");
        _emailService.SendEmail($"Order {order.OrderId} confirmation.");
    }
}
//corrected form
public interface INotificationService
{
    void SendNotification(string message);
}

public class EmailService : INotificationService
{
    public void SendNotification(string message) => Console.WriteLine($"Sending email: {message}");
}

public class SmsService : INotificationService
{
    public void SendNotification(string message) => Console.WriteLine($"Sending SMS: {message}");
}

public class OrderService
{
    private readonly INotificationService _notificationService;

    public OrderService(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    public void ConfirmOrder(Order order)
    {
        Console.WriteLine($"Order {order.OrderId} confirmed.");
        _notificationService.SendNotification($"Order {order.OrderId} confirmation.");
    }
}

// Usage
var orderService = new OrderService(new EmailService());
orderService.ConfirmOrder(new Order { OrderId = 1 });

var smsOrderService = new OrderService(new SmsService());
smsOrderService.ConfirmOrder(new Order { OrderId = 2 });


```
---
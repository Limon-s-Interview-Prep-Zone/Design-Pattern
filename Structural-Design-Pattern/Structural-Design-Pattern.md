## **Structural Design Pattern**
The Structural Design Patterns in C# focus on how `classes and objects` can be composed to form larger structures. These patterns are used to manage the relationships between entities efficiently.
1. Adapter Pattern
2. Bridge pattern
3. Facade Pattern
4. Proxy pattern
5. Decorator pattern
6. Composite pattern

---
### 1# Adapter Design Pattern

Suppose, We are developing a stock market monitoring app, so we collect data from different sources with differnt formats like `xml or other formats`. At some point we need some 3rd party app to visualize the data. But the problem is that this 3rd party appp only supports `JSON` format. `How can we solve this problem?`

Adapter is a structural design pattern that allows objects with incompatible interfaces to collaborate.
<br>

**Key Components:**
1. Target: The interface that is expected by the client.
2. Adapter: The class that implements the Target interface and translates the calls to the Adaptee interface.
3. Adaptee: The class with the existing interface that needs to be adapted to the Target interface.
4. Client: The code that interacts with the Target interface.

**Case Study- HR system:** Suppose we have a existing HR mangament app that supports `array of string employees` and we want to add a third party system that supports `List<Employee> objects`
1. `Target (ITarget):` Defines the method signature expected by the client `(ProcessCompanySalary)`.
2. `Adapter (EmployeeAdapter):` Implements ITarget and translates the legacy `2D array data` to the expected format (`List<Employee>`) for the third-party system.
3. `Adaptee (ThirdPartyBillingSystem) or Legecy code`: Represents the existing system that the adapter is making compatible with the ITarget interface.
4. `Client (Program)`: Interacts with the ITarget interface, sending `legacy data` and processing it through the adapter
---
### 2.2# Bridge Design Pattern
The Bridge pattern is a structural design pattern that decouples an `abstraction` from its implementation, allowing both to vary independently. `In other words, this pattern decouples two things that are usally bound together`.<br>
Example: Suppose we are creating a notification system where notifications (like alerts, reminders, promotions) can be sent over `multiple channels (e.g., Email, SMS, Push Notifications)`. The Bridge pattern is ideal here, as we can decouple the type of notification from the channel through which it’s sent.

**Key Components:**
1. `Abstraction (Notification):`
   - The `Notification` class defines the `abstraction for sending notifications`. It holds a reference to an INotificationSender (which is the bridge to the implementation).
   - It defines an abstract method `SendNotification(string message)`, which is implemented by its subclasses.
2. `Implementor (INotificationSender):`
   - INotificationSender is an interface that defines the method Send(string message). It has concrete implementations like `EmailSender` and `SmsSender`, which define how to send notifications.
3. `Refined Abstraction (AlertNotification, ReminderNotification, PromotionNotification)`:
   - These classes are the concrete abstractions, representing different types of notifications. They each implement the `SendNotification` method, calling the Send method on the provided INotificationSender to send the message.
4. `Concrete Implementations (EmailSender, SmsSender):`
   - These are concrete implementations of the `INotificationSender interface`, each implementing the `Send` method to send notifications via `email or SMS`.

```c#
public interface INotificationSender
{
    void Send(string message);
}

public class EmailSender : INotificationSender
{
    public void Send(string message)
    {
        Console.WriteLine($"Sending Email Notification: {message}");
    }
}

/// <summary>
///     Create a abstraction
/// </summary>
public abstract class Notification
{
    protected readonly INotificationSender _notificationSender;

    protected Notification(INotificationSender notificationSender)
    {
        _notificationSender = notificationSender;
    }

    public abstract void SendNotification(string message);
}

public class AlertNotification : Notification
{
    public AlertNotification(INotificationSender notificationSender) : base(notificationSender)
    {
    }

    public override void SendNotification(string message)
    {
        Console.WriteLine("Alert Notification:");
        _notificationSender.Send(message);
    }
}
/// Without abstraction
public class AlertNotification
{
    private readonly EmailSender _emailSender;

    public AlertNotification()
    {
        _emailSender = new EmailSender();  // Directly coupling with EmailSender
    }

    public void SendNotification(string message)
    {
        Console.WriteLine("Alert Notification:");
        _emailSender.SendEmail(message);
    }
}
```
---
### 3# Facade Design Pattern
Facade is a structural design pattern that provides a simplified interface to a library, a framework, or any other complex set of classes.<br>
`Example:` Imagine an online shopping system with several subsystems: `Inventory Management`, `Payment Processing`, and `Shipping`. These subsystems are quite complex, but by using a Facade, we can simplify them into a single method that allows the user to place an order without dealing with each subsystem individually.
1. Subsystems:
   - ``Inventory`: Handles stock availability.
   - `Payment`: Processes payment for the order.
   - `Shipping`: Arranges delivery of the order.
2. `Facade: OrderProcessor`: Provides a simplified interface for placing orders.
3. `Client`: Interacts with the OrderProcessor to place an order without dealing with the complexities of individual subsystems.

Benefits:
1. `Simplifies Complex Interfaces:` Makes a system easier to use by hiding complex interactions behind a simple interface.
2. `Loose Coupling:` Keeps clients loosely coupled with complex subsystems.
3. `Reduces Learning Curve:` Reduces the complexity for clients needing only high-level functionality without understanding the inner workings.

---
### 4# Proxy Design Pattern
The Proxy Pattern provides a surrogate or placeholder to control access to an object. It offers a way to defer the full creation of an object or add an extra layer of logic without modifying the original object’s code. Proxies act as intermediaries between a client and the real object, handling additional responsibilities like access control, lazy initialization, or monitoring.<br>
**trade off**
1. `Lazy initialization:` delay the creation of resource-intensive objects until they are actually needed.

**Example:** Suppose we have a `video streaming application`. Loading the full video object (with all metadata) can be expensive. We use a `virtual proxy to load video details only when requested`.

1. `Subject Interface (IVideo)`: The common interface implemented by the `real object and the proxy`.
2. `RealSubject (RealVideo)`: The actual object that performs the real work.
3. `Proxy (VideoProxy)`: Controls access to the RealSubject.
4. Client: Interacts with the Proxy as if it were the RealSubject.
---


### 5# Decorate Pattern:
Decorator pattern adds new behaviors to object without affecting the orginal class.<br>

```bash
                +----------------+
                |   Component    |
                +----------------+
                        ▲
                        │
        +----------------+----------------+
        │                                 │
+----------------+               +----------------+
| ConcreteComponent |           |   Decorator     |
+----------------+               +----------------+
                                   ▲
                                   │
                      +-------------------------+
                      │         Concrete        │
                      │       Decorator A       │
                      +-------------------------+
                                   ▲
                                   │
                      +-------------------------+
                      │         Concrete        │
                      │       Decorator B       │
                      +-------------------------+

```
1. Component: Defines the interface for objects that can have responsibilities added to them dynamically.
2. ConcreteComponent: Implements the Component interface. This is the object to which additional responsibilities are added dynamically.
3. Decorator: Maintains a reference to a Component object and defines an interface that conforms to Component’s interface.
4. Concrete Decorators (A, B): Add responsibilities to the Component dynamically.



***Trade-Offs***

- **Pros:**
   1. Open/Closed Principle: Core logic is closed for modification but open for extension through decorators.
   2. Flexible Composition: You can add/remove notification channels dynamically.
   3. Reusability: Each decorator can be reused independently.

- **Cons:**
   1. Complexity: Too many layers of decorators can make the system hard to understand.
   2. Performance Overhead: Each decorator adds a layer of function calls.

**Example:** In a backend service, it is common to require both authentication (verifying if a user is logged in) and authorization (verifying if the user has the required permissions) for API calls. These cross-cutting concerns can be elegantly implemented using the Decorator Pattern, without modifying the core service logic.

**Case Study:**
Use Case: User Management Service with Authentication and Authorization Decorators, therefore we need a `AbstractDecorator`
 1. `UserService`: We have a UserService that retrieves user information.
 2. `AuthenticationDecorator` ensures that the user is authenticated before accessing the service.
 3. `AuthorizationDecorator` checks if the authenticated user has the proper role/permissions.

**Case Study:**
Imagine an e-commerce system where users receive notifications for order updates through Email, SMS, and Push notifications. Some users prefer email only, while others want to receive notifications across multiple channels. Using the Decorator Pattern, we can compose the notification behavior dynamically without altering the original logic.

1. BasicNotificationService: The core notification service that provides minimal functionality.
2. Decorators: Each decorator adds a specific type of notification:
   1. EmailNotificationDecorator: Sends an email notification.
   2. SmsNotificationDecorator: Sends an SMS notification.
   3. PushNotificationDecorator: Sends a push notification.
3. Client Code: Composes the notification service with multiple decorators to support email, SMS, and push notifications.
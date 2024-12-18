## 1#Creational Design Pattern
The Creational Design Patterns play an important role in how we create objects.
1. Singleton Pattern
2. Factory Pattern
3. Factory Method Pattern
4. Abstract Factory Pattern
5. Builder pattern
6. Prototype pattern

---
### 1.1#Signleton Pattern
The Singleton pattern ensures a class has only `one instance` and provides a global point of access to it.
   - `Database connection, Logging, configuration settings, file handling`.

**`Trade-off`**:
   - **Pros:**
     1. `Ensures a single instance:` Prevents unnecessary multiple instances of a class.
     2. `Global Access:` Provides easy access to the instance from anywhere in the code.
     3. `Lazy Initialization:` Can defer object creation until needed, optimizing resource usage.

   - **Cons:**
     1. `Global State:` Can introduce hidden dependencies, making the code harder to understand and test.
     2. `Limited Scalability:` In multi-threaded applications, locking mechanisms can cause bottlenecks.
     3. `Testing Issues:` Makes unit testing difficult since it introduces tight coupling with global state.

---
### 1.2#Factory Pattern
According to Gang of Four (GoF), a factory is an object used to create other objects. In technical terms, a factory is a class with a method. That method creates and returns different objects `based on the received input parameter`.
   - It involves creating an object through a factory method (often a static method) instead of directly using a constructor.
   - `Centralized creation logic`.
   - Often uses static methods.
   - `Violate Solid Principles`:
     - `OCP`: modifying the factory to support new types.
     - `ISP`: not dirrectly applicable.
```c#
public interface INotificationService
{
    void Send(string message);
}

// Concrete EmailNotificationService Implementation
public class EmailNotificationService : INotificationService
{
    public void Send(string message)
    {
        Console.WriteLine($"Email sent: {message}");
    }
}

// Concrete SMSNotificationService Implementation
public class SMSNotificationService : INotificationService
{
    public void Send(string message)
    {
        Console.WriteLine($"SMS sent: {message}");
    }
}

// NotificationServiceFactory
public class NotificationFactoryService
{
    public INotificationService CreateNotificationService(string type)
    {
        switch (type.ToLower())
        {
            case "email":
                return new EmailNotificationService();
            case "sms":
                return new SMSNotificationService();
            default:
                throw new ArgumentException("Invalid notification type");
        }
    }
}
```
---

### 1.3# Factory Method Pattern:
The Factory Method Pattern defines an interface for creating an object but lets subclasses alter the type of objects that will be created. This pattern involves a base class (often abstract) and subclasses that implement the `factory method to create objects`.
- provides a method to create objects, with the actual creation logic in subclasses.
- Promotes code extensibility and follows the Open/Closed Principle.
- ISP: not directly applicable.
- ***`Focused on creating on one product type at a time`***.
  - Create either `SMSNotification` or `EmailNotification`

```c#
  public interface INotificationService
  {
      void Send(string message);
  }
  // Concrete Product for EmailNotificationService
  public class EmailNotificationService : INotificationService
  {
      public void Send(string message)
      {
          Console.WriteLine($"Email sent: {message}");
      }
  }

  // Concrete Product for SMSNotificationService
  public class SMSNotificationService : INotificationService
  {
      public void Send(string message)
      {
          Console.WriteLine($"SMS sent: {message}");
      }
  }

  #region Factory Method
  // Base Creator Class for Object creation
  public abstract class NotificationServiceCreator
  {
      public abstract INotificationService CreateNotificationService();
  }

  // EmailNotificationServiceCreator
  public class EmailNotificationServiceCreator : NotificationServiceCreator
  {
      public override INotificationService CreateNotificationService()
      {
          return new EmailNotificationService();
      }
  }

  // SMSNotificationServiceCreator
  public class SMSNotificationServiceCreator : NotificationServiceCreator
  {
      public override INotificationService CreateNotificationService()
      {
          return new SMSNotificationService();
      }
  }
```

---
### 1.4# Abstract Factory Pattern:
The Abstract Factory Pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes. It involves `multiple factories for different products` and a `common interface to interact` with these factories.
- `Interface Definition:` It defines an abstract interface for creating a variety of products.
- `Families of Products:` Allows the creation of related objects that are meant to be used together.
- `Decoupling:` Decouples the client code from the specific classes of the products it uses, promoting loose coupling.
- `Consistency:` Ensures that products created by a factory are compatible with each other.
- Abstracts `the creation of families of objects`, making it easier to `swap out entire families` without changing client code.
- Meet `SOLID` principle.
```c#
  public interface ICar
  {
      void GetDetails();
  }

  /// <summary>
  /// Product2 Interface
  /// </summary>
  public interface IBike
  {
      void GetDetails();
  }

  /// <summary>
  /// Concreate Product
  /// </summary>
  public class RegularBike : IBike
  {
      public void GetDetails()
      {
          Console.WriteLine("Fetching RegularBike Details..");
      }
  }

  /// <summary>
  /// Concreate Product
  /// </summary>
  public class SportsBike : IBike
  {
      public void GetDetails()
      {
          Console.WriteLine("Fetching SportsBike Details..");
      }
  }

  /// <summary>
  /// Concreate Product
  /// </summary>
  public class RegularCar : ICar
  {
      public void GetDetails()
      {
          Console.WriteLine("Fetching RegularCar Details..");
      }
  }
  /// <summary>
  /// Concreate Product
  /// </summary>
  public class SportsCar : ICar
  {
      public void GetDetails()
      {
          Console.WriteLine("Fetching SportsCar Details..");
      }
  }


  /// <summary>
  /// Create AbstractFactory
  /// </summary>
  public interface IVehicleFactory
  {
      //Abstract Product A
      IBike CreateBike();
      //Abstract Product B
      ICar CreateCar();
  }

  /// <summary>
  /// Concrete Factory
  /// </summary>
  public class RegularVehicleFactory : IVehicleFactory
  {
      public IBike CreateBike()
      {
          return new RegularBike();
      }
      public ICar CreateCar()
      {
          return new RegularCar();
      }
  }
```
---
### 1.5#Builder
The Builder pattern is used to `construct a complex object step by step`. It allows you to create different `representations of the same object`.
```c#
public class OrderBuilder
{
    private Order _order = new Order();

    public OrderBuilder SetPrice(decimal price)
    {
        _order.Price = price;
        return this;
    }

    public OrderBuilder CalculateTotalAmount()
    {
        _order.TotalAmount = _order.Quantity * _order.Price;
        return this;
    }

    public Order Build()
    {
        return _order;
    }
}
```

### 1.6#Protype Pattern
The Prototype Pattern is a creational design pattern that allows you to create new objects by copying an existing object, known as the prototype. This is usefull when creating complex object.
* UI design, Game charater

**Key Components**
1. **Prototype Interface**: Declare a `Clone()` method that is implemented by all classed supporting clonning.
2. **Concrete Prototype Class:** Implements the `Clone()` method, which create a copy of itself.
3. **Client**: Use `Clone()` method to duplicate an objects.

**Case Study:** Email Template clone
1. Prototype Interface `(IEmailTemplatePrototype)`
   - Defines the contract for cloning and retrieving email template content.
   - Methods:
     - Clone: Creates a copy of the template.
     - GetContent: Retrieves the email content.
2. Concrete Prototypes (`WelcomeEmail, PasswordResetEmail`)
3. Prototype Registry (`EmailTemplateFactory`)
   - Maintains a collection of predefined templates.
   - Allows retrieving and cloning templates dynamically based on type.
4. Client (`EmailService`)
   - Uses the `EmailTemplateFactory` to fetch and customize templates before sending.
---


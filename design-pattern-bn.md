# Design Pattern
A design pattern is a proven technique that can be used to solve a specific problem.
(ডিজাইন প্যাটার্ন হলো একটি প্রমাণিত কৌশল যা কোনো নির্দিষ্ট সমস্যা সমাধানের জন্য ব্যবহার করা যেতে পারে।)

## Different types of anti pattern:
#### Anti-patterns and code smells:
Anti-pattens and code smells are architectural bad practices or tips about possible bad design.
(অ্যান্টি-প্যাটার্ন এবং কোড স্মেল হলো আর্কিটেকচারাল খারাপ অভ্যাস বা সম্ভাব্য খারাপ ডিজাইনের লক্ষণ।)

#### Anti-pattern
Anti-pattern is opposite to design pattern; it is a proven flawed technique that will most likely cause you some problems and cost you time and money. At prior, anti-pattern seems to a good idea and that seems to be the solution you are looking for, but eventually, it will cause more harm than good.
(অ্যান্টি-প্যাটার্ন হলো ডিজাইন প্যাটার্নের বিপরীত; এটি একটি প্রমাণিত ত্রুটিযুক্ত কৌশল যা সম্ভবত আপনার সমস্যা সৃষ্টি করবে এবং সময় ও অর্থের অপচয় ঘটাবে। প্রথমে এটি ভালো ধারণা বলে মনে হতে পারে, কিন্তু শেষ পর্যন্ত এটি উপকারের চেয়ে ক্ষতিই বেশি করবে।)

#### Anti-pattern – God class:
- A `God class` is a class that handles way too many things.
  (একটি `God class` হলো এমন একটি ক্লাস যা অনেক বেশি কাজ পরিচালনা করে।)
- It is usually a `central class` that many other classes inherit from or use
  (এটি সাধারণত একটি কেন্দ্রীয় ক্লাস যা থেকে অন্য অনেক ক্লাস ইনহেরিট করে বা ব্যবহার করে।)
- it is the class that `knows and manages everything in the system`
  (এটি এমন একটি ক্লাস যা সিস্টেমের সবকিছু জানে এবং পরিচালনা করে।)
- nobody wants to update this class, 
  (কেউ এই ক্লাসটি আপডেট করতে চায় না,)
- the class that breaks the application every time somebody touches it;
  (যে ক্লাসে হাত দিলেই প্রতিবার অ্যাপ্লিকেশন ভেঙে যায়;)
- it is an evil class!
  (এটি একটি দুষ্ট ক্লাস!)

#### Code smells:
- an indicator of a possible problem.
  (সম্ভাব্য সমস্যার একটি সূচক।)
- It points to some areas of your design that could benefit from a redesign
  (এটি আপনার ডিজাইনের এমন কিছু জায়গাকে নির্দেশ করে যা নতুন করে ডিজাইন করলে ভালো হবে।)
- code smells only **indicate the possibility of a problem***; it does not mean that there is one;
  (কোড স্মেল শুধুমাত্র সমস্যার সম্ভাবনা নির্দেশ করে; এর মানে এই নয় যে সেখানে আসলেই কোনো সমস্যা আছে;)
- For example, method's logic have been updated but comments remained the same. This will lead a developer astray.
  (উদাহরণস্বরূপ, মেথডের লজিক আপডেট করা হয়েছে কিন্তু কমেন্ট আগের মতোই আছে। এটি একজন ডেভেলপারকে বিভ্রান্ত করতে পারে।)

#### Code smell – Control freak:
- use the `new` keyword.
  (`new` কীওয়ার্ড ব্যবহার করা।)
- indication of hardcoded dependency injection.
  (হার্ডকোডেড ডিপেনডেন্সি ইনজেকশনের লক্ষণ।)

#### Code smell – Long methods:
- a method starts to extend to more than 10 to 15 lines of code.
  (একটি মেথড যখন ১০ থেকে ১৫ লাইনের বেশি বড় হয়ে যায়।)
- contains complex logic, interwined in multiple conditional statements, or log switch-case statements.
  (জটিল লজিক থাকে, যা অনেকগুলো কন্ডিশনাল স্টেটমেন্ট বা বড় সুইচ-কেস স্টেটমেন্টের সাথে যুক্ত থাকে।)
- Contains duplications of code
  (কোডের পুনরাবৃত্তি থাকে।)
- Extract one or more private method, resue the code from a class.
  (একাধিক প্রাইভেট মেথড আলাদা করে ক্লাসের কোড পুনরায় ব্যবহার করা উচিত।)

## Architectural Principles
1. SOLID principles (সলিড প্রিন্সিপালস)
2. DRY principle (ড্রাই প্রিন্সিপাল)
3. The separation of concerns principle (সেপারেশন অফ কনসার্নস প্রিন্সিপাল)

### SOLID principles
1. Single responsibility principle (SRP)

#### Single responsibility principle (SRP):
Essentially, the SRP means that a single class should hold one, and only one, responsibility. There should never be more than one reason for a class to change.
(মূলত, SRP এর অর্থ হলো একটি ক্লাসের কেবল একটি এবং একটিমাত্র দায়িত্ব থাকা উচিত। একটি ক্লাস পরিবর্তন করার জন্য একাধিক কারণ থাকা উচিত নয়।)

## GOF
1. [Link-1](https://dotnetcorecentral.com/blog/adapter-pattern/)
2. [Solid](https://www.telerik.com/blogs/aspnet-core-basics-understanding-practicing-solid)
3. [Abstract Factory](https://www.telerik.com/blogs/aspnet-core-basics-knowing-applying-design-patterns)

### 1#Creational Design Pattern
The Creational Design Patterns in C# play an important role in how we create objects.
(C# এ ক্রিয়েশনাল ডিজাইন প্যাটার্নগুলো আমরা কীভাবে অবজেক্ট তৈরি করি তাতে গুরুত্বপূর্ণ ভূমিকা পালন করে।)
1. Singleton Pattern
2. Factory Pattern
3. Factory Method Pattern
4. Abstract Factory Pattern
5. Builder pattern
6. Prototype pattern

#### 1.1#Signleton Pattern
The Singleton pattern ensures a class has only one instance and provides a global point of access to it.
(সিঙ্গেলটন প্যাটার্ন নিশ্চিত করে যে একটি ক্লাসের কেবল একটিমাত্র ইনস্ট্যান্স থাকবে এবং এটি অ্যাক্সেস করার জন্য একটি গ্লোবাল পয়েন্ট প্রদান করে।)
- Database connection, Logging, configuration settings.

**`Trade-off`**:
- **Pros:**
  1. `Ensures a single instance:` Prevents unnecessary multiple instances of a class.
     (একটিমাত্র ইনস্ট্যান্স নিশ্চিত করে: অপ্রয়োজনীয় একাধিক ইনস্ট্যান্স তৈরি হতে বাধা দেয়।)
  2. `Global Access:` Provides easy access to the instance from anywhere in the code.
     (গ্লোবাল অ্যাক্সেস: কোডের যেকোনো স্থান থেকে সহজে অ্যাক্সেস প্রদান করে।)
  3. `Lazy Initialization:` Can defer object creation until needed, optimizing resource usage.
     (লেজি ইনিশিয়ালাইজেশন: প্রয়োজন না হওয়া পর্যন্ত অবজেক্ট তৈরি স্থগিত রাখতে পারে, রিসোর্সের সাশ্রয় করে।)
   
- **Cons:**
  1. `Global State:` Can introduce hidden dependencies, making the code harder to understand and test.
     (গ্লোবাল স্টেট: লুকানো ডিপেনডেন্সি তৈরি করতে পারে, যা কোড বোঝা এবং টেস্ট করা কঠিন করে তোলে।)
  2. `Limited Scalability:` In multi-threaded applications, locking mechanisms can cause bottlenecks.
     (সীমিত স্কেলেবিলিটি: মাল্টি-থ্রেডেড অ্যাপ্লিকেশনে, লকিং মেকানিজম বাধার সৃষ্টি করতে পারে।)
  3. `Testing Issues:` Makes unit testing difficult since it introduces tight coupling with global state.
     (টেস্টিং সমস্যা: গ্লোবাল স্টেটের সাথে টাইট কাপলিং তৈরি করার ফলে ইউনিট টেস্টিং কঠিন করে তোলে।)

#### 1.2#Factory Pattern
According to Gang of Four (GoF), a factory is an object used to create other objects. In technical terms, a factory is a class with a method. That method creates and returns different objects `based on the received input parameter`.
(গ্যাং অফ ফোর (GoF) এর মতে, ফ্যাক্টরি হলো এমন একটি অবজেক্ট যা অন্য অবজেক্ট তৈরি করতে ব্যবহৃত হয়। প্রযুক্তিগত ভাষায়, ফ্যাক্টরি হলো মেথডসহ একটি ক্লাস। ইনপুট প্যারামিটারের ওপর ভিত্তি করে সেই মেথডটি বিভিন্ন অবজেক্ট তৈরি করে এবং রিটার্ন করে।)
- It involves creating an object through a factory method (often a static method) instead of directly using a constructor.
  (এটি সরাসরি কন্সট্রাক্টর ব্যবহার করার পরিবর্তে একটি ফ্যাক্টরি মেথডের মাধ্যমে অবজেক্ট তৈরি করে।)
- Centralized creation logic.
  (কেন্দ্রীভূত অবজেক্ট তৈরির লজিক।)
- Often uses static methods.
  (প্রায়শই স্ট্যাটিক মেথড ব্যবহার করে।)
- Violate Solid Principles
  (সলিড প্রিন্সিপালস লঙ্ঘন করে)
  - OCP: modifying the factory to support new types. (নতুন টাইপ সাপোর্ট করার জন্য ফ্যাক্টরি মডিফাই করতে হয়।)
  - ISP: not dirrectly applicable. (সরাসরি প্রযোজ্য নয়।)

#### 1.3# Factory Method Pattern:
The Factory Method Pattern defines an interface for creating an object but lets subclasses alter the type of objects that will be created. This pattern involves a base class (often abstract) and subclasses that implement the factory method to create objects.
(ফ্যাক্টরি মেথড প্যাটার্ন অবজেক্ট তৈরি করার জন্য একটি ইন্টারফেস সংজ্ঞায়িত করে, তবে সাবক্লাসগুলোকে কোন ধরনের অবজেক্ট তৈরি হবে তা পরিবর্তন করার সুযোগ দেয়। এই প্যাটার্নে একটি বেস ক্লাস এবং সাবক্লাস থাকে যা অবজেক্ট তৈরির জন্য ফ্যাক্টরি মেথড ইমপ্লিমেন্ট করে।)
- provides a method to create objects, with the actual creation logic in subclasses.
  (অবজেক্ট তৈরি করার একটি মেথড প্রদান করে, যার মূল তৈরির লজিক সাবক্লাসে থাকে।)
- Promotes code extensibility and follows the Open/Closed Principle.
  (কোড এক্সটেনসিবিলিটি বাড়ায় এবং ওপেন/ক্লোজড প্রিন্সিপাল মেনে চলে।)
- ISP: not directly applicable.
- ***`Focused on creating on one product type at a time`***.
  (একবারে একটি প্রোডাক্ট টাইপ তৈরি করার দিকে ফোকাস করে।)
  - Create either `SMSNotification` or `EmailNotification`

#### 1.4# Abstract Factory Pattern:
The Abstract Factory Pattern provides an interface for creating families of related or dependent objects without specifying their concrete classes. It involves `multiple factories for different products` and a `common interface to interact` with these factories.
(অ্যাবস্ট্রাক্ট ফ্যাক্টরি প্যাটার্ন সম্পর্কিত বা নির্ভরশীল অবজেক্টগুলোর ফ্যামিলি তৈরি করার জন্য একটি ইন্টারফেস প্রদান করে, যেখানে কংক্রিট ক্লাস নির্দিষ্ট করার প্রয়োজন নেই। এটি বিভিন্ন প্রোডাক্টের জন্য একাধিক ফ্যাক্টরি এবং তাদের সাথে যোগাযোগের জন্য একটি সাধারণ ইন্টারফেস ব্যবহার করে।)
- `Interface Definition:` It defines an abstract interface for creating a variety of products.
- `Families of Products:` Allows the creation of related objects that are meant to be used together.
  (একসাথে ব্যবহার করার উদ্দেশ্যে সম্পর্কিত অবজেক্টগুলো তৈরি করার অনুমতি দেয়।)
- `Decoupling:` Decouples the client code from the specific classes of the products it uses, promoting loose coupling.
- `Consistency:` Ensures that products created by a factory are compatible with each other.
  (ফ্যাক্টরি দ্বারা তৈরি প্রোডাক্টগুলো একে অপরের সাথে সামঞ্জস্যপূর্ণ তা নিশ্চিত করে।)
- Abstracts `the creation of families of objects`, making it easier to `swap out entire families` without changing client code.
- Meet `SOLID` principle.

#### 1.5#Builder
The Builder pattern is used to `construct a complex object step by step`. It allows you to create different `representations of the same object`.
(বিল্ডার প্যাটার্ন ধাপে ধাপে একটি জটিল অবজেক্ট তৈরি করতে ব্যবহৃত হয়। এটি আপনাকে একই অবজেক্টের বিভিন্ন রূপ তৈরি করার অনুমতি দেয়।)
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

#### 1.6#Protype Pattern
The Prototype Pattern is a creational design pattern that allows you to create new objects by copying an existing object, known as the prototype. This is usefull when creating complex object.
(প্রোটোটাইপ প্যাটার্ন হলো একটি ক্রিয়েশনাল ডিজাইন প্যাটার্ন যা আপনাকে একটি বিদ্যমান অবজেক্ট কপি করে নতুন অবজেক্ট তৈরি করার অনুমতি দেয়, যা প্রোটোটাইপ নামে পরিচিত। এটি জটিল অবজেক্ট তৈরি করার সময় বেশ দরকারী।)
* UI design, Game charater

**Key Components**
1. **Prototype Interface**: Declare a `Clone()` method that is implemented by all classed supporting clonning.
   (একটি `Clone()` মেথড ডিক্লেয়ার করে যা ক্লোন সাপোর্ট করা সব ক্লাস ইমপ্লিমেন্ট করে।)
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

**Case Stydy:** Configuration

### **2#Structural Design Pattern**
The Structural Design Patterns in C# focus on how classes and objects can be composed to form larger structures. These patterns are used to manage the relationships between entities efficiently.
(C# এর স্ট্রাকচারাল ডিজাইন প্যাটার্নগুলো ক্লাস এবং অবজেক্টগুলো কীভাবে একত্রে যুক্ত হয়ে বৃহত্তর কাঠামো তৈরি করতে পারে তার ওপর ফোকাস করে। সত্তাগুলোর মধ্যে সম্পর্ক কার্যকরভাবে পরিচালনা করার জন্য এই প্যাটার্নগুলো ব্যবহৃত হয়।)
1. Adapter Pattern
2. Bridge pattern
3. Facade Pattern
4. Proxy pattern
5. Decorator pattern
6. Composite pattern

#### 2.1# Adapter Design Pattern
Suppose, We are developing a stock market monitoring app, so we collect data from different sources with differnt formats like `xml or other formats`. At some point we need some 3rd party app to visualize the data. But the problem is that this 3rd party appp only supports `JSON` format. `How can we solve this problem?`
(ধরি, আমরা একটি স্টক মার্কেট মনিটরিং অ্যাপ তৈরি করছি, যেখানে আমরা বিভিন্ন সোর্স থেকে xml বা অন্য ফর্ম্যাটের ডেটা সংগ্রহ করি। একপর্যায়ে ডেটা ভিজ্যুয়ালাইজ করার জন্য আমাদের একটি থার্ড পার্টি অ্যাপের প্রয়োজন হয়। কিন্তু সমস্যা হলো সেই থার্ড পার্টি অ্যাপটি কেবল JSON ফর্ম্যাট সাপোর্ট করে। আমরা কীভাবে এই সমস্যাটি সমাধান করতে পারি?)

Adapter is a structural design pattern that allows objects with incompatible interfaces to collaborate.
(অ্যাডাপ্টার হলো একটি স্ট্রাকচারাল ডিজাইন প্যাটার্ন যা বেমানান ইন্টারফেসযুক্ত অবজেক্টগুলোকে একত্রে কাজ করতে সাহায্য করে।)

<br>

**Key Components:**
1. Target: The interface that is expected by the client. (ক্লায়েন্টের প্রত্যাশিত ইন্টারফেস।)
2. Adapter: The class that implements the Target interface and translates the calls to the Adaptee interface. (অ্যাডাপ্টার ক্লাসটি টার্গেট ইন্টারফেস ইমপ্লিমেন্ট করে এবং অ্যাডাপ্টি ইন্টারফেসের কলগুলোকে অনুবাদ করে।)
3. Adaptee: The class with the existing interface that needs to be adapted to the Target interface. (বিদ্যমান ইন্টারফেসের ক্লাস যাকে টার্গেট ইন্টারফেসের সাথে খাপ খাওয়াতে হবে।)
4. Client: The code that interacts with the Target interface. (কোড যা টার্গেট ইন্টারফেসের সাথে যোগাযোগ করে।)

**Case Study- HR system:** Suppose we have a existing HR mangament app that supports `array of string employees` and we want to add a third party system that supports `List<Employee> objects`
(ধরা যাক আমাদের একটি বিদ্যমান এইচআর ম্যানেজমেন্ট অ্যাপ রয়েছে যা `array of string employees` সাপোর্ট করে এবং আমরা একটি থার্ড পার্টি সিস্টেম যুক্ত করতে চাই যা `List<Employee> objects` সাপোর্ট করে।)
1. `Target (ITarget):` Defines the method signature expected by the client `(ProcessCompanySalary)`.
2. `Adapter (EmployeeAdapter):` Implements ITarget and translates the legacy `2D array data` to the expected format (`List<Employee>`) for the third-party system.
3. `Adaptee (Employee, ThirdPartyBillingSystem)`: Represents the existing system that the adapter is making compatible with the ITarget interface.
4. `Client (Program)`: Interacts with the ITarget interface, sending `legacy data` and processing it through the adapter.

#### 2.2# Bridge Design Pattern
The Bridge pattern is a structural design pattern that decouples an `abstraction` from its implementation, allowing both to vary independently.<br>
(ব্রিজ প্যাটার্ন হলো একটি স্ট্রাকচারাল ডিজাইন প্যাটার্ন যা একটি `অ্যাবস্ট্রাকশন` কে তার ইমপ্লিমেন্টেশন থেকে ডিকাপল করে, যার ফলে উভয়ই স্বাধীনভাবে পরিবর্তিত হতে পারে।)
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

### 2.3# Facade Design Pattern
Facade is a structural design pattern that provides a simplified interface to a library, a framework, or any other complex set of classes.<br>
(ফ্যাসাড (Facade) হলো একটি স্ট্রাকচারাল ডিজাইন প্যাটার্ন যা কোনো লাইব্রেরি, ফ্রেমওয়ার্ক, অথবা অন্যান্য জটিল ক্লাস সেটের জন্য একটি সরলীকৃত ইন্টারফেস প্রদান করে।)
`Example:` Imagine an online shopping system with several subsystems: `Inventory Management`, `Payment Processing`, and `Shipping`. These subsystems are quite complex, but by using a Facade, we can simplify them into a single method that allows the user to place an order without dealing with each subsystem individually.
1. Subsystems:
   - ``Inventory`: Handles stock availability.
   - `Payment`: Processes payment for the order.
   - `Shipping`: Arranges delivery of the order.
2. `Facade: OrderProcessor`: Provides a simplified interface for placing orders.
3. `Client`: Interacts with the OrderProcessor to place an order without dealing with the complexities of individual subsystems.

Benefits:
1. Simplifies Complex Interfaces: Makes a system easier to use by hiding complex interactions behind a simple interface.
2. Loose Coupling: Keeps clients loosely coupled with complex subsystems.
3. Reduces Learning Curve: Reduces the complexity for clients needing only high-level functionality without understanding the inner workings.

#### 2.4# Proxy Design Pattern
The Proxy Pattern provides a surrogate or placeholder to control access to an object. It offers a way to defer the full creation of an object or add an extra layer of logic without modifying the original object’s code. Proxies act as intermediaries between a client and the real object, handling additional responsibilities like access control, lazy initialization, or monitoring.<br>
(প্রক্সি প্যাটার্ন কোনো অবজেক্টের অ্যাক্সেস নিয়ন্ত্রণ করার জন্য একটি বিকল্প বা প্লেসহোল্ডার প্রদান করে। এটি অবজেক্টের মূল কোড পরিবর্তন না করেই কোনো অবজেক্ট পুরোপুরি তৈরি করার কাজ স্থগিত করতে বা অতিরিক্ত লজিকের একটি স্তর যুক্ত করার সুযোগ দেয়।)
**Example:** Suppose we have a video streaming application. Loading the full video object (with all metadata) can be expensive. We use a virtual proxy to load video details only when requested.

1. `Subject Interface (IVideo)`: The common interface implemented by the `real object and the proxy`.
2. `RealSubject (RealVideo)`: The actual object that performs the real work.
3. `Proxy (VideoProxy)`: Controls access to the RealSubject.
4. Client: Interacts with the Proxy as if it were the RealSubject.

#### 2.5# Decorate Pattern:
The Decorator Pattern allows behavior to be added to individual objects, either statically or dynamically, without affecting the behavior of other objects from the same class. It is used to extend the functionality of an object at runtime in a flexible way, avoiding subclassing.<br>
(ডেকোরেটর প্যাটার্ন কোনো ক্লাসের অন্যান্য অবজেক্টের আচরণকে প্রভাবিত না করে স্ট্যাটিক বা ডাইনামিক ভাবে কোনো নির্দিষ্ট অবজেক্টে আচরণ যুক্ত করার সুযোগ দেয়। সাবক্লাসিং এড়িয়ে চলার পাশাপাশি রানটাইমে নমনীয়ভাবে কোনো অবজেক্টের কার্যকারিতা প্রসারিত করতে এটি ব্যবহৃত হয়।)

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

**Pros:**
    1. Open/Closed Principle: Core logic is closed for modification but open for extension through decorators.
    2. Flexible Composition: You can add/remove notification channels dynamically.
    3. Reusability: Each decorator can be reused independently.

**Cons:**
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

### ***`3#Behavioral Design Pattern`***
Behavioral Design Patterns deal with the communication or interaction between Classes and Objects. The primary goal of these patterns is to enhance the communication between objects, making it more flexible and efficient.
(বিহেইভিয়ারাল ডিজাইন প্যাটার্নগুলো ক্লাস এবং অবজেক্টের মধ্যকার যোগাযোগ বা ইন্টারঅ্যাকশন নিয়ে কাজ করে। এই প্যাটার্নগুলোর মূল লক্ষ্য হলো অবজেক্টগুলোর মধ্যকার যোগাযোগ বৃদ্ধি করে সেটিকে আরও নমনীয় এবং কার্যকর করা।)
1. Strategy
2. Chain of Responsibility
3. Command
4. Observer
5. Mediator
6. State

#### ***`3.1#Strategy design pattern`***
Strategy is a behavioral design pattern that lets you define a family of algorithms, put each of them into a separate class, and make their objects interchangeable. The Strategy Pattern is a powerful way to encapsulate different algorithms or behaviors and switch between them dynamically at runtime.
(স্ট্র্যাটেজি হলো একটি বিহেইভিয়ারাল ডিজাইন প্যাটার্ন যা আপনাকে অ্যালগরিদমের একটি ফ্যামিলি সংজ্ঞায়িত করার, সেগুলোর প্রত্যেকটিকে আলাদা ক্লাসে রাখার এবং সেগুলোর অবজেক্টগুলোকে বিনিময়যোগ্য করার সুযোগ দেয়। স্ট্র্যাটেজি প্যাটার্ন হলো বিভিন্ন অ্যালগরিদম বা আচরণকে এনক্যাপসুলেট করার এবং রানটাইমে ডায়নামিকভাবে সেগুলোর মধ্যে পরিবর্তন করার একটি শক্তিশালী উপায়।)

***Payment Processing System:*** In a Payment Processing System, customers might have multiple ways to pay: `Credit Card, PayPal, or Bank Transfer`.  Instead of `hardcoding multiple if-else` or `switch statements` for different payment methods, we use the Strategy Pattern to implement different payment strategies. The selected strategy is passed to the PaymentService dynamically.
1. `Strategy Interface (IPaymentStrategy)`: Provides a contract for all payment methods.
2. `Concrete Strategies`: Implement different payment methods like `CreditCardPayment, PayPalPayment, and BankTransferPayment`.
3. `Context (PaymentService)`: Uses the payment strategy to process payments. It allows switching strategies dynamically via the SetPaymentStrategy method.
4. `Client Code`: Simulates the dynamic selection of payment methods and processes payments accordingly.

***Trade-off***:

Pros:
1. Single Responsibility Principle: Each payment strategy focuses on one payment method.
2. Open/Closed Principle: New payment methods can be added without modifying existing code.
3. Flexible Behavior: Strategies can be switched at runtime based on business needs.

Cons:
1. Increased Complexity: A large number of strategies may make the codebase harder to maintain.
2. Performance Overhead: Switching strategies frequently may add a slight overhead.

#### ***`3.2#Chain of Responsibility`***
Chain of Responsibility is a behavioral design pattern that lets you pass requests along a chain of handlers. Upon receiving a request, each handler decides either to process the request or to pass it to the next handler in the chain.
(চেইন অফ রেসপন্সিবিলিটি হলো একটি বিহেইভিয়ারাল ডিজাইন প্যাটার্ন যা আপনাকে হ্যান্ডলারদের একটি চেইনের মধ্য দিয়ে রিকোয়েস্ট পাস করার সুযোগ দেয়। একটি রিকোয়েস্ট পাওয়ার পর, প্রতিটি হ্যান্ডলার সিদ্ধান্ত নেয় যে রিকোয়েস্টটি প্রসেস করবে নাকি চেইনের পরবর্তী হ্যান্ডলারের কাছে পাস করবে।)
- You can control the order of request handling. (আপনি রিকোয়েস্ট হ্যান্ডেলিং এর ক্রম নিয়ন্ত্রণ করতে পারেন।)
- Follow `O/C` and `SRP` principle

***Case-Study: Notification Approval System***: In a notification approval system (e.g., in a corporate messaging platform), different levels of managers or moderators approve notifications based on their roles. If one handler (e.g., Team Lead) can't approve the notification, it forwards it to the next one in the chain (e.g., Manager or Director). Using Chain of Responsibility, the code remains flexible and easy to extend with more handlers.
1. **Handlers:** The system defines three handlers: Team Lead, Manager, and Director.
2. **Chaining:** Each handler is connected in a chain. If a handler can't process the request, it passes the request to the next one.
3. **Dynamic Flow:** The flow of requests can be modified easily by changing the chain setup.
4. **Open/Closed Principle:** New handlers can be added without modifying existing code.

***Common Case study:***
1. ***Authorization Middleware:*** In a web application, a series of middleware checks user permissions.
2. ***Technical Support Systems:*** Customer issues are passed from Level 1 to Level 2 to Level 3 support.
3. ***Request Handlers in APIs:*** Each layer handles a specific part of a request and passes it to the next.

#### ***`3.3#Command Pattern`***
Command Design Pattern, the Command Object will be passed to the Invoker Object. The Invoker Object does not know how to handle the request. What the Invoker will do is it will call the Execute method of the Command Object. The Execute method of the command object will be called the Receiver Object Method. The Receiver Object Method will perform the necessary action to handle the request.
(কমান্ড ডিজাইন প্যাটার্নে, কমান্ড অবজেক্টকে ইনভোকার অবজেক্টের কাছে পাস করা হবে। ইনভোকার অবজেক্ট জানে না কীভাবে রিকোয়েস্টটি হ্যান্ডেল করতে হবে। ইনভোকার যা করবে তা হলো কমান্ড অবজেক্টের Execute মেথড কল করবে। কমান্ড অবজেক্টের Execute মেথডটি রিসিভার অবজেক্ট মেথডকে কল করবে। রিসিভার অবজেক্ট মেথড রিকোয়েস্টটি হ্যান্ডেল করার জন্য প্রয়োজনীয় কাজ সম্পাদন করবে।)

```bash
Client
   |
   v
+------------------+
| Create Command   |
| (ConcreteCommand)|
+------------------+
        |
        v
+-----------------+
| Command Invoker |
+-----------------+
        |
        v
+---------------------+
| Execute the Command |
+---------------------+
        |
        v
+-----------------+
|   Receiver      |
| (Performs Action)|
+-----------------+
```

***Order Scheduling***
- **Receiver:** This class contains the actual implementation of the method the client wants to call. For example `PreparePasta, PrepareBurger`
- **Command:** An interface only contains a method for executing operation.
- **ConcreteCommand:** These classes will implement the ICommand interface and provide implementations for the Execute operation. As part of the Execute method, it will invoke operation(s) on the Receiver object. `PastaOrderCommand, BurgerOrderCommand`.
- **Invoker:** ask the command to carry out the action.`OrderInvoker`

***`Notification System with Command Pattern`*** Consider a notification system where different types of notifications (like Email, SMS, and Push) need to be sent. Using the Command Pattern, we encapsulate each notification type as a command, and the Invoker handles the execution of these commands.
1. **Command Interface (ICommand)**: Declares a method Execute() for executing operations.
2. **Concrete Commands:** Encapsulate different notification logic (Email, SMS, and Push).
3. **Receiver (NotificationService):** Contains the business logic to send notifications.
4. **Invoker (NotificationInvoker):** Stores and executes commands.
5. **Client:** Sets up the commands and invokes them via the invoker.

**Common Case study:**
1. **Task Scheduling:** Queue up tasks to be executed later.
2. **GUI Button Clicks:** Each button click triggers a command.
3. **Undo/Redo Systems:** Store commands to allow undoing or redoing operations.
4. **Transactional Systems:** Execute a series of operations as commands, ensuring consistency.

#### ***`3.4#Observer design pattern`***
The Observer Pattern defines a one-to-many relationship between objects, where one object (the Subject) notifies multiple observers when its state changes. This pattern promotes loose coupling since the subject and observers don’t directly depend on each other. It's widely used in event-driven systems like messaging systems, GUIs, or notification services.
(অবজারভার প্যাটার্ন অবজেক্টগুলোর মধ্যে একটি ওয়ান-টু-মেনি সম্পর্ক সংজ্ঞায়িত করে, যেখানে একটি অবজেক্ট (সাবজেক্ট) তার অবস্থার পরিবর্তন হলে একাধিক অবজার্ভারকে অবহিত করে। সাবজেক্ট এবং অবজার্ভাররা একে অপরের ওপর সরাসরি নির্ভর না করায় এই প্যাটার্ন লুজ কাপলিং-কে প্রোমোট করে। এটি মেসেজিং সিস্টেম, গুই (GUI), বা নোটিফিকেশন সার্ভিসের মতো ইভেন্ট-ড্রিভেন সিস্টেমে ব্যাপকভাবে ব্যবহৃত হয়।)

```bash
+---------------------+
|     Subject         |
| - Attach(observer)  |
| - Detach(observer)  |
| - Notify()          |
+---------------------+
           |
           v
+---------------------+
| ConcreteSubject     |
| - State             |
| - GetState()        |
| - SetState(state)   |
+---------------------+
           |
           v
+----------------------+
| Notify All Observers |
+----------------------+
           |
           v
+---------------------+       +---------------------+
|     Observer        |<----->| ConcreteObserver    |
| - Update()          |       | - Update()          |
+---------------------+       +---------------------+
```

1. `Subject/Publisher:`
   - RegisterObserver
   - RemoveObserver
   - NotifyObserver
2. `Observer/Consumer:`
   - ConsumeSubjectMessage

**Case-Study(News App Push Notifications):** Imagine you are building a news app that delivers breaking news to subscribers. Users can subscribe to topics like Politics, Sports, Technology, or Entertainment. Whenever there’s new content on a topic, subscribers are notified immediately.
1. **Subject(News Publisher)** This is the main publisher that manages the list of subscribers.
2. **Observers(App Users):** Each user subscribes to the topics of their interest.
3. **Concrete Subject(A Specific News Topic (e.g., "Sports" topic)):** When there’s a new sports update, all subscribers to that topic are notified.
4. **Concrete Observer(Individual User App):** Each user receives a notification based on the topic they subscribed to.

**Case-Study:** E-commerce platform notifies all users (observers) when a product’s status (subject) is updated. This could involve changes in availability, such as "In Stock," "Out of Stock," or "Coming Soon."
1. **ISubject:** Defines methods to register, remove, and notify observers.
2. **IObserver:** Defines an Update() method that gets triggered when there’s a change in the subject.
3. **Product:** The subject that notifies all observers (users) when its status changes.
4. **User:** The observer that receives updates from the product.

## Domain Driven Design Pattern

### Domain:
The domain represnts the core business logics and rules of an application. It contains `Entity, Value Object, aggregates and domain services.` For example, an e-commerce app, the domain would include entities like `Order, Customer, Product` and `value objects` like `address, money.`
(ডোমেইন একটি অ্যাপ্লিকেশনের মূল বিজনেস লজিক এবং রুলসগুলো প্রতিনিধিত্ব করে। এতে `এনটিটি, ভ্যালু অবজেক্ট, অ্যাগ্রিগেটস এবং ডোমেইন সার্ভিসেস` থাকে। উদাহরণস্বরূপ, একটি ই-কমার্স অ্যাপে, ডোমেইনের মধ্যে `Order, Customer, Product`-এর মতো এনটিটি এবং `address, money`-এর মতো ভ্যালু অবজেক্ট অন্তর্ভুক্ত থাকবে।)
```c#
public class Order{
    public int OrderId{get; private set;}
    public Customer Customer{get; private set;}
    public List<OrderItem>Items{get;private set;}
    public Address ShippingAddress{get; private set;}

    //Business Logic Method
    public void AddItem(Product product, int quantity){}
    public void ShipOrder(){}
}
```

#### Entities:
Entities are objects that have unique identity and runs through time and different states. For example- In the `Order` class above `Order and Customer` are entities because both of them have unique `Identifier`.
(এনটিটি হলো এমন অবজেক্ট যার একটি অনন্য পরিচয় আছে এবং যা সময় ও বিভিন্ন অবস্থার মধ্য দিয়ে চলে। উদাহরণস্বরূপ- উপরের `Order` ক্লাসে `Order এবং Customer` হলো এনটিটি কারণ তাদের উভয়েরই অনন্য `আইডেন্টিফায়ার` রয়েছে।)

```c#
public class Customer{
    public int CustomerId{get; private set;}
    public string Name{get; private set;}
    public Address BillingAdress{get; private set;}
}
```

#### Value object:
Value object describes some characteristics but do not have a identifier. For example, `Address, and Money` can be considered value objects.
(ভ্যালু অবজেক্ট কিছু বৈশিষ্ট্য বর্ণনা করে কিন্তু এর কোনো আইডেন্টিফায়ার থাকে না। উদাহরণস্বরূপ, `Address, এবং Money` কে ভ্যালু অবজেক্ট হিসাবে বিবেচনা করা যেতে পারে।)
```c#
public class Address{
    public string Street{get; private set;}
    public string City{get; private set;}
    public string PostalCode{get; private set;}

    public Address(string street, string city, string postalCode){
        Street=street;
        City=city;
        PostalCode=postalCode;
    }
    
}
```

#### Aggregates and aggeragate Root:

Aggregates are a cluster of domain objects that can be treated as a single unit. An aggregate root is an entity that is the entry point to the aggregate.
(অ্যাগ্রিগেটস হলো ডোমেইন অবজেক্টের একটি ক্লাস্টার বা সমষ্টি যেগুলোকে একক ইউনিট হিসাবে বিবেচনা করা যেতে পারে। একটি অ্যাগ্রিগেট রুট হলো এমন একটি এনটিটি যা অ্যাগ্রিগেটের প্রবেশপথ বা এন্ট্রি পয়েন্ট।)

- `Order` can be an aggregate root
- `OrderItem` can be part of aggregate.

```c#
public class OrderItem{
    public int OrderId{get; private set;}
    public Product Product{get; private set;}
    public int Quantity{get; private set;}

    public OrderItem(Product product, int quantity){
        Product=product;
        Quantity=quantity;
    }
}
```

#### Repository:

Repositories provide an abstraction for data access, encapsulating the logic for retrieving and storing aggregates.
(রিপোজিটরিগুলো ডেটা অ্যাক্সেসের জন্য একটি অ্যাবস্ট্রাকশন প্রদান করে, যা অ্যাগ্রিগেটস উদ্ধার ও সংরক্ষণ করার লজিককে এনক্যাপসুলেট করে।)

```c#
public interface IOrderRepository
{
    Order GetOrderById(int orderId);
    void Save(Order order);
}

public class OrderRepository : IOrderRepository
{
    private readonly DbContext _context;

    public OrderRepository(DbContext context)
    {
        _context = context;
    }

    public Order GetOrderById(int orderId)
    {
        return _context.Orders
            .Include(o => o.Items)
            .FirstOrDefault(o => o.OrderId == orderId);
    }

    public void Save(Order order)
    {
        _context.Orders.Update(order);
        _context.SaveChanges();
    }
}
```

#### Domain Service:

Domain Services contain business logic that doesn't naturally fit within an entity or value objects.
(ডোমেইন সার্ভিসে এমন বিজনেস লজিক থাকে যা প্রাকৃতিকভাবে কোনো এনটিটি বা ভ্যালু অবজেক্টের মধ্যে খাপ খায় না।)

```c#
public class OrderService
{
    private readonly IOrderRepository _orderRepository;

    public OrderService(IOrderRepository orderRepository)
    {
        _orderRepository = orderRepository;
    }

    public void PlaceOrder(Customer customer, List<OrderItem> items, Address shippingAddress)
    {
        var order = new Order(customer, items, shippingAddress);
        _orderRepository.Save(order);
    }
}
```

#### Bounded Context:
A bounded context is a logical boundary within the domain where a particular model is defined and applicable.
(বাউন্ডেড কনটেক্সট হলো ডোমেইনের মধ্যে একটি লজিক্যাল সীমানা যেখানে একটি নির্দিষ্ট মডেল সংজ্ঞায়িত এবং প্রযোজ্য হয়।)
- Order Management
- Inventory Management
- Customer Management
```c#
// Order management
namspace OrderManagement{
    public class Order{}
    public class Customer{}
}
```
```c#
// Inventory management
namspace InventoryManagement{
    public class Product{}
    public class StockItem{}
}
```

### Event Stroming
Event Stroming is a collaborative workshop technique used to quickly explore complex business domains and uncover the key events that drive process.
(ইভেন্ট স্টর্মিং হলো একটি সহযোগিতামূলক ওয়ার্কশপ কৌশল যা জটিল বিজনেস ডোমেইনগুলো দ্রুত অন্বেষণ করতে এবং প্রসেস চালনাকারী মূল ইভেন্টগুলো উন্মোচন করতে ব্যবহৃত হয়।)
1. ***Big Picture Event Stroming:***
   1. ***Identify domain events:*** Identify Domain Events that occur in the domain.
      - `Order Management, Payment received`
   2. ***Organize Event:*** Arrange events chronologically in order to understand the flow of the business process.
2. ***Process Level Event Stroming:***
   1. ***`Commands:`*** Place Order, Receive Payment
   2. ***Aggregate:*** Order, Product, Customer
   3. ***External System:*** Payment gateway, Shipping Service
3. ***Design Level Stroming:***
   1. ***`Detailed Exploration:`***
      - For `"Order Placed"` idetify sub-evnts such as `"Inventory Checked", "Order Validated"`
      - For `"Payment received"` -> identify sub events as `"Payment Verified", "Receipt Generated"`
   2. ***Hotspot:***
      - Complex payment Processing
      - Inventory Management synchronization  

### Anemic Model:
A anemic model is a domain model where the `business logic` is seperated from the data. Typically, it conatins only entities with properties but no behaviors, leading to a vialation of the principle of encapsulation.
(অ্যানেমিক মডেল হলো এমন একটি ডোমেইন মডেল যেখানে ডেটা থেকে `বিজনেস লজিক` আলাদা থাকে। সাধারণত, এতে কেবল প্রপার্টিসহ এনটিটি থাকে কিন্তু কোনো আচরণ থাকে না, যা এনক্যাপসুলেশনের নীতি লঙ্ঘন করে।)
```c#
public class Order{
    public int OrderId{get; set;}
    public Customer Customer{get; set;}
    public List<OrderItem>Items{get; set;}
    public Address ShippingAddress{get; set;}
    pubic bool IsPaid{get;set;}
    pubic bool IsShipped{get;set;}
}
```
For example, `IsPaid and IsShipped` would be handled outside of the `Order` class.

### Conceptual Class:
Condeptual class encapsulates both state and behaviors.
(কনসেপচুয়াল ক্লাস স্টেট এবং বিহেইভিয়ার বা আচরণ উভয়কেই এনক্যাপসুলেট করে।)
```c#
public class Order{
    public int OrderId{get; private set;}
    public GUID CustomerId{get; private set;}
    public List<OrderItem>Items{get;private set;}
    public Address ShippingAddress{get; private set;}
    pubic bool IsPaid{get; private set;}
    pubic bool IsShipped{get; private set;}

    public Order(GUID customerId, List<OrderItem> items){
        OrderId= Guid.NewGuid();
        CustomerId= customerId;
        Items= items;
    }
    public void MarkAsPaid(){
        IsPaid=true
    }

    public void MarkAsShipped(){
        IsShipped=true
    }
    //Business Logic Method
    public void AddItem(Product product, int quantity){}
    public void ShipOrder(){}
}
```

### Object Model:
An object model represents the objects in domain, their attributes, relationships, and iteractions.
(একটি অবজেক্ট মডেল ডোমেইনের অবজেক্ট, তাদের অ্যাট্রিবিউট, সম্পর্ক এবং ইন্টারঅ্যাকশনগুলোকে উপস্থাপন করে।)

### State Transition:
State transition represent changes in the state of an objects in response to events or commands.
(স্টেট ট্রানজিশন কোনো ইভেন্ট বা কমান্ডের প্রতিক্রিয়া হিসেবে অবজেক্টের অবস্থার পরিবর্তনকে উপস্থাপন করে।)

### Domain Event:
Domain events are occurences in the domain that trigger state transitions or other business logic.
(ডোমেইন ইভেন্টগুলো হলো ডোমেইনে এমন ঘটনা যা স্টেট ট্রানজিশন বা অন্যান্য বিজনেস লজিক ট্রিগার করে।)

## Common Interview Questions and Answers (সাধারণ ইন্টারভিউ প্রশ্ন ও উত্তর)

### 1. What is the difference between a Design Pattern and an Architectural Pattern?
**Answer:** A design pattern is a solution to a specific problem at the component or class level (e.g., Singleton, Factory). An architectural pattern is a broader strategy that dictates the high-level structure and flow of the entire application (e.g., MVC, Microservices).
**(উত্তর:** ডিজাইন প্যাটার্ন হলো কম্পোনেন্ট বা ক্লাস লেভেলের একটি নির্দিষ্ট সমস্যার সমাধান (যেমন: সিঙ্গেলটন, ফ্যাক্টরি)। অন্যদিকে, আর্কিটেকচারাল প্যাটার্ন হলো একটি বিস্তৃত কৌশল যা পুরো অ্যাপ্লিকেশনের হাই-লেভেল স্ট্রাকচার এবং ফ্লো নির্ধারণ করে (যেমন: MVC, মাইক্রোসার্ভিসেস)।)

### 2. Why should we use the Factory Pattern instead of a direct constructor (
ew keyword)?
**Answer:** Using the Factory Pattern promotes loose coupling. It centralizes the object creation logic, making it easier to manage and modify without changing the client code. It also aligns with the Open/Closed Principle, as you can introduce new types without modifying existing code.
**(উত্তর:** ফ্যাক্টরি প্যাটার্ন লুজ কাপলিং-কে প্রোমোট করে। এটি অবজেক্ট তৈরির লজিককে কেন্দ্রীভূত করে, যার ফলে ক্লায়েন্ট কোড পরিবর্তন না করেই এটি পরিচালনা এবং পরিবর্তন করা সহজ হয়। এটি ওপেন/ক্লোজড প্রিন্সিপাল-এর সাথেও সামঞ্জস্যপূর্ণ, কারণ আপনি বিদ্যমান কোড পরিবর্তন না করেই নতুন টাইপ যুক্ত করতে পারেন।)

### 3. Can you explain the difference between Factory Method and Abstract Factory?
**Answer:** The Factory Method pattern is used to create one specific type of product, allowing subclasses to decide which class to instantiate. The Abstract Factory pattern, on the other hand, is used to create families of related or dependent objects without specifying their concrete classes.
**(উত্তর:** ফ্যাক্টরি মেথড প্যাটার্ন একটি নির্দিষ্ট ধরণের প্রোডাক্ট তৈরি করতে ব্যবহৃত হয়, যা সাবক্লাসগুলোকে সিদ্ধান্ত নিতে দেয় যে কোন ক্লাসটি ইনস্ট্যান্সিয়েট করা হবে। অন্যদিকে, অ্যাবস্ট্রাক্ট ফ্যাক্টরি প্যাটার্ন কংক্রিট ক্লাস নির্দিষ্ট না করেই সম্পর্কিত বা নির্ভরশীল অবজেক্টের ফ্যামিলি তৈরি করতে ব্যবহৃত হয়।)

### 4. What is the Singleton Pattern, and why is it sometimes considered an anti-pattern?
**Answer:** The Singleton pattern ensures a class has only one instance and provides a global access point to it. It is sometimes considered an anti-pattern because it introduces global state into an application, which creates hidden dependencies, makes unit testing difficult, and can cause bottlenecks in multi-threaded environments.
**(উত্তর:** সিঙ্গেলটন প্যাটার্ন নিশ্চিত করে যে একটি ক্লাসের কেবল একটিমাত্র ইনস্ট্যান্স থাকবে এবং এর জন্য একটি গ্লোবাল অ্যাক্সেস পয়েন্ট প্রদান করে। এটিকে মাঝে মাঝে অ্যান্টি-প্যাটার্ন হিসেবে বিবেচনা করা হয় কারণ এটি অ্যাপ্লিকেশনে গ্লোবাল স্টেট নিয়ে আসে, যা লুকানো ডিপেনডেন্সি তৈরি করে, ইউনিট টেস্টিং কঠিন করে তোলে এবং মাল্টি-থ্রেডেড পরিবেশে বাধার সৃষ্টি করতে পারে।)

### 5. What is the main purpose of the Strategy Pattern?
**Answer:** The Strategy Pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable. It allows the algorithm to vary independently from the clients that use it. It is commonly used to replace large if-else or switch statements, promoting the Open/Closed Principle.
**(উত্তর:** স্ট্র্যাটেজি প্যাটার্ন অ্যালগরিদমের একটি ফ্যামিলি সংজ্ঞায়িত করে, প্রত্যেকটিকে এনক্যাপসুলেট করে এবং সেগুলোকে বিনিময়যোগ্য করে তোলে। এটি অ্যালগরিদমকে ক্লায়েন্টদের থেকে স্বাধীনভাবে পরিবর্তিত হওয়ার সুযোগ দেয়। বড় if-else বা switch স্টেটমেন্ট প্রতিস্থাপন করতে এটি সাধারণত ব্যবহৃত হয়, যা ওপেন/ক্লোজড প্রিন্সিপাল-কে প্রোমোট করে।)

### 6. How does the Observer Pattern work? Give a real-world example.
**Answer:** The Observer Pattern establishes a one-to-many relationship where one object (the Subject) notifies multiple dependent objects (Observers) of any state changes. A real-world example is a YouTube channel (Subject): when a new video is uploaded, all subscribed users (Observers) receive a notification.
**(উত্তর:** অবজারভার প্যাটার্ন একটি ওয়ান-টু-মেনি সম্পর্ক স্থাপন করে যেখানে একটি অবজেক্ট (সাবজেক্ট) তার যেকোনো অবস্থার পরিবর্তনে একাধিক নির্ভরশীল অবজেক্টকে (অবজার্ভারদের) অবহিত করে। এর একটি বাস্তব উদাহরণ হলো ইউটিউব চ্যানেল (সাবজেক্ট): যখন নতুন ভিডিও আপলোড করা হয়, তখন সাবস্ক্রাইব করা সকল ব্যবহারকারী (অবজার্ভাররা) নোটিফিকেশন পান।)

### 7. What is an Anemic Domain Model in Domain-Driven Design (DDD)?
**Answer:** An Anemic Domain Model is a domain model where entities contain only data (properties/getters/setters) but no business logic or behaviors. This is considered an anti-pattern in DDD because it violates encapsulation, moving the actual business logic to separate service classes instead of keeping it within the entities.
**(উত্তর:** অ্যানেমিক ডোমেইন মডেল হলো এমন একটি ডোমেইন মডেল যেখানে এনটিটিগুলোতে কেবল ডেটা (প্রপার্টি/গেটার/সেটার) থাকে কিন্তু কোনো বিজনেস লজিক বা আচরণ থাকে না। এটি DDD তে একটি অ্যান্টি-প্যাটার্ন হিসেবে বিবেচিত হয় কারণ এটি এনক্যাপসুলেশন লঙ্ঘন করে এবং বিজনেস লজিককে এনটিটির ভেতরে রাখার বদলে আলাদা সার্ভিস ক্লাসে সরিয়ে দেয়।)

### 8. Explain the difference between an Entity and a Value Object in DDD.
**Answer:** An Entity has a unique identity that remains consistent over time and through different states (e.g., a User with a unique UserID). A Value Object, however, has no distinct identity; it is defined solely by its attributes (e.g., an Address or Money). If two Value Objects have the exact same attributes, they are considered identical.
**(উত্তর:** একটি এনটিটির একটি অনন্য পরিচয় (identity) থাকে যা সময়ের সাথে এবং বিভিন্ন অবস্থার মধ্য দিয়ে সামঞ্জস্যপূর্ণ থাকে (যেমন: অনন্য UserID সহ একজন User)। অন্যদিকে, ভ্যালু অবজেক্টের কোনো আলাদা পরিচয় থাকে না; এটি শুধুমাত্র এর অ্যাট্রিবিউট দ্বারা সংজ্ঞায়িত হয় (যেমন: একটি Address বা Money)। যদি দুটি ভ্যালু অবজেক্টের অ্যাট্রিবিউট হুবহু একই হয়, তবে তাদেরকে অভিন্ন হিসেবে বিবেচনা করা হয়।)

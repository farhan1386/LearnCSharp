   # Phase 5: Design Patterns & Architectural 

   ## 1. Architectural Taxonomy Matrix

    Object-oriented design templates are classified into three core problem domains as defined by the Gang of Four (GoF):

    | Classification | Structural Focus Area | Architectural Target |
    | :--- | :--- | :--- |
    | **Creational** | Object instantiation, lifecycle isolation, and heap allocation control. | Decouples a system from how its concrete components are generated, composed, and represented. |
    | **Structural** | Interface matching, inheritance trees, object composition, and decoupling. | Simplifies designs by identifying clear, clean ways to compose interacting classes and systems. |
    | **Behavioral** | Algorithm distribution, state progression, and messaging pipelines. | Optimizes runtime communication, responsibilities, and routing mechanics between interacting components. |

    ---

*   **What are Design Patterns?**
    Design patterns are reusable solutions to the problems that we encounter in the day to day programming. 
    They are generally targeted at solving the problems of object generation and integration. In other words, 
    Design patterns acts as templates which can be applied to the real-world programming problems.

*   **What are the types of Design Patterns?**
    Gang of Four (GoF) categorized the Design Pattern into three main categories based on the three problem areas of 
    software architecture:

    **Creational Patterns** — 
    
      These patterns deal with object creation and initialization. Creational patterns give the program more flexibility in deciding which objects need to be created for a given case.
        
        *   **Singleton:** Ensures a class has only one instance and provides a global point of access to it.
        *   **Factory Method:** Defines an interface for creating an object, but lets subclasses decide which class to instantiate. Factory Method lets a class defer instantiation to subclasses.
        *   **Abstract Factory:** Provides an interface for creating families of related or dependent objects without specifying their concrete classes.
        *  **Builder:** Separates the construction of a complex object from its representation so that the same construction process can create different representations.
        *  **Prototype:** Specifies the kinds of objects to create using a prototypical instance, and create new objects by copying this prototype.

    **Structural Patterns** —

       These patterns deal with class and object composition. In simple words, this pattern focuses on decoupling interface, implementation of classes and its objects.

        *   **Adapter:** Converts the interface of a class into another interface clients expect. Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.
        *   **Bridge:** Decouples an abstraction from its implementation so that the two canvary independently.
        *   **Composite:** Composes objects into tree structures to represent part-whole hierarchies. Composite lets clients treat individual objects and compositions of objects uniformly. 
        *   **Decorator:** Attaches additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.
        *   **Facade:** Provides a unified interface to a set of interfaces in a subsystem.
        *   **Flyweight:** Uses sharing to support large numbers of fine-grained objects efficiently 
        *   **Proxy:** Provides a surrogate or placeholder for another object to control access to it.

    **Behavioral Patterns** -

       These patterns are concerned with algorithms and the assignment of responsibilities between objects. Behavioral patterns describe not just patterns of objects or classes but also the patterns of communication between them.
        
        *   **Chain of Responsibility:** Avoids coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. Chain the receiving objects and pass the request along the chain until an object handles it.
        *   **Command:** Encapsulates a request as an object, thereby letting you parameterize clients with different requests, queue or log requests, and support undoable operations.
        *   **Interpreter:** Given a language, defines a representation for its grammar along with an interpreter that uses the representation to interpret sentences in the language.
        *   **Iterator:** Provides a way to access the elements of an aggregate object sequentially without exposing its underlying representation.
        *   **Mediator:** Defines an object that encapsulates how a set of objects interact. Mediator promotes loose coupling by keeping objects from referring to each other explicitly, and it lets you vary their interaction independently.
        *   **Memento:** Without violating encapsulation, captures and externalizes an object's internal state so that the object can be restored to this state later.
        *   **Observer:** Defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.
        *   **State:** Allows an object to alter its behavior when its internal state changes. The object will appear to change its class.
        *   **Strategy:** Defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from clients that use it.
        *   **Template Method:** Defines the skeleton of an algorithm in an operation, deferring some steps to subclasses. Template Method lets subclasses redefine certain steps of an algorithm without changing the algorithm's structure.
        *   **Visitor:** Represents an operation to be performed on the elements of an object structure. Visitor lets you define a new operation without changing the classes of the elements on which it operates.


### Day 1: Singleton Design Pattern

*   **Study Focus:** Creating a class of which only a single instance can exist, ensuring full alignment with OOP properties over keyword limits.
*   `singleton_naive.cs` — **Thread-Unsafe Singleton:** Analyzing how standard lazily instantiated structures fail and create duplicate objects under concurrent operations.
*   `singleton_thread_safe.cs` — **Thread-Safe Pattern:** Implementing double-checked locking mechanisms with OOP capabilities (interfaces/disposal) to show differences from static limits.

---

#### 📌 Theoretical Blueprint

*   **Core Concept:** **Singleton** is a creational design pattern that lets you ensure that a class has only one instance, while providing a global access point to this instance.
*   **The Problem:** Imagine that you’re creating a global system resource logger for your enterprise application. The first version of your app creates a new logger object every time a component needs to write a log file, meaning multiple distinct class allocations happen across different tasks. Currently, these separate instances cause heavy resource waste, slow down performance under load, and can lock files or write over each other's configuration records when multiple threads try to log telemetry updates at the exact same split second.
*   **The Solution:** The Singleton pattern suggests that you replace public default constructors with a private constructor to explicitly block external instantiation using the `new` operator. Don’t worry: the object is still created via the `new` operator, but it’s being called from within a special global access point method. By checking whether an instance has already been allocated in memory before returning the reference, the system guarantees a single thread-safe instance across your entire application execution lifecycle.

---

#### ❌ The Thread-Unsafe (Naive) Singleton Code (`singleton_naive.cs`)
```csharp
using System;

namespace Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns
{
    /// <summary>
    /// ANTI-PATTERN: Naive Lazy Initialization.
    /// In a multi-threaded web application, multiple threads hitting the 'Instance' 
    /// getter simultaneously can execute the 'new' block concurrently, 
    /// creating multiple distinct instances and violating the Singleton contract.
    /// </summary>
    public sealed class NaiveLogger
    {
        private static NaiveLogger _instance;

        private NaiveLogger() { }

        public static NaiveLogger Instance
        {
            get
            {
                // Race Condition Hazard: Threads can pass this check at the same split second
                if (_instance == null)
                {
                    _instance = new NaiveLogger();
                }
                return _instance;
            }
        }

        public void Log(string message) => Console.WriteLine($"Log: {message}");
    }
}
```

####  The Thread-Safe Polyfilled Enterprise Solution Code (`singleton_thread_safe.cs`)
```csharp
using System;

namespace Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns
{
    // ==========================================
    // 1. THE SHARED SERVICE ABSTRACTION CONTRACT
    // ==========================================
    public interface ILoggerService
    {
        void Log(string message);
    }

    // ==========================================
    // 2. THE THREAD-SAFE SINGLETON SERVICE
    // ==========================================
    /// <summary>
    /// PRAGMATIC ENTERPRISE SINGLETON: Uses double-checked locking mechanisms
    /// combined with inheritance-driven interfaces to guarantee runtime thread safety 
    /// while remaining completely open to unit test mock substitution.
    /// </summary>
    public sealed class Logger : ILoggerService, IDisposable
    {
        private static Logger _instance;
        private static readonly object _lockPadlock = new object();
        private bool _isDisposed;

        // Private constructor prevents external instantiation via the 'new' operator
        private Logger()
        {
            Console.WriteLine("[Subsystem] Internal logging thread-safe pipeline allocated.");
        }

        // Global access point managing the object's life cycle markers
        public static Logger Instance
        {
            get
            {
                // First Check: Avoids taking an expensive lock if the instance already exists
                if (_instance == null)
                {
                    lock (_lockPadlock)
                    {
                        // Second Check (Double-Checked Locking): Ensures subsequent threads 
                        // waiting on the lock block do not recreate the object instance
                        if (_instance == null)
                        {
                            // The instance object is safely created via the new operator inside here
                            _instance = new Logger();
                        }
                    }
                }
                return _instance;
            }
        }

        public void Log(string message)
        {
            if (_isDisposed) throw new ObjectDisposedException(nameof(Logger));
            Console.WriteLine(\$"[Thread-Safe Log] {message}");
        }

        public void Dispose()
        {
            lock (_lockPadlock)
            {
                if (!_isDisposed)
                {
                    // Release any persistent streams, sockets, or file handles here
                    _isDisposed = true;
                    _instance = null; // Clear out instance for future lifecycle demands
                    Console.WriteLine("[Subsystem] Logging pipeline disposed safely.");
                }
            }
        }
    }

    // ==========================================
    // 3. APPLICATION RUNTIME ACCESS CLIENT
    // ==========================================
    public static class SingletoneClient
    {
        public static void Main()
        {
            // Consumer interacts safely via the global access point routing instead of raw 'new' calls
            ILoggerService logger = Logger.Instance;
            logger.Log("Application architecture runtime initialized successfully.");
        }
    }
}
```


### Day 2: Simple Factory Pattern (Design Idiom)

*   **Study Focus:** The Simple Factory pattern encapsulates object creation logic into a single dedicated factory class. Unlike the formal GoF Factory Method pattern, it does not use inheritance or subclasses to defer instantiation; instead, it relies on a single static method containing a conditional switch routine to return concrete objects behind a shared interface contract.
*   `notification_factory_violation.cs` — **Tight Instantiation:** Hardcoding initialization across client pathways, showing why adding new notification types breaks existing classes.
*   `notification_factory_pattern.cs` — **Encapsulated Creation:** Utilizing a centralized factory structure to supply specific subclasses dynamically without changing client loops.

---

#### 📌 Theoretical Blueprint

*   **Core Concept:** **Simple Factory** is an architectural design idiom (not an official Gang of Four design pattern) that describes a class which has one creation method with a large conditional block that chooses which concrete class to instantiate based on method arguments.
*   **The Problem:** Imagine that you’re creating a notification management subsystem for your enterprise application. The first version of your app can only handle alerts by email, so the bulk of your code lives inside the `EmailNotification` class. After a while, your app becomes pretty popular. Each day you receive dozens of requests from product teams to incorporate SMS, Push, and WhatsApp logistics into the app. Currently, most of your code is tightly coupled to the `EmailNotification` class. Adding fresh communication platforms into the app requires making sweeping changes to the entire codebase. If you decide later to add another channel, you will need to modify the codebase again, violating the **Open-Closed Principle** and risking unexpected regression bugs.
*   **The Solution:** The Simple Factory pattern suggests that you replace direct object construction calls (using the `new` operator) with calls to a special factory method. Don’t worry: the objects are still created via the `new` operator, but it’s being called from within the factory method. Objects returned by a factory method are often referred to as products. By extracting all concrete instantiation logic into a single centralized helper class, your core application workflows interact strictly with a common interface contract (`INotification`) and an explicit enumeration profile (`NotificationChannel`), allowing you to isolate creation concerns and protect downstream components from changes.

---

#### ❌ The Tight Instantiation Violation Code (`notification_factory_violation.cs`)
```csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns
{
    /// <summary>
    /// ANTI-PATTERN: Tight Instantiation.
    /// Hardcoding instantiation directly across client pathways. Adding new notification 
    /// channels (like "WhatsApp") forces you to modify this core class, 
    /// breaking existing closed configurations and violating the Open-Closed Principle (OCP).
    /// </summary>
    public class notification_factory_violation
    {
        public void SendAlert(string platform, string recipient, string message)
        {
            // Direct object coupling prevents easy extension
            if (platform.Equals("Email", StringComparison.OrdinalIgnoreCase))
            {
                var email = new EmailNotificationChannel();
                email.Send(recipient, message);
            }
            else if (platform.Equals("SMS", StringComparison.OrdinalIgnoreCase))
            {
                var sms = new SmsNotificationChannel();
                sms.Send(recipient, message);
            }
            // ❌ VIOLATION: Adding Push and WhatsApp forces structural modifications to this code file
            else if (platform.Equals("Push", StringComparison.OrdinalIgnoreCase))
            {
                var push = new PushNotificationChannel();
                push.Send(recipient, message);
            }
            else
            {
                throw new ArgumentException("Unsupported notification channel platform.");
            }
        }
    }

    public class EmailNotificationChannel { public void Send(string to, string msg) => Console.WriteLine($"Email to {to}: {msg}"); }
    public class SmsNotificationChannel { public void Send(string to, string msg) => Console.WriteLine($"SMS to {to}: {msg}"); }
    public class PushNotificationChannel { public void Send(string to, string msg) => Console.WriteLine($"Push to {to}: {msg}"); }
}
```

####  The Encapsulated Creation Solution Code (`notification_factory_pattern.cs`)
```csharp
using System;

namespace Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns
{
    // ==========================================
    // 1. THE SHARED ABSTRACTION CONTRACT (Product Interface)
    // ==========================================
    public interface INotification
    {
        void Send(string recipient, string message);
    }

    // ==========================================
    // 2. EXPLICIT ENUMERATION PROFILE
    // ==========================================
    public enum NotificationChannel
    {
        Email,
        Sms,
        Push,
        WhatsApp
    }

    // ==========================================
    // 3. CONCRETE PRODUCTS
    // ==========================================
    public class EmailNotification : INotification
    {
        public void Send(string recipient, string message) =>
            Console.WriteLine(\$"Sending Email to {recipient}: {message}");
    }

    public class SmsNotification : INotification
    {
        public void Send(string recipient, string message) =>
            Console.WriteLine(\$"Sending SMS to {recipient}: {message}");
    }

    public class PushNotification : INotification
    {
        public void Send(string recipient, string message) =>
            Console.WriteLine(\$"Sending Push Notification to {recipient}: {message}");
    }

    public class WhatsAppNotification : INotification
    {
        public void Send(string recipient, string message) =>
            Console.WriteLine(\$"Sending WhatsApp notification to {recipient}: {message}");
    }

    // ==========================================
    // 4. THE CENTRALIZED SIMPLE FACTORY ENGINE
    // ==========================================
    public static class NotificationFactory
    {
        public static INotification CreateNotification(NotificationChannel channel)
        {
            // Don’t worry: the objects are still created via the new operator, but it’s being called from within the factory method.
            switch (channel)
            {
                case NotificationChannel.Email:
                    return new EmailNotification();
                case NotificationChannel.Sms:
                    return new SmsNotification();
                case NotificationChannel.Push:
                    return new PushNotification();
                case NotificationChannel.WhatsApp:
                    return new WhatsAppNotification();
                default:
                    throw new ArgumentException("Invalid notification channel");
            }
        }
    }

    // ==========================================
    // 5. DECOUPLED APPLICATION EXECUTION CLIENT
    // ==========================================
    public static class SimpleFactoryClient
    {
        public static void Main()
        {
            // High-level system interacts exclusively with the interface and the factory helper
            INotification notification;

            Console.WriteLine("--- Initializing Encapsulated Creation Loops ---");

            // Dispatching via Email 
            notification = NotificationFactory.CreateNotification(NotificationChannel.Email);
            notification.Send("user@example.com", "Hello, this is an email notification test message.");

            // Dispatching via SMS
            notification = NotificationFactory.CreateNotification(NotificationChannel.Sms);
            notification.Send("+1234567890", "Hello, this is an SMS alert test message.");

            // Dispatching via Push
            notification = NotificationFactory.CreateNotification(NotificationChannel.Push);
            notification.Send("device_token_abc123", "Hello, this is a push notification test message.");

            // Dispatching via WhatsApp (Integrated smoothly into the central factory without touching core client loops)
            notification = NotificationFactory.CreateNotification(NotificationChannel.WhatsApp);
            notification.Send("+1234567890", "Hello, this is a WhatsApp notification test message.");
        }
    }
}
```
### Day 3: Factory Method Design Pattern

*   **Study Focus:** The Factory Method design pattern defines an interface for creating an object, but lets subclasses decide which class to instantiate. This pattern lets a class defer instantiation to subclasses.
*   `Factory_Pattern.cs` — **Tight Instantiation:** Hardcoding initialization across client pathways, showing why adding new appointment types breaks existing classes.
*   `AppointmentFactory.cs` — **Polymorphic Creation:** Utilizing creator subclasses to override the factory method and supply specific appointment types dynamically without changing client execution loops.

---

#### 📌 Theoretical Blueprint

*   **Core Concept:** **Factory Method** is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.
*   **The Problem:** Imagine that you’re creating an enterprise clinic scheduling management subsystem for your healthcare application. The first version of your app can only handle basic healthcare visits via an email checkup scheduling router, so the bulk of your system is tightly coupled to a single `CheckupAppointment` class. After a while, your app becomes highly popular, and clinic management demands the incorporation of **Orthodontic and Root Canal appointment logistics** into the app. Hardcoding these new professional scheduling tracks using conditional `if/else` or `switch` statements directly inside your central scheduling loop creates tight coupling. Every time a new clinical appointment profile is introduced, you have to tear open your core registration logic file, violating the **Open-Closed Principle** and risking regression bugs across legacy booking workflows.
*   **The Solution:** The Factory Method pattern suggests that you replace direct object construction calls (using the `new` operator) with calls to a special factory method. Don’t worry: the objects are still created via the `new` operator, but it’s being called from within the factory method. Objects returned by a factory method are often referred to as products. By creating separate derived child creator classes for each classification, you can override the abstract factory method to alter the type of product instances being generated. Your high-level application orchestrator interacts strictly with a common interface contract (`IAppointment`), allowing you to plug in Orthodontics or Root Canal scheduling pipelines cleanly without rewriting core management files.

---

#### ❌ The Tight Instantiation Violation Code (`Factory_Pattern.cs`)
```csharp
using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_5_Design_Patterns.Week_5.FactoryMethod
{
    /// <summary>
    /// ANTI-PATTERN: Tight Instantiation.
    /// Hardcoding instantiation directly across client pathways. Adding new scheduling 
    /// pipelines (like "RootCanal") forces you to modify this core class, 
    /// breaking existing closed configurations and violating the Open-Closed Principle (OCP).
    /// </summary>
    public class Factory_Pattern
    {
        public void BookClinicSession(string appointmentType, string patientName, string timeSlot)
        {
            // Direct object coupling prevents clean architectural extensions
            if (appointmentType.Equals("Checkup", StringComparison.OrdinalIgnoreCase))
            {
                var checkup = new LocalCheckupAppointment();
                checkup.Schedule(patientName, timeSlot);
            }
            else if (appointmentType.Equals("Orthodontic", StringComparison.OrdinalIgnoreCase))
            {
                var ortho = new LocalOrthodonticAppointment();
                ortho.Schedule(patientName, timeSlot);
            }
            // ❌ VIOLATION: Incorporating RootCanal forces structural modifications to this code file
            else if (appointmentType.Equals("RootCanal", StringComparison.OrdinalIgnoreCase))
            {
                var canal = new LocalRootCanalAppointment();
                canal.Schedule(patientName, timeSlot);
            }
            else
            {
                throw new ArgumentException("Unsupported clinic session profile.");
            }
        }
    }

    public class LocalCheckupAppointment { public void Schedule(string p, string t) => Console.WriteLine($"Checkup booked for {p} at {t}"); }
    public class LocalOrthodonticAppointment { public void Schedule(string p, string t) => Console.WriteLine($"Ortho booked for {p} at {t}"); }
    public class LocalRootCanalAppointment { public void Schedule(string p, string t) => Console.WriteLine($"Root Canal booked for {p} at {t}"); }
}
```

####  The Polymorphic Creation Solution Code (Distributed Project Files)

##### File: `Interfaces/IAppointment.cs`
```csharp
namespace Phase_5_Design_Patterns.Week_5.FactoryMethod.Interfaces
{
    // ==========================================
    // 1. THE SHARED ABSTRACTION CONTRACT (Product Interface)
    // ==========================================
    public interface IAppointment
    {
        void Schedule(string patientName, string timeSlot);
    }
}
```

##### File: `Enums/AppointmentTypes.cs`
```csharp
namespace Phase_5_Design_Patterns.Week_5.FactoryMethod.Enums
{
    public enum AppointmentType
    {
        Checkup,
        Orthodontic,
        RootCanal
    }
}
```

##### File: `ConcreteProducts/CheckupAppointment.cs`
```csharp
using System;
using Phase_5_Design_Patterns.Week_5.FactoryMethod.Interfaces;

namespace Phase_5_Design_Patterns.Week_5.FactoryMethod.ConcreteProducts
{
    public class CheckupAppointment : IAppointment
    {
        public void Schedule(string patientName, string timeSlot) =>
            Console.WriteLine($"[General Dentistry] Scheduled Checkup for {patientName} at {timeSlot}.");
    }
}
```

##### File: `ConcreteProducts/OrthodonticAppointment.cs`
```csharp
using System;
using Phase_5_Design_Patterns.Week_5.FactoryMethod.Interfaces;

namespace Phase_5_Design_Patterns.Week_5.FactoryMethod.ConcreteProducts
{
    public class OrthodonticAppointment : IAppointment
    {
        public void Schedule(string patientName, string timeSlot) =>
            Console.WriteLine($"[Specialist Care] Scheduled Orthodontic Adjustment for {patientName} at {timeSlot}.");
    }
}
```

##### File: `ConcreteProducts/RootCanalAppointment.cs`
```csharp
using System;
using Phase_5_Design_Patterns.Week_5.FactoryMethod.Interfaces;

namespace Phase_5_Design_Patterns.Week_5.FactoryMethod.ConcreteProducts
{
    public class RootCanalAppointment : IAppointment
    {
        public void Schedule(string patientName, string timeSlot) =>
            Console.WriteLine($"[Endodontic Surgery] Scheduled Root Canal Therapy for {patientName} at {timeSlot}.");
    }
}
```

##### File: `AppointmentFactory.cs`
```csharp
using Phase_5_Design_Patterns.Week_5.FactoryMethod.Interfaces;

namespace Phase_5_Design_Patterns.Week_5.FactoryMethod
{
    // ==========================================
    // 2. THE CREATOR BASE ABSTRACTION
    // ==========================================
    public abstract class AppointmentFactory
    {
        // Core orchestration method remains completely closed to structural modification
        public void ArrangeClinicSession(string patientName, string timeSlot)
        {
            // Deferring structural instantiation details to the derived child classes
            IAppointment appointment = CreateAppointment();
            appointment.Schedule(patientName, timeSlot);
        }

        // The polymorphic Factory Method (The official GoF pattern signature)
        protected abstract IAppointment CreateAppointment();
    }

    // ==========================================
    // 3. CONCRETE CREATORS (Subclasses altering product generation)
    // ==========================================
    public class CheckupAppointmentFactory : AppointmentFactory
    {
        // Don’t worry: the objects are still created via the new operator inside the factory method override
        protected override IAppointment CreateAppointment() => 
            new ConcreteProducts.CheckupAppointment();
    }

    public class OrthodonticAppointmentFactory : AppointmentFactory
    {
        protected override IAppointment CreateAppointment() => 
            new ConcreteProducts.OrthodonticAppointment();
    }

    public class RootCanalAppointmentFactory : AppointmentFactory
    {
        protected override IAppointment CreateAppointment() => 
            new ConcreteProducts.RootCanalAppointment();
    }
}
```

##### File: `FactoryMethodClient.cs`
```csharp
using System;

namespace Phase_5_Design_Patterns.Week_5.FactoryMethod
{
    // ==========================================
    // 4. DECOUPLED APPLICATION EXECUTION CLIENT
    // ==========================================
    public static class FactoryMethodClient
    {
        public static void Main()
        {
            // High-level runtime loops interact exclusively with the sender creator abstraction hierarchies
            AppointmentFactory clinicScheduler;

            Console.WriteLine("--- Initializing Clinic Scheduling Engine ---");

            // Scheduling via Checkup Factory
            clinicScheduler = new CheckupAppointmentFactory();
            clinicScheduler.ArrangeClinicSession("Alice Smith", "09:30 AM");

            // Scheduling via Orthodontic Factory
            clinicScheduler = new OrthodonticAppointmentFactory();
            clinicScheduler.ArrangeClinicSession("Bob Jones", "11:15 AM");

// Scheduling via Root Canal Factory (Integrated smoothly with zero core structural modifications)
clinicScheduler = new RootCanalAppointmentFactory();
clinicScheduler.ArrangeClinicSession("Charlie Green", "02:00 PM");
Console.ReadLine();
}
}
}
```

### Day 4: Abstract Factory Design Pattern

*   **Study Focus:** The Abstract Factory pattern creates an instance of several families of classes without explicitly detailing their concrete designations.
*   `cloud_mismatch_violation.cs` — **Cloud Environment Mismatch:** Directly instantiating mixed parts across separate cloud vendors, showing how mismatched infrastructure setups break provisioning pipelines at runtime.
*   `ICloudResourceFactory.cs` — **Unified Cloud Families:** Grouping related infrastructure interface sets (Compute Instances and Storage Buckets) into explicit factory contracts to guarantee total structural coordination.

---

#### 📌 Theoretical Blueprint

*   **Core Concept:** **Abstract Factory** is a creational design pattern that lets you produce families of related objects without specifying their concrete classes.
*   **The Problem:** Imagine you are building an automated DevOps infrastructure provisioning engine designed to support multiple cloud vendors: **Amazon Web Services (AWS)** and **Microsoft Azure**. Your orchestration system requires matching sets of structural computing products—a *Compute Instance Engine* and a corresponding *Object Storage Bucket* (e.g., AWS requires an `Ec2ComputeInstance` paired with an `S3StorageBucket`, while Azure requires a `VmComputeInstance` paired with a `BlobStorageBucket`). If your software allows open, unvalidated cross-instantiation, a developer could accidentally provision an Azure virtual machine but pass it an AWS S3 tracking bucket pointer. This creates a catastrophic cloud resource mismatch, breaking your live deployment pipelines at execution runtime.
*   **The Solution:** The Abstract Factory pattern addresses this by declaring a core structural factory interface containing individual creation contracts for each resource type in the cloud product family. Concrete factory classes are then written to encapsulate and enforce vendor-specific boundaries exclusively. Your application orchestrator handles configuration matrices by interacting strictly with these unified factory abstractions, ensuring total runtime system compatibility.

---

#### ❌ The Family Mismatch Violation Code (`cloud_mismatch_violation.cs`)
```csharp
using System;

namespace Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.AbstractFactory
{
    /// <summary>
    /// ANTI-PATTERN: Family Mismatch.
    /// Direct client instantiation lacks structural configuration boundaries. A developer 
    /// can accidentally pair an Azure Virtual Machine with an AWS S3 bucket, creating a broken resource stack.
    /// </summary>
    public class Cloud_Mismatch_Violation
    {
        public void ProvisionInfrastructureStack(string cloudProvider)
        {
            if (cloudProvider.Equals("AWS", StringComparison.OrdinalIgnoreCase))
            {
                var server = new Ec2ComputeInstance();
                var storage = new S3StorageBucket();
                
                server.Provision();
                storage.Allocate();
            }
            else if (cloudProvider.Equals("Azure", StringComparison.OrdinalIgnoreCase))
            {
                // ❌ Structural Risk: Accidentally mixing an AWS S3 structural storage bucket into an Azure compute environment setup
                var server = new VmComputeInstance();
                var storage = new S3StorageBucket(); // Family Mismatch!
                
                server.Provision();
                storage.Allocate();
            }
        }
    }

    public class Ec2ComputeInstance { public void Provision() => Console.WriteLine("Spinning up AWS EC2 instance."); }
    public class S3StorageBucket { public void Allocate() => Console.WriteLine("Creating AWS S3 storage bucket."); }
    public class VmComputeInstance { public void Provision() => Console.WriteLine("Spinning up Azure Virtual Machine."); }
    public class BlobStorageBucket { public void Allocate() => Console.WriteLine("Creating Azure Blob storage container."); }
}
```

---

####  The Unified Families Solution Code (Distributed Project Files)

##### File: `Interfaces/IComputeInstance.cs`
```csharp
namespace Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.AbstractFactory.Interfaces
{
    public interface IComputeInstance
    {
        void Provision();
    }
}
```

##### File: `Interfaces/IStorageBucket.cs`
```csharp
namespace Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.AbstractFactory.Interfaces
{
    public interface IStorageBucket
    {
        void Allocate();
    }
}
```

##### File: `ConcreteProducts/AwsResourceFamily.cs`
```csharp
using System;
using Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.AbstractFactory.Interfaces;

namespace Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.AbstractFactory.ConcreteProducts
{
    public class Ec2ComputeInstance : IComputeInstance
    {
        public void Provision() => Console.WriteLine("[Compute] AWS EC2 Elastic Compute Instance provisioned successfully.");
    }

    public class S3StorageBucket : IStorageBucket
    {
        public void Allocate() => Console.WriteLine("[Storage] AWS S3 Secure Object Storage Bucket allocated.");
    }
}
```

##### File: `ConcreteProducts/AzureResourceFamily.cs`
```csharp
using System;
using Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.AbstractFactory.Interfaces;

namespace Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.AbstractFactory.ConcreteProducts
{
    public class VmComputeInstance : IComputeInstance
    {
        public void Provision() => Console.WriteLine("[Compute] Azure Enterprise Virtual Machine scale set provisioned.");
    }

    public class BlobStorageBucket : IStorageBucket
    {
        public void Allocate() => Console.WriteLine("[Storage] Azure Blob Binary Object Storage Container allocated.");
    }
}
```

##### File: `Interfaces/ICloudResourceFactory.cs`
```csharp
namespace Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.AbstractFactory.Interfaces
{
    // ==========================================
    // THE ABSTRACT FACTORY CONTRACT (The Master Factory Standard)
    // ==========================================
    public interface ICloudResourceFactory
    {
        IComputeInstance CreateComputeInstance();
        IStorageBucket CreateStorageBucket();
    }
}
```

##### File: `ConcreteFactories/AwsResourceFactory.cs`
```csharp
using Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.AbstractFactory.Interfaces;
using Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.AbstractFactory.ConcreteProducts;

namespace Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.AbstractFactory.ConcreteFactories
{
    public class AwsResourceFactory : ICloudResourceFactory
    {
        public IComputeInstance CreateComputeInstance() => new Ec2ComputeInstance();
        public IStorageBucket CreateStorageBucket() => new S3StorageBucket();
    }
}
```

##### File: `ConcreteFactories/AzureResourceFactory.cs`
```csharp
using Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.AbstractFactory.Interfaces;
using Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.AbstractFactory.ConcreteProducts;

namespace Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.AbstractFactory.ConcreteFactories
{
    public class AzureResourceFactory : ICloudResourceFactory
    {
        public IComputeInstance CreateComputeInstance() => new VmComputeInstance();
        public IStorageBucket CreateStorageBucket() => new BlobStorageBucket();
    }
}
```

##### File: `CloudDeploymentOrchestrator.cs`
```csharp
using Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.AbstractFactory.Interfaces;

namespace Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.AbstractFactory
{
    public class CloudDeploymentOrchestrator
    {
        private readonly IComputeInstance _server;
        private readonly IStorageBucket _storage;

        // Client relies completely on abstract interface definitions, guaranteeing vendor environment safety
        public CloudDeploymentOrchestrator(ICloudResourceFactory cloudFactory)
        {
            _server = cloudFactory.CreateComputeInstance();
            _storage = cloudFactory.CreateStorageBucket();
        }

        public void DeployStack()
        {
            _server.Provision();
            _storage.Allocate();
        }
    }
}
```

##### File: `AbstractFactoryClient.cs`
```csharp
using System;
using Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.AbstractFactory.Interfaces;
using Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.AbstractFactory.ConcreteFactories;

namespace Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.AbstractFactory
{
    public static class AbstractFactoryClient
    {
        public static void Main(string[] args)
        {
            ICloudResourceFactory factory;
            CloudDeploymentOrchestrator orchestrator;

            Console.WriteLine("--- Initializing Automated Cloud Environment Provisioning Engine ---");

            // 1. Build and configure an AWS environment stack using its concrete vendor family factory
            Console.WriteLine("\n[Orchestration] Loading Amazon Web Services (AWS) Target Profiles:");
            factory = new AwsResourceFactory();
            orchestrator = new CloudDeploymentOrchestrator(factory);
            orchestrator.DeployStack();

            // 2. Build and configure an Azure environment stack using its concrete vendor family factory
Console.WriteLine("\n[Orchestration] Loading Microsoft Azure Target Profiles:");
factory = new AzureResourceFactory();
orchestrator = new CloudDeploymentOrchestrator(factory);
orchestrator.DeployStack();
Console.ReadLine();
}
}
}
```

### Day 5: Builder Design Pattern

*   **Study Focus:** Separating the construction mechanics of a complex object from its structural representation to handle highly configurable validation profiles cleanly.
*   `treatment_plan_violation.cs` — **Telescoping Constructor:** Attempting to build multi-parameter objects through overloaded constructor signatures, showing how rigid parameter lists reduce readability and break under fluid specifications.
*   `PatientTreatmentPlanBuilder.cs` — **Fluent Step-by-Step Assembly:** Re-engineering object initialization with type-safe, method-chaining rules to enforce structural validation constraints prior to product delivery.

---

#### 📌 Theoretical Blueprint

*   **Core Concept:** **Builder** is a creational design pattern that lets you construct complex objects step-by-step. The pattern allows you to produce different types and representations of an object using the same construction code.
*   **The Problem:** Imagine your medical workspace platform needs to compile custom `PatientTreatmentPlan` records. Each plan is heavily customized depending on the clinical workflow—some require immediate complex surgery codes, others need specific pharmaceutical prescriptions, custom follow-up appointment intervals, laboratory testing flags, or explicit healthcare coverage insurance approval keys. If you attempt to bundle all these varying operational tracks into a single monolithic class constructor, you end up with a giant list of optional, confusing parameters (`null, null, true, 0, null`). This anti-pattern—known as a **Telescoping Constructor**—degrades code readability, makes changes highly prone to structural errors, and lacks compilation-time safety controls.
*   **The Solution:** The Builder pattern suggests that you extract the object construction code out of its own class and move it to separate objects called builders. Don’t worry: the core object is still constructed via standard parameters, but the assembly execution is broken down into progressive, chainable method steps (`SetSurgery()`, `AddPrescription()`, `WithFollowUp()`). The main object remains completely locked behind immutable encapsulation bounds, while the builder engine validates the state configuration rules during runtime step phases, delivering a completely valid product reference only when the final `.Build()` command is invoked.

---

#### ❌ The Telescoping Constructor Violation Code (`treatment_plan_violation.cs`)
```csharp
using System;

namespace Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.Builder
{
    /// <summary>
    /// ANTI-PATTERN: Telescoping Constructor.
    /// Forcing object instantiation through rigid overloaded parameters. It is highly 
    /// unreadable, easily broken by passing positional fields out of order, and hard to extend.
    /// </summary>
    public class PatientTreatmentPlan
    {
        public string PatientId { get; }
        public string DiagnosisCode { get; }
        public string SurgeryType { get; }
        public string PrescriptionDrug { get; }
        public int FollowUpWeeks { get; }
        public bool RequiresLabWork { get; }

        // Core Telescoping Constructor Overloads
        public PatientTreatmentPlan(string patientId, string diagnosisCode) 
            : base()
        {
            PatientId = patientId;
            DiagnosisCode = diagnosisCode;
        }

        public PatientTreatmentPlan(string patientId, string diagnosisCode, string surgeryType) 
            : this(patientId, diagnosisCode)
        {
            SurgeryType = surgeryType;
        }

        public PatientTreatmentPlan(string patientId, string diagnosisCode, string surgeryType, string prescriptionDrug, int followUpWeeks, bool requiresLabWork) 
            : this(patientId, diagnosisCode, surgeryType)
        {
            PrescriptionDrug = prescriptionDrug;
            FollowUpWeeks = followUpWeeks;
            RequiresLabWork = requiresLabWork;
        }
    }

    public class LegacyClinicalApp
    {
        public void ExecuteLegacyWorkflow()
        {
            // ❌ Highly confusing assignment paradigm filled with positional parameter hazards and magic literals
            var plan = new PatientTreatmentPlan("PT-9012", "ICD-10-K04.0", null, "Amoxicillin 500mg", 2, true);
        }
    }
}
```

---

####  The Fluent Construction Solution Code (Distributed Project Files)

##### File: `Models/PatientTreatmentPlan.cs`
```csharp
using System;
using System.Collections.Generic;

namespace Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.Builder.Models
{
    // The target complex object containing read-only initialization states to maintain data safety
    public class PatientTreatmentPlan
    {
        public string PatientId { get; internal set; } = string.Empty;
        public string DiagnosisCode { get; internal set; } = string.Empty;
        public string SurgeryProcedure { get; internal set; } = "None";
        public List<string> PrescribedMedications { get; internal set; } = new List<string>();
        public int FollowUpIntervalWeeks { get; internal set; } = 0;
        public bool RequiresLaboratoryClearance { get; internal set; } = false;

        public void RenderClinicalSummary()
        {
            Console.WriteLine($"--- Clinical Profile: {PatientId} ---");
            Console.WriteLine($"Primary Diagnosis Code : {DiagnosisCode}");
            Console.WriteLine($"Surgical Procedures     : {SurgeryProcedure}");
            Console.WriteLine($"Medication Stack Count : {PrescribedMedications.Count}");
            if (PrescribedMedications.Count > 0)
                Console.WriteLine($"Active Prescriptions   : {string.Join(", ", PrescribedMedications)}");
            Console.WriteLine($"Follow-Up Milestone    : {FollowUpIntervalWeeks} Weeks");
            Console.WriteLine($"Lab Clearance Required : {RequiresLaboratoryClearance}");
            Console.WriteLine(new string('-', 35));
        }
    }
}
```

##### File: `Interfaces/ITreatmentPlanBuilder.cs`
```csharp
using Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.Builder.Models;

namespace Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.Builder.Interfaces
{
    // The contract defining the explicit sequential setup capabilities
    public interface ITreatmentPlanBuilder
    {
        ITreatmentPlanBuilder BeginPlan(string patientId, string diagnosisCode);
        ITreatmentPlanBuilder ScheduleSurgery(string procedureName);
        ITreatmentPlanBuilder AddPrescription(string medication);
        ITreatmentPlanBuilder SetFollowUpSchedule(int weeks);
        ITreatmentPlanBuilder RequireLabTesting(bool status);
        PatientTreatmentPlan Build();
    }
}
```

##### File: `Builders/PatientTreatmentPlanBuilder.cs`
```csharp
using System;
using System.Collections.Generic;
using Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.Builder.Interfaces;
using Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.Builder.Models;

namespace Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.Builder.Builders
{
    public class PatientTreatmentPlanBuilder : ITreatmentPlanBuilder
    {
        private PatientTreatmentPlan _plan = new PatientTreatmentPlan();

        public ITreatmentPlanBuilder BeginPlan(string patientId, string diagnosisCode)
        {
            if (string.IsNullOrWhiteSpace(patientId)) throw new ArgumentException("Patient ID parameters are mandatory.");
            if (string.IsNullOrWhiteSpace(diagnosisCode)) throw new ArgumentException("Diagnosis codes must be declared.");
            
            _plan.PatientId = patientId;
            _plan.DiagnosisCode = diagnosisCode;
            return this; // Returns the active instance reference to allow fluid method chaining
        }

        public ITreatmentPlanBuilder ScheduleSurgery(string procedureName)
        {
            _plan.SurgeryProcedure = procedureName;
            return this;
        }

        public ITreatmentPlanBuilder AddPrescription(string medication)
        {
            _plan.PrescribedMedications.Add(medication);
            return this;
        }

        public ITreatmentPlanBuilder SetFollowUpSchedule(int weeks)
        {
            if (weeks < 0 || weeks > 52) throw new ArgumentOutOfRangeException("Follow-up scheduling constraints bounded between 0 and 52 weeks.");
            _plan.FollowUpIntervalWeeks = weeks;
            return this;
        }

        public ITreatmentPlanBuilder RequireLabTesting(bool status)
        {
            _plan.RequiresLaboratoryClearance = status;
            return this;
        }

        public PatientTreatmentPlan Build()
        {
            // Business Invariant Validation: Guarantee the state representation is contractually sound
            if (string.IsNullOrEmpty(_plan.PatientId) || string.IsNullOrEmpty(_plan.DiagnosisCode))
            {
                throw new InvalidOperationException("Incomplete context allocation: Core identity profiles missing.");
            }

            // Deliver the fully constructed product reference
            PatientTreatmentPlan finalizedProduct = _plan;

            // Instantly reset the workspace reference state to clear channels for subsequent object requests
            _plan = new PatientTreatmentPlan();

            return finalizedProduct;
        }
    }
}
```

##### File: `BuilderPatternClient.cs`
```csharp
using System;
using Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.Builder.Interfaces;
using Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.Builder.Builders;
using Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.Builder.Models;

namespace Phase_5_Design_Patterns.Week_5_Creational_Design_Patterns.Builder
{
public static class BuilderPatternClient
{
public static void Main(string[] args)
{
ITreatmentPlanBuilder planBuilder = new PatientTreatmentPlanBuilder();
Console.WriteLine("--- Launching Hospital Fluent Treatment Plan Assembly Systems --- \n");
// Scenario A: Building a complex, multi-step surgical treatment plan
PatientTreatmentPlan surgicalPlan = planBuilder
.BeginPlan("PT-8801", "ICD-10-M21.6") // Orthopaedic deformity diagnosis
.ScheduleSurgery("Reconstructive Osteotomy Alignment")
.AddPrescription("Ketorolac 10mg (Analgesic)")
.AddPrescription("Cefazolin 1g (Prophylactic Antibiotic)")
.RequireLabTesting(true)
.SetFollowUpSchedule(6) // 6-week post-op recovery check
.Build();
surgicalPlan.RenderClinicalSummary();
// Scenario B: Assembling an alternative representation (stateless, prescription-only track)
// Notice how clean and self-documenting the workflow looks, using the exact same builder engine
PatientTreatmentPlan routinePlan = planBuilder
.BeginPlan("PT-1044", "ICD-10-J01.9") // Acute sinusitis
.AddPrescription("Fluticasone Nasal Spray")
.AddPrescription("Claritin 10mg")
.SetFollowUpSchedule(2)
.Build();
routinePlan.RenderClinicalSummary();
Console.ReadLine();
}
}
}
```

### Week-6 Structural Patterns: Adapter, Facade, and Decorator 

### Day 1: Adapter Design Pattern

*   **Study Focus:** Connecting incompatible interfaces using a wrapper class, ensuring structural flexibility and reusability without modifying legacy or third-party source code.
*   `adapter_naive.cs` — **Incompatible Systems:** Analyzing how a system crashes or fails to compile when trying to pass an incompatible third-party data structure directly into a legacy workflow.
*   `adapter_implemented.cs` — **Object Adapter Pattern:** Implementing a wrapper class that implements the target interface, translates data formats, and safely delegates tasks to the underlying service.

---

#### 📌 Theoretical Blueprint

*   **Core Concept:** **Adapter** is a structural design pattern that allows objects with incompatible interfaces to collaborate by acting as a translator between them.
*   **The Problem:** Imagine you're building an e-commerce platform that handles transactional workflows using a standard internal data format. You need to integrate a cutting-edge third-party analytics and payment SDK, but its methods require highly specific, nested parameters that don't match your system. Because you cannot modify the external vendor's compiled code, attempting to force it into your architecture results in massive breaking changes, redundant data mapping logic scattered across your application, and tightly coupled dependencies.
*   **The Solution:** The Adapter pattern suggests creating a dedicated wrapper class that implements your application's expected interface while holding a reference to the third-party object. When your application calls the adapter, it intercepts the request, translates the incoming arguments into the specific format required by the external SDK, and passes the execution along seamlessly. By centralizing this translation layer, your core application logic remains entirely unaware of the underlying compatibility issues.

---

#### ❌ The Incompatible (Naive) Adapter Code (`adapter_naive.cs`)
```csharp
using Phase_5_Design_Patterns.Week_6_Structural_Patterns.Adapter_Pattern.Adaptee;
using Phase_5_Design_Patterns.Week_6_Structural_Patterns.Adapter_Pattern.Domain;
using Phase_5_Design_Patterns.Week_6_Structural_Patterns.Adapter_Pattern.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_5_Design_Patterns.Week_6_Structural_Patterns.Adapter_Pattern
{
    public class adapter_naive
    {
        public static void RunSimulation()
        {
            Console.WriteLine("=== Executing Tightly Coupled Workflow ===");

            CheckoutProcessor platform = new CheckoutProcessor();
            AdvancedPaymentSDK externalSDK = new AdvancedPaymentSDK();

            TransactionRequest internalOrder = new TransactionRequest
            {
                OrderId = "ORD-99542",
                TotalAmount = 79.99m,
                Currency = Currency.USD
            };

            platform.ExecuteCheckout(internalOrder);

            // ❌ CRITICAL COMPILATION FAILURE:
            // Attempting to force the external SDK into our architecture directly fails.
            // Our platform provides a 'TransactionRequest'. The SDK demands a nested 'VendorPaymentPayload'.
            // Scattering manual mapping loops here would result in breaking changes across the app.
            
            // externalSDK.ProcessVendorTransaction(internalOrder); // <-- ERROR: Argument mismatch.

            Console.WriteLine("Compilation Error: Cannot pass internal data format into the SDK's nested parameter signature.\n");
        }
    }
}
```

####  The Structural Decoupled Pattern Solution Code (`adapter_implemented.cs`)
```csharp
using Phase_5_Design_Patterns.Week_6_Structural_Patterns.Adapter_Pattern.Adaptee;
using Phase_5_Design_Patterns.Week_6_Structural_Patterns.Adapter_Pattern.Adapter;
using Phase_5_Design_Patterns.Week_6_Structural_Patterns.Adapter_Pattern.Enums;
using Phase_5_Design_Patterns.Week_6_Structural_Patterns.Adapter_Pattern.Interfaces;
using Phase_5_Design_Patterns.Week_6_Structural_Patterns.Adapter_Pattern.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_5_Design_Patterns.Week_6_Structural_Patterns.Adapter_Pattern
{
    public class RunSimulation
    {
        public static void Main(string[] args)
        {
            // Execute the Naive/Coupled demonstration
            adapter_naive.RunSimulation();

            Console.WriteLine("=== Executing Decoupled Adapter Pattern Workflow ===");

            // 1. Create the incompatible SDK object (Adaptee)
            AdvancedPaymentSDK thirdPartySDK = new AdvancedPaymentSDK();

            // 2. Encapsulate it inside the translator layer (Adapter)
            IPaymentGatewayTarget adapterLayer = new PaymentSDKAdapter(thirdPartySDK);

            // 3. Inject the adapter directly into our platform workflow engine (Client)
            CheckoutProcessor platform = new CheckoutProcessor(adapterLayer);

            // 4. Prepare data using standard internal domain formats
            TransactionRequest standardOrder = new TransactionRequest
            {
                OrderId = "ORD-99542",
                TotalAmount = 79.99m,
                Currency = Currency.USD
            };

            // SUCCESS: Runs cleanly without modifying the third-party SDK or messy inline conversions!
            platform.ExecuteCheckout(standardOrder);
        }
    }
}
```
### Day 2: Facade Design Pattern

*   **Study Focus:** Providing a simplified, unified high-level interface to a complex subsystem of banking, credit rating, and loan histories, minimizing direct orchestration dependencies from client apps.
*   `facade_naive.cs` — **Tightly Coupled Subsystems:** Analyzing the complex, manual orchestration required when a client application manually spins up and coordinates independent bank verification steps.
*   `facade_implemented.cs` — **Unified Facade Pattern:** Implementing a centralized mortgage underwriting boundary class that encapsulates the verification engine behind an intuitive entry point.

---

#### 📌 Theoretical Blueprint

*   **The Problem:** Imagine you are implementing a mortgage verification workflow for a retail banking platform. To evaluate a single loan applicant, your client application logic must manually coordinate three independent downstream subsystems: querying bank ledgers for healthy savings (`Bank`), pinging credit bureaus for historical credit quality scores (`Credit`), and scanning active debt profiles for any un-cleared default records (`Loan`). 
    
    Forcing your client-side mobile UI or front-end branch controllers to manually instantiate these three services and execute nested conditionals creates distinct problems:
    1. **Code Duplication:** Every page or branch console that processes a loan must copy-paste the exact same sequence of service calls.
    2. **Tight Coupling:** Your client code leaks specific parameters (e.g., passing a numerical dollar value to the bank check vs passing the raw customer object to the credit bureau check).
    3. **Rigid Architecture:** If a regulatory framework requires an additional anti-money laundering (AML) check tomorrow, or if one of the subsystem class method signatures modifies its name, it will trigger an immediate, breaking compilation failure across your entire enterprise system application wherever the pipeline was copy-pasted.

*   **The Solution:** The Facade pattern resolves this fragmentation by introducing a single, high-level gateway class (`Mortgage`). Instead of exposing the granular mechanics of the underlying financial subsystems to the caller, the subsystems are safely encapsulated behind a private wall inside the Facade class. 
    
    The client software interacts exclusively with a single, highly readable entry method: `IsEligible(Customer, int)`. When invoked, the Facade intercepts this single payload, establishes the internal sequence rules, handles the data translations dynamically behind the scenes, and safely returns a clean boolean outcome directly to the consumer app—keeping your client layers completely isolated from internal data-structure complexities.

---

## 📂 Directory: `Domain/`

### 📄 `Customer.cs`
```csharp
using System;

namespace Phase_5_Design_Patterns.Week_6_Structural_Patterns.Facade_Pattern.Domain
{
    public class Customer
    {
        public string Name { get; }

        public Customer(string name)
        {
            Name = name;
        }
    }
}
```

---

## 📂 Directory: `Subsystems/`

### 📄 `Bank.cs`
```csharp
using Phase_5_Design_Patterns.Week_6_Structural_Patterns.Facade_Pattern.Domain;
using System;

namespace Phase_5_Design_Patterns.Week_6_Structural_Patterns.Facade_Pattern.Subsystems
{
    public class Bank
    {
        public bool HasSufficientSavings(Customer customer, int amount)
        {
            Console.WriteLine($"[Bank Subsystem] Checking asset holdings for {customer.Name}");
            return true;
        }
    }
}
```

### 📄 `Credit.cs`
```csharp
using Phase_5_Design_Patterns.Week_6_Structural_Patterns.Facade_Pattern.Domain;
using System;

namespace Phase_5_Design_Patterns.Week_6_Structural_Patterns.Facade_Pattern.Subsystems
{
    public class Credit
    {
        public bool HasGoodCredit(Customer customer)
        {
            Console.WriteLine($"[Credit Bureau] Fetching historical credit status for {customer.Name}");
            return true;
        }
    }
}
```

### 📄 `Loan.cs`
```csharp
using Phase_5_Design_Patterns.Week_6_Structural_Patterns.Facade_Pattern.Domain;
using System;

namespace Phase_5_Design_Patterns.Week_6_Structural_Patterns.Facade_Pattern.Subsystems
{
    public class Loan
    {
        public bool HasNoBadLoans(Customer customer)
        {
            Console.WriteLine($"[Lending Registry] Scanning debt histories for {customer.Name}");
            return true;
        }
    }
}
```

---

## 📂 Root Directory: `Facade_Pattern/`

### 📄 `Mortgage.cs` *(The Facade Subsystem Coordinator)*
```csharp
using Phase_5_Design_Patterns.Week_6_Structural_Patterns.Facade_Pattern.Domain;
using Phase_5_Design_Patterns.Week_6_Structural_Patterns.Facade_Pattern.Subsystems;
using System;

namespace Phase_5_Design_Patterns.Week_6_Structural_Patterns.Facade_Pattern
{
    public class Mortgage
    {
        // Subsystem instances are encapsulated internally away from the client caller
        private readonly Bank _bank = new Bank();
        private readonly Loan _loan = new Loan();
        private readonly Credit _credit = new Credit();

        /// <summary>
        /// Extends a single, simplified method entry point to the application client.
        /// Encapsulates structural dependencies and handles internal sequence checks.
        /// </summary>
        public bool IsEligible(Customer cust, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan through the Facade System\n", cust.Name, amount);

            // The complex validation pipeline runs safely behind the facade boundary wall
            if (!_bank.HasSufficientSavings(cust, amount))
            {
                return false;
            }
            
            if (!_loan.HasNoBadLoans(cust))
            {
                return false;
            }
            
            if (!_credit.HasGoodCredit(cust))
            {
                return false;
            }

            return true;
        }
    }
}
```

### 📄 `facade_naive.cs` *(The Tightly Coupled Code)*
```csharp
using Phase_5_Design_Patterns.Week_6_Structural_Patterns.Facade_Pattern.Domain;
using Phase_5_Design_Patterns.Week_6_Structural_Patterns.Facade_Pattern.Subsystems;
using System;

namespace Phase_5_Design_Patterns.Week_6_Structural_Patterns.Facade_Pattern
{
    public class facade_naive
    {
        public static void RunSimulation()
        {
            Console.WriteLine("=== Executing Fragmented/Coupled Subsystem Workflow ===");

            // ❌ Client must manually instantiate every distinct subsystem component dependency
            Bank bankSubsystem = new Bank();
            Loan loanSubsystem = new Loan();
            Credit creditSubsystem = new Credit();

            Customer applicant = new Customer("Ann McKinsey");
            int requestedLoanAmount = 125000;

            Console.WriteLine($"{applicant.Name} applies for {requestedLoanAmount:C} loan manually via subsystems...\n");

            bool isEligible = true;

            // ❌ Client manually choreographs the step-by-step nested validation sequence.
            // If any of these method names change tomorrow, this code breaks immediately.
            if (!bankSubsystem.HasSufficientSavings(applicant, requestedLoanAmount))
            {
                isEligible = false;
            }
            else if (!loanSubsystem.HasNoBadLoans(applicant))
            {
                isEligible = false;
            }
            else if (!creditSubsystem.HasGoodCredit(applicant))
            {
                isEligible = false;
            }

            Console.WriteLine($"\n[Naive Client] Result: {applicant.Name} has been " + (isEligible ? "Approved" : "Rejected"));
            Console.WriteLine();
        }
    }
}
```

### 📄 `FacadeClient.cs` *(The Consolidated Entry Point)*
```csharp
using Phase_5_Design_Patterns.Week_6_Structural_Patterns.Facade_Pattern.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Phase_5_Design_Patterns.Week_6_Structural_Patterns.Facade_Pattern
{
    public class FacadeClient
    {
        public static void Main(string[] args)
        {
            // First run the naive code simulation to document the problem explicitly
            facade_naive.RunSimulation();

            Console.WriteLine("=== Executing Simplified Facade Pattern Workflow ===");

            // Instantiating the high-level Facade gateway wrapper
            Mortgage mortgage = new Mortgage();
            
            // Initializing domain entity
            Customer customer = new Customer("Ann McKinsey");
            
            // Complex validations occur implicitly behind this single gateway abstraction layer
            bool eligible = mortgage.IsEligible(customer, 125000);

            Console.WriteLine("\n" + customer.Name + " has been " + (eligible ? "Approved" : "Rejected"));

            Console.WriteLine("\nPress any key to finalize simulation...");
            Console.ReadKey();
        }
    }
}
```

### Day 3: Decorator Design Pattern

*   **Study Focus:** Dynamically adding new responsibilities and behaviors to individual objects at runtime without altering the structural blueprint of the underlying class definitions.
*   `decorator_naive.cs` — **Rigid Hierarchies:** Exploring the architectural limitations of using classical class inheritance pipelines to introduce optional functionalities, resulting in combinational class explosions.
*   `decorator_implemented.cs` — **Dynamic Decorator Pattern:** Implementing an encapsulation wrapper structure that aggregates a base abstract component type, enabling dynamic, onion-layered behavior additions.

---

#### 📌 Theoretical Blueprint

*   **The Problem:** Imagine you are architecting a digital inventory management workflow system for an enterprise library network handling resource allocations (`LibraryItem`). Initially, the platform processes basic assets such as tangible publications (`Book`) and multimedia media (`Video`). As system requirements evolve, the operation introduces transactional operations like allowing users to rent physical assets (`Borrowable`). 
    
    If you attempt to use standard classical object inheritance to support these dynamic feature updates, you hit clear limitations:
    1. **Combinational Class Explosion:** If you inherit a `BorrowableBook` and `BorrowableVideo` directly, adding another option down the road—such as `Reservable` or `InternationalShippingEligible`—forces you to build dozens of subclass permutations like `BorrowableReservableInternationalBook`.
    2. **Static Architecture Assignment:** Inheritance fixes a class instance's functional properties at compile-time. An item cannot dynamically gain or lose features as its state shifts inside your live application memory layers.
    3. **Leaky Base Abstractions:** Attempting to hardcode conditional behavior states (e.g., adding collection track lists directly into the `LibraryItem` root abstract definition) pollutes your structural architecture with features that clean components like a simple book do not care about.

*   **The Solution:** The Decorator design pattern resolves this class proliferation by choosing composition over inheritance. You establish a common abstract interface or base class contract (`LibraryItem`) that both core items and decoration layers implement. You then construct an abstract wrapper layer (`Decorator`) that references the core interface component internally.
    
    By inheriting this common class blueprint, the decorator matches the type signature of the item it targets. When the consumer application executes an operation, the decorator wraps the logic, executes its custom dynamic feature enhancements (such as tracking an array list of customer strings or decreasing physical copy numbers), and passes execution down to the underlying object. This enables you to dynamically wrap any asset in an endless layer of modifications at runtime without breaking your application structural classes.

---

## 📂 Directory: `Domain/`

### 📄 `LibraryItem.cs`
```csharp
using System;

namespace Phase_5_Design_Patterns.Week_6_Structural_Patterns.Decorator_Pattern.Domain
{
    public abstract class LibraryItem
    {
        private int _numCopies;

        public int NumCopies
        {
            get => _numCopies;
            set => _numCopies = value;
        }

        public abstract void Display();
    }
}
```

### 📄 `Book.cs`
```csharp
using Phase_5_Design_Patterns.Week_6_Structural_Patterns.Decorator_Pattern.Domain;
using System;

namespace Phase_5_Design_Patterns.Week_6_Structural_Patterns.Decorator_Pattern.Domain
{
    public class Book : LibraryItem
    {
        private readonly string _author;
        private readonly string _title;

        public Book(string author, string title, int numCopies)
        {
            _author = author;
            _title = title;
            NumCopies = numCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\nBook ------ ");
            Console.WriteLine($" Author: {_author}");
            Console.WriteLine($" Title: {_title}");
            Console.WriteLine($" # Copies: {NumCopies}");
        }
    }
}
```

### 📄 `Video.cs`
```csharp
using Phase_5_Design_Patterns.Week_6_Structural_Patterns.Decorator_Pattern.Domain;
using System;

namespace Phase_5_Design_Patterns.Week_6_Structural_Patterns.Decorator_Pattern.Domain
{
    public class Video : LibraryItem
    {
        private readonly string _director;
        private readonly string _title;
        private readonly int _playTime;

        public Video(string director, string title, int numCopies, int playTime)
        {
            _director = director;
            _title = title;
            NumCopies = numCopies;
            _playTime = playTime;
        }

        public override void Display()
        {
            Console.WriteLine("\nVideo ----- ");
            Console.WriteLine(\$" Director: {_director}");
            Console.WriteLine(\$" Title: {_title}");
            Console.WriteLine(\$" # Copies: {NumCopies}");
            Console.WriteLine(\$" Playtime: {_playTime}\n");
        }
    }
}
```
## 📂 Directory: `Decorators/`

### 📄 `AssetDecorator.cs`
```csharp
using Phase_5_Design_Patterns.Week_6_Structural_Patterns.Decorator_Pattern.Domain;
using System;

namespace Phase_5_Design_Patterns.Week_6_Structural_Patterns.Decorator_Pattern.Decorators
{
    public abstract class AssetDecorator : LibraryItem
    {
        protected readonly LibraryItem _libraryItem;

        protected AssetDecorator(LibraryItem libraryItem)
        {
            _libraryItem = libraryItem ?? throw new ArgumentNullException(nameof(libraryItem));
        }

        public override void Display()
        {
            _libraryItem.Display();
        }
    }
}
```

### 📄 `Borrowable.cs`
```csharp
using Phase_5_Design_Patterns.Week_6_Structural_Patterns.Decorator_Pattern.Domain;
using System;
using System.Collections.Generic;

namespace Phase_5_Design_Patterns.Week_6_Structural_Patterns.Decorator_Pattern.Decorators
{
    public class Borrowable : AssetDecorator
    {
        protected readonly List<string> _borrowers = new List<string>();

        public Borrowable(LibraryItem libraryItem) : base(libraryItem)
        {
        }

        public void BorrowItem(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Borrower name cannot be empty.", nameof(name));
            
            _borrowers.Add(name);
            _libraryItem.NumCopies--;
        }

        public void ReturnItem(string name)
        {
            if (_borrowers.Contains(name))
            {
                _borrowers.Remove(name);
                _libraryItem.NumCopies++;
            }
        }

        public override void Display()
        {
            base.Display();

            foreach (string borrower in _borrowers)
            {
                Console.WriteLine($" borrower: {borrower}");
            }
        }
    }
}
```

---

## 📂 Root Directory: `Decorator_Pattern/`

### 📄 `decorator_naive.cs`
```csharp
using System;

namespace Phase_5_Design_Patterns.Week_6_Structural_Patterns.Decorator_Pattern
{
    public class decorator_naive
    {
        // ❌ THE INHERITANCE ANTI-PATTERN DESCRIPTION:
        // Demonstrating structural fragility. To build a borrowable video without a decorator,
        // we are forced to explicitly sub-class a concrete item layout type at compilation runtime level.
        public class BorrowableVideoLegacyOutOfNecessity
        {
            // Forcing hardcoded structural duplication of fields and behaviors
            public void BorrowLegacyAsset()
            {
                Console.WriteLine("[Anti-Pattern Inheritance Check] Explicitly tied down to hardcoded Video hierarchies.");
            }
        }

        public static void RunSimulation()
        {
            Console.WriteLine("=== Executing Rigid Subclass Anti-Pattern Inspection ===");
            var concreteHardcodedAsset = new BorrowableVideoLegacyOutOfNecessity();
            concreteHardcodedAsset.BorrowLegacyAsset();
            Console.WriteLine("Inflexible Hierarchy Limitation: Adding a new option requires editing the core code stack.\n");
        }
    }
}
```

### 📄 `decorator_implemented.cs`
```csharp
using Phase_5_Design_Patterns.Week_6_Structural_Patterns.Decorator_Pattern.Domain;
using Phase_5_Design_Patterns.Week_6_Structural_Patterns.Decorator_Pattern.Decorators;
using System;

namespace Phase_5_Design_Patterns.Week_6_Structural_Patterns.Decorator_Pattern
{
    public class decorator_implemented
    {
        public static void RunSimulation()
        {
            Console.WriteLine("=== Executing Decoupled Dynamic Decorator Pattern Workflow ===");

            // 1. Instantiating core components with basic behaviors
            LibraryItem book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();

            LibraryItem video = new Video("Spielberg", "Jaws", 23, 92);
            video.Display();

            // 2. Dynamically assigning runtime capabilities using structural composition
            Console.WriteLine("\nMaking video borrowable dynamically via Decorator wrapper injection:");

            Borrowable borrowableVideo = new Borrowable(video);
            borrowableVideo.BorrowItem("Customer #1");
            borrowableVideo.BorrowItem("Customer #2");

            // 3. Executing decorated behavior wrappers cleanly
            borrowableVideo.Display();
            Console.WriteLine();
        }
    }
}
```

### 📄 `DecoratorClient.cs`
```csharp
using System;

namespace Phase_5_Design_Patterns.Week_6_Structural_Patterns.Decorator_Pattern
{
    public class DecoratorClient
    {
        public static void Main(string[] args)
        {
            // Execute structural anti-pattern description check
            decorator_naive.RunSimulation();

            // Execute target solution pattern runtime
            decorator_implemented.RunSimulation();

            Console.WriteLine("Press any key to finalize simulation...");
            Console.ReadKey();
        }
    }
}
```
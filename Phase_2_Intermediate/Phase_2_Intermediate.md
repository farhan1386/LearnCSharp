# ############# Phase 2: Intermediate C# Programming #############

## 📁 Phase_2_Intermediate / Week-1: Object-Oriented Programming (OOP) Core

This roadmap serves as a comprehensive reference guide for core Object-Oriented Programming principles in C#. 
Every topic is mapped day-by-day to a structured schedule of exactly two files per day.

---

### Day 1: Classes, Objects & Constructors
In Object-Oriented Programming, classes and objects are fundamental concepts used to represent real-world concepts and entities.

*   **Class:** A class is a blueprint used to create objects with similar properties and behaviors.
*   **Object:** An object is an instance of a class.   
   
*   **Constructors:** 
    A constructor in C# is a special method of a class that is automatically called when an object of the 
    class is created. It has the same name as the class, does not have a return type, and is mainly used to 
    initialize the object's data members.
    
*   **Constructor Overloading:** A class can define multiple constructors with different parameter signatures.
*   **Constraints:** A constructor cannot be virtual or abstract. Only a special kind of constructor can be static.

    #### Types of Constructors:

    1.  **Default Constructor:** A constructor that takes no arguments. If you do not provide one, 
        the C# compiler automatically creates a default constructor that initializes data members to their 
        standard default values.

    2.  **Parameterized Constructor:** A constructor that has at least one parameter. It allows you to pass 
        custom values into the object's data fields immediately upon creation.
  
    3.  **Copy Constructor:** A constructor that initializes a new object instance using the data members of 
        an existing object of the same class.
  
    4.  **Private Constructor:** A constructor marked with the `private` access modifier. 
        It prevents external classes from instantiating the class directly (commonly used in Singleton patterns 
        or static-only utility classes).

    5.  **Static Constructor:** A special class-level constructor used to initialize static fields or 
        perform actions that only need to happen once. It is called automatically before the 
        first instance is created or any static members are referenced.

### Day 2: Access Modifiers & Properties
Encapsulation isolates data implementation details to protect objects from unintended external interference.

*   **Access Modifiers:** Keywords that establish visibility and accessibility boundary rules across code 
      files and compiled assemblies.
    
    *   **public:** Exposed with zero restrictions; accessible by any external class, assembly, or project.
    *   **private:** Completely restricted; visible and modifiable only within the boundaries of the 
                   declaring class.
    *   **protected:** Accessible within the declaring class and safely inherited by any derived child classes.
    *   **internal:** Accessible only by classes compiled inside the exact same assembly project.
    *   **protected internal:** Accessible anywhere within the same assembly project, AND also by any derived 
                             child classes located in external assemblies.
    *   **private protected:** Accessible strictly within the declaring class and by derived child classes, 
                            provided they are compiled inside the same assembly project.

*   **Properties (Encapsulation):** Clean language wrappers that shield private field data from direct 
      mutation while exposing them safely using getters and setters.
    
    *   *Getters (`get`):* A block containing logic executed when the property is read, allowing values to 
         be formatted before they leave the object.
    *   *Setters (`set`):* A block containing validation checks executed when data is written, 
         preventing corrupt data states from being saved into private fields.

### Day 3: Abstraction & Encapsulation
Understanding data hiding and exposed surface area optimization concepts.

*   **(Encapsulation) Data Hiding:** Restricting immediate operational sight lines into internal fields, 
    ensuring that objects remain sovereign entities over their internal components.

*   **Abstraction:** The strategic pattern of hiding unnecessary background implementation complexities 
    from the user and only exposing simple, essential functionality features.


### Day 4: Inheritance & Polymorphism Foundations
Building clean parent-child relationships and preparing dynamic architectures.

*   **Inheritance:** A mechanism where a child class acquires the fields, properties, and methods of 
    a parent class using the `:` declaration syntax. This promotes code reuse and allows the child to 
    invoke parent setups using the `base()` keyword.

*   **Polymorphism Foundations:** Setting up structural entry-level architectures that allow diverse 
    objects to be treated uniformly as instances of their shared common parent base class.


### Day 5: Method Overriding & Method Overloading
Polymorphism allows objects to exhibit multiple structural shapes, extending runtime scalability.

*   **Method Overloading (Compile-Time Polymorphism):** The practice of creating multiple methods within 
    the same class that share an identical name but have unique parameter signatures (different counts, types, 
    or ordering). The compiler determines exactly which method to map at compilation time based on 
    the arguments supplied.

*   **Method Overriding (Runtime Polymorphism):** A mechanism where a child class completely replaces or 
    extends the behavioral logic of a parent class method. The parent method must be marked with 
    the `virtual` keyword, and the child must explicitly declare the `override` keyword. 
    The runtime decides which method to run based on the actual object type, not the reference variable type.


### Day 6: Abstract Classes & Interfaces
Enforcing functional rules and strict architectural structural blueprints.

*   **Abstract Classes:** Incomplete architectural templates declared with the `abstract` keyword. 
    They can house both fully implemented methods and unimplemented abstract method placeholders. 
    Abstract classes cannot be instantiated using `new` and exist solely to enforce a strict base design 
    that child classes must inherit and complete.

*   **Interfaces & Explicit Binding:** Pure functional contracts defined with the `interface` keyword 
    that decouple *what* a system should do from *how* it does it. Includes explicit implementation 
    to cleanly resolve name collisions if a class inherits duplicate signatures from separate interface 
    contracts.

### Day 7: Structures, Enums
Comparing memory performance spaces and synthesizing core OOP modules.

*   **Value Types & Constant Labels:**
  
    *   **Structs:** Lightweight value-type structures allocated on the fast Stack memory partition where assignment copies raw data values directly.
    *   **Enums:** Strongly-typed named integer constant blocks that replace arbitrary magic numbers or loose strings.

*   **Static Global Configurations & OOP Project Challenge:** 
    
    *   **Static Members:** Using fields and methods tied directly to the class definition instead of 
        individual object instances.
    *   **Consolidation Challenge:** A complete polymorphic console system putting all your Week-1 
        structural architecture tools together.


## 📁 Phase_2_Intermediate / Week-2: Collections, Error Interruption, & LINQ

This roadmap serves as a comprehensive reference guide for modern collection pipelines, defensive safety operations, 
and data querying syntax. Every topic is mapped day-by-day to a structured schedule of exactly two files per day.

### Day 1: Memory Optimization & Null Safety
Writing efficient string mutations and building bulletproof defenses against runtime application crashes.

*   **StringBuilder (Memory Tuning):**
    
    *   **String Immutability Pitfall:** Standard strings are immutable. Every modification (like concatenation in a loop) discards the old string and allocates a brand-new object on the Heap, generating massive Garbage Collector overhead.
    *   **StringBuilder Utility:** A mutable sequence of characters that modifies an internal expandable memory buffer directly in place without throwing away old instances, radically expanding application speed during heavy text processing.

*   **Null Safety Infrastructure:**
    
    *   **Nullable Types (`T?`):** Allows primitive value data types (like `int` or `bool`) to explicitly contain a `null` unassigned state indicator.
    *   **Null-Conditional Operator (`?.`):** Halts an operation and returns null immediately if the targeted object instance is null, safely protecting the application against fatal `NullReferenceException` breaks.
    *   **Null-Coalescing Operator (`??`):** Evaluates an expression and instantly provides a designated default fallback option if the tested variable yields a null reference.


### Day 2: Dynamic Data Structures & Fast Lookups
Moving past primitive single-dimension fixed arrays to capture fluid, responsive data streams.

*   **Dynamic Arrays (`List<T>`):**
    
    *   **List Operations:** A strongly-typed, auto-resizing sequential data container wrapper. It automatically allocates contiguous memory cells behind the scenes and expands its indexing footprint smoothly as structural elements are added, inserted, or removed.

*   **Key-Value Hashes (`Dictionary<TKey, TValue>`):**
    
    *   **Dictionary Operations:** A collection designed around highly optimized unique key-to-value pairs. It uses internal hashing algorithms to perform near-instantaneous O(1) lookups, updates, and deletes, completely bypassing the need for slow linear sorting and traversal loops.


### Day 3: Linear Pipelines & Type Reusability
Architecting specialized processing lanes and type-independent structural components.

*   **Linear Processing Streams:**
    
    *   **Queue (`Queue<T>`):** A linear container that enforces **FIFO** (First-In, First-Out) operations. Items are added at the tail (`Enqueue`) and extracted from the front (`Dequeue`), making it ideal for message routing and task execution engines.
    *   **Stack (`Stack<T>`):** A linear container that enforces **LIFO** (Last-In, First-Out) operations. Elements are pushed onto the top (`Push`) and popped off (`Pop`), managing recursive paths and undo buffer systems.

*   **Generic Architecture (`<T>`):**
    
    *   **Generics Utility:** A powerful feature that allows classes, methods, and structures to be engineered with an abstract type parameter placeholder (`T`). This allows the exact same algorithm to operate securely across multiple distinct data classes while maintaining strict runtime compile-time type checking, entirely avoiding performance-draining boxing operations.

### Day 4: Defensive Error Handling & Custom Flags
Capturing structural runtime failures gracefully to protect operational availability.

*   **Exception Lifecycle Management:**
    
    *   `try`: Isolates a section of code that runs an active hazard risk of throwing an exception (e.g., parsing user data, loading external files).
    *   `catch`: Intercepts specific, targeted exception types to clean up the problem, log diagnostic reports, and prevent the operating thread from crashing out hard.
    *   `finally`: A guaranteed execution context block that will run *unconditionally*, whether an exception occurred or not, to cleanly release file handles, database connections, and resources.

*   **Custom Application Flags:**
    
    *   **Custom Exception Utility:** Creating explicit specialized error classes by inheriting directly from the base `System.Exception` framework class. This allows software engineers to build targeted validation flags tailored specifically to unique domain business rule compliance breaches.


### Day 5: Function Pointers & Anonymous Inline Logic
Embracing functional programming components to write highly dynamic, adaptable logic links.

*   **Type-Safe Function Pointers:**
    
    *   **Delegates Utility:** A delegate defines a concrete method signature shape (return type and parameters). It allows methods to be encapsulated cleanly into variables and passed into other subroutines as highly flexible execution arguments.

*   **Anonymous Inline Logic:**
    
    *   **Lambda Utility:** Inline, nameless functional declarations written cleanly using the context lambda arrow mapping operator (`=>`). They compress code blocks by allowing small logic scripts to be written directly inside execution arguments without forcing the developer to compile entirely separate methods.


### Day 6: Collection Data Querying (LINQ)
Using Language Integrated Query syntax to manipulate collections cleanly without raw looping overhead.

*   **Fluent Functional Syntax:**
    
    *   **Method Syntax Utility:** Querying memory data containers cleanly by chaining together functional extension methods loaded with lambdas (e.g., using `.Where()` to filter parameters, `.OrderBy()` to sequence, and `.Select()` to isolate targeted columns).

*   **Declarative Query Syntax:**
    
    *   **Query Syntax Utility:** Transforming collection streams using readable, declarative SQL-like structural statement blocks seamlessly embedded natively right inside standard C# code syntax (e.g., `from item in collection where item.Value > 100 select item.Name`).


### Day 7: Enterprise Integration & Architecture Review
Fusing all data pipelines together into a secure, cohesive product framework.

*   **Advanced Production Capstone:**
    
    *   **Synthesis App:** Constructing a complete, end-to-end intermediate dashboard that unifies encapsulated class records, populates generic lookup dictionaries, protects parameters using custom validation exception blocks, and parses output listings via fluent LINQ expressions.

*   **Architectural Cleanup Audit:**
    
    *   **Refactoring Benchmarks:** Analyzing your components against real-world .NET enterprise design patterns, cleaning up nesting depths, stripping out messy iterations, checking memory references, and ensuring it satisfies standard clean architecture code requirements.

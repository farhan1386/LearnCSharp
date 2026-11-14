Phase 1: Basics of C# Programming

This master documentation serves as your comprehensive reference guide for foundational C# development.

## 📁 Phase_1_Basics / Week-1: Variable, Data Types, Operators, Decision Making, & Loops

### Day 1: Variables & Data Types

*   **Variable**: A variable in C# is a named memory location used to store data during program execution. The stored value can be accessed, modified, and reused throughout the program.
    
    Each variable consists of three components:
    *   **Name**: Identifier used to reference the variable.
    *   **Type**: Specifies the type of data the variable can store (e.g., int, char, double).
    *   **Value**: The actual data stored in the variable.

*   **Data Type**: Data types specify the type of data that a variable can store. Whenever a variable is declared in C#, the compiler allocates memory based on the data type.

    **Types of Data Types in C#**

      **1. Value Data Types**

       Value Data Type store the actual value directly in memory. The value is stored in the variable itself, so each variable has its own copy of the data. Changes made to one variable do not affect another variable.

       *   **int**: Stores integer (whole number) values. Range: -2³¹ to 2³¹ - 1.
       *   **float**: Stores single-precision decimal numbers. Requires the suffix `f` or `F` during initialization. Optimized for lower memory profiles.
       *   **double**: Stores high-precision decimal numbers. Default type for fractional values in C#.
       *   **char**: Stores a single Unicode character enclosed in single quotes (`' '`). Occupies 2 bytes in memory.
       *   **bool**: Stores logical values (`true` or `false`). Drives conditional control structures.

      **2. Reference Data Types**

       Reference Data Types store the reference (memory address) of the data instead of the actual value. Multiple variables can refer to the same data in memory. Any changes made through one variable will affect the other variables referring to the same object.

       *   **string**: Stores an immutable sequence of characters (text). Reassigning changes the reference address, not the value in place.
       *   **object**: The base type of all C# objects. Can store values of any type via boxing/unboxing conversions.
       *   **Array**: A collection of elements of the same data type, stored in contiguous memory locations. Arrays can be single-dimensional or multi-dimensional.

       **3. Pointer Data Type**
        
       These store the memory address of variables instead of actual values. They are mainly used in advanced scenarios such as low-level memory manipulation.
        
       *   **Syntax instance:** `pointer (int* p)` — Used to store the memory address of a variable.


### Day 2: Arithmetic Operators & Relational Operators

*   **Operators**:Operators are special symbols that take one or more operands to perform calculation profiles and output a structural result.

*   **Types of Operators in C#**

*   **1.Arithmetic Operators**

     Arithmetic operators are used to perform basic mathematical operations on numeric values.

       *   **Addition (`+`)**: Computes the sum of two numerical values. When applied to string parameters, it acts as a concatenation operator.
       *   **Subtraction (`-`)**: Computes the difference between the first value and the second value.
       *   **Multiplication (`*`)**: Multiplies two numerical values together.
       *   **Division (`/`)**: Divides the first numerical value by the second value. *Note: Integer division truncates the remainder; floating-point division preserves decimal accuracy.*
       *   **Modulus (`%`)**: Performs division between two values and returns exclusively the remaining calculated fractional integer balance (remainder).
    
*   **2. Relational Operators**

    Relational operators are used to compare values. The resulting output is returned as a strict boolean data classification, yielding either `true` or `false`.

       *   **Equal to (`==`)**: Evaluates if the value on the left is structurally identical to the value on the right.
       *   **Not equal to (`!=`)**: Evaluates if two values are unequal or distinct from one another.
       *   **Less than (`<`)**: Checks if the left parameter value is strictly smaller than the right parameter value.
       *   **Less than or equal to (`<=`)**: Verifies if the left parameter value is either smaller than or completely equal to the right value.
       *   **Greater than (`>`)**: Checks if the left parameter value is strictly larger than the right parameter value.
       *   **Greater than or equal to (`>=`)**: Verifies if the left parameter value is either larger than or completely equal to the right value.

### Day 3: Logical Operators & Assignment Operators

*   **3. Logical Operators**

    Used when handling multiple logical states to combine or invert conditions for complex business logic evaluations.

      *   **Logical AND (`&&`)**: Returns `true` only when both conditions evaluate to true. It features *short-circuit evaluation*, meaning if the first condition is false, it skips evaluating the second condition entirely.
      *   **Logical OR (`||`)**: Returns `true` if at least one of the conditions evaluates to true. It also features short-circuiting; if the first expression is true, it skips evaluating the rest.
      *   **Logical NOT (`!`)**: An unary operator that inverts a boolean result, returning `true` when a condition evaluates to false, and `false` when it evaluates to true.

*   **4. Assignment Operators**

    Assignment operators are used to store values into variables. The standard assignment operator can be combined with arithmetic operators to create shorthand compound statements that calculate and assign data in a single operational step.

      *   **Standard Assignment (`=`)**: Assigns the value or evaluation result on the right side directly to the variable on the left side.
      *   **Add and Assign (`+=`)**: Adds the value on the right to the existing variable value, then stores the updated result back into the variable.
      *   **Subtract and Assign (`-=`)**: Subtracts the value on the right from the existing variable value, then stores the updated result back into the variable.
      *   **Multiply and Assign (`*=`)**: Multiplies the existing variable value by the value on the right, then stores the updated result back into the variable.
      *   **Divide and Assign (`/=`)**: Divides the existing variable value by the value on the right, then stores the updated result back into the variable.
      *   **Modulo and Assign (`%=`)**: Performs a modulus operation on the variable using the value on the right, then stores the remaining balance back into the variable.

---

### Day 4: Incremental/Decremental Bitwise Operations

*  **5. Increment/Decrement Operators**

   Used to increase or decrease the numeric value of an integer variable by exactly 1. Their behavior alters based on whether the operator is placed before or after the variable name.

      *   **Increment (`++`)**: Adds exactly 1 to the variable.
            *   **Post-Increment (`x++`)**: Evaluates the current value of `x` inside the enclosing statement first, then increases `x` by 1.
            *   **Pre-Increment (`++x`)**: Increases `x` by 1 first, then passes the newly updated value to the enclosing statement.
      *   **Decrement (`--`)**: Subtracts exactly 1 from the variable.
            *   **Post-Decrement (`x--`)**: Evaluates the current value of `x` inside the enclosing statement first, then decreases `x` by 1.
            *   **Pre-Decrement (`--x`)**: Decreases `x` by 1 first, then passes the newly updated value to the enclosing statement.

*  **6. Bitwise Operators**

   Used to perform bit-level operations directly on the individual binary bit representations of integer values. They execute exceptionally fast because they translate directly to hardware-level machine instructions.

      * **Note:** Commonly used for low-level network optimization, cryptography, and parsing binary flag configurations.

---

### Day 5: Ternary & Null-Coalescing Operators

*  **7. Ternary Operator**

      A shorthand alternative for a standard if-else statement that evaluates a boolean condition and dynamically yields one of two distinct values depending on the result. It is highly useful for assigning variables or formatting display outputs inline.

      *   **Syntax Structure:** `condition ? value_if_true : value_if_false`

*  **8. Null-Coalescing Operator**
    
      A specialized operator used to establish strict defense routines against null value fields. It evaluates a target variable pointer; if that variable is unassigned or null, it instantly passes back a designated fallback default value instead.

      *  **Syntax Structure:** `variable ?? default_fallback_value`

---

### Day 6: Decision Making (if, if else, if else ladder, Nested if, Switch, Nested Switch)

Decision-making structures direct the application's execution path by branching code execution based on whether specific 
evaluation criteria yield a true or false boolean state.

**Types of Decision Making in C#**
    
*  **1. If Statement**

   The standard `if` statement checks a single given conditional expression. If that condition evaluates to `true`, the block of code/statements directly enclosed inside its curly braces will execute. If it evaluates to `false`, the code block is skipped entirely.

    *   **1. If Statement**
        The `if` statement is a conditional control structure that executes a block of code if, and only if, its specified boolean condition evaluates to true. It serves as the fundamental branching mechanism in application logic.

        *   **Syntax Structure:**
            ```csharp
            if (condition) 
            {  
                // code to be executed if condition is true
            }
            ```

    *  **2. If-Else Statement**
       The `if-else` structure handles mutual exclusion logic paths. If the primary expression evaluates to `true`, the first block of code runs. If it evaluates to `false`, the execution flow jumps straight into the `else` block to process the alternative backup layout logic.

       *   **Syntax Structure:**
            
        ```csharp
        if (condition)
        {  
            // code executed if condition is true  
        }
        else
        {  
            // code executed if condition is false  
        }
        ```

    *  **3. If-Else-If Ladder Statement**
       The `if-else-if` ladder processes a sequential evaluation chain to check multiple distinct conditions one after another. The program tests conditions from top to bottom; the absolute first block that returns `true` executes, immediately ending the entire ladder. If every single check fails, the final `else` block handles the execution fall-through.

       *   **Syntax Structure:**
        ```csharp
        if (condition1)
        {  
            // code to be executed if condition1 is true  
        }
        else if (condition2)
        {  
            // code to be executed if condition2 is true  
        }  
        else if (condition3)
        {  
            // code to be executed if condition3 is true  
        }  
        else
        {
            // code to be executed if all the conditions are false  
        }
        ```

    *  **4. Nested-If Statement**
       An `if` statement embedded entirely inside the body of another `if` block is called a nested conditional structure. The inner condition acts as a dependent sub-condition of the outer parent check. The secondary internal statement block will only evaluate if the primary outer parent condition returns `true`.

       *   **Syntax Structure:**
            ```csharp
            if (condition1) 
            {
                // code executes if condition1 is true 
                if (condition2) 
                {
                    // code executes only if both condition1 and condition2 are true 
                }
            }
            ```

   *  **5. Switch Statement**
      The `switch` statement acts as a highly clear, optimized layout alternative to a long, messy `if-else-if` ladder. It tests a single target expression against an explicit list of literal value tags called `case` checkpoints. 
        *   *Control Flags:* A `break` statement marker must terminate each case block to cleanly jump out of the switch workspace. Skipping a `break` causes case fall-through issues.
        *   *Fallback Strategy:* An optional `default` case wrapper can be appended to capture unexpected variables that match none of the explicit values.

        *   **Syntax Structure:**
        ```csharp
        switch (expression)
        {
            case value1:
                // statement sequence
                break;
            case value2:
                // statement sequence
                break;
            default:
                // default statement sequence
                break;
        }
        ```

    *  **6. Nested Switch Statement**  
    C# fully supports placing an inner `switch` control layout within a case marker of a completely separate parent 
    `switch` block. This allows programmers to execute secondary multi-choice selections dependent on an initial 
    chosen primary category value option.

       *   **Syntax Structure:**
        ```csharp
        switch (outerExpression)
        {
            case value1:
                // statements...
                switch (innerExpression)
                {
                    case subValue1:
                        // statements...
                        break;
                    case subValue2:
                        // statements...
                        break;
                }
                break;
            case value2:
                // statements...
                break;
        }
        ```

### Day 7: Loops in C# (For Loop, Do Loop, Do while Loop, Foreach Loop, Nested Loops)

Looping in a programming language is a way to execute a statement or a set of statements multiple times, 
depending on the result of the condition to be evaluated to execute statements. 
The result condition must be true to execute statements within loops.

* **Loop Structures in C#**

* **1. For Loop**

    The `for` loop is a control flow statement that allows you to execute a block of code repeatedly for a fixed number of iterations. It is commonly used when the number of repetitions is known beforehand.

    * **Syntax Structure:**
    ```csharp
    for (initialization; testing condition; increment/decrement)
    {    
         // statements to be executed
    }
    ```

* **2. Foreach Loop**

    The `foreach` loop is specifically designed to iterate through collections like arrays or lists sequentially. It automatically manages collection bounds safely and abstracts away manual index counters.

    * **Syntax Structure:**
    ```csharp
    foreach (dataType element in collection)
    {
         // statements to be executed using element
    }
    ```

* **3. While Loop

    The `while` loop evaluates its condition before executing the loop body. If the condition is true, the statements inside the loop run, and the process repeats. If the condition evaluates to false at the very beginning, the loop body will not execute at all.

    * **Syntax Structure:**
    ```csharp
    while (condition)
    {
         // statements to be executed
    }
    ```

* **4. Do-While Loop**

    The `do-while` loop is similar to the `while` loop, with the primary difference being that it checks the condition *after* executing the statements. Because the test occurs at the end, it will execute the loop body one time for sure before evaluating the condition.

    * **Syntax Structure:**
    
    ```csharp
    do
    {
         // statements...
    } while (condition);
    ```

* **5. Nested Loops**

    A nested loop refers to a loop inside the body of another loop. The inner loop executes its complete set of iterations every single time the outer loop runs through a single iteration. This is commonly used for working with multi-dimensional data structures like matrices or grids.

    * **Syntax Structure:**
    
        ```csharp
        for (initialization; condition; increment)
        {
             // outer loop statements
             while (condition)
             {
                  // inner loop statements
             }
        }
        ```


## 📁 Phase_1_Basics / Week-2: Break, Continue, Goto, Return, Throw, Parameter Modifiers (ref, out, in), Constant & Readonly Modifiers, Class, Struct, Record Type Declarations, Virtual, Override, New Modifiers, Abstract Classes & Interfaces

### Day 1: Break & Continue Statements

*   **Loop Control Statements**

    *   **1. Break Statement**
        Instantly terminates the nearest enclosing loop or switch statement, transferring control to the first line of code immediately following that structure.

        *   **Syntax Structure:**
            ```csharp
            // Usage inside a Loop structure
            while (condition)
            {
                if (triggerCondition)
                {
                    break; // Exits the enclosing loop immediately
                }
            }

            // Usage inside a Switch structure
            switch (variable)
            {
                case value:
                    // statements to execute
                    break; // Exits the switch block immediately
            }
            ```

    *   **2. Continue Statement**
        Immediately skips the remaining code in the current iteration of a loop and jumps to the next iteration, re-evaluating the loop's condition.

        *   **Syntax Structure:**
            ```csharp
            // Usage inside a Loop structure
            for (int i = 0; i < limit; i++)
            {
                if (skipCondition)
                {
                    continue; // Immediately skips the remaining code and jumps to the next iteration
                }
                // This code will be skipped if skipCondition is true
            }
            ```

### Day 2: Goto, Return & Throw Statements

*   **Jump Statements**

    *   **3. Goto Statement**
        Transfers the program control directly to a labeled statement. While generally discouraged in structured programming due to readability issues, it is occasionally used in complex nested switches.

        *   **Syntax Structure:**
            ```csharp
            // Usage in normal execution flow
            if (condition)
            {
                goto MyLabel; // Jumps directly to the label
            }

            // Code here is skipped if condition is true

            MyLabel:
                // Statements to execute after the jump
            ```

    *   **4. Return Statement**
        Terminates execution of the method in which it appears and returns control to the calling method. It can optionally return a value matching the method's return type.

        *   **Syntax Structure:**
            ```csharp
            // Usage in a method returning a value
            public int CalculateSum(int a, int b)
            {
                return a + b; // Returns the result and exits the method
            }

            // Usage in a void method (no return value)
            public void ProcessData()
            {
                if (dataIsEmpty)
                {
                    return; // Exits the method immediately
                }
            }
            ```

    *   **5. Throw Statement**
        Signals the occurrence of an exception during program execution, interrupting normal flow and handing control over to the nearest error-handling `catch` block.

        *   **Syntax Structure:**
            ```csharp
            // Usage to instantiate and throw a new exception
            if (userInput == null)
            {
                throw new ArgumentNullException(nameof(userInput), "Input cannot be null.");
            }

            // Usage to rethrow an exception inside a catch block
            try
            {
                // Dangerous code
            }
            catch (Exception ex)
            {
                // Log exception details here
                throw; // Rethrows the original exception, preserving the stack trace
            }
            ```

### Day 3: Parameter Modifiers (ref, out, in)

*   **Method Parameters (Modifiers)**

    *   **1. Ref Parameter Modifier**
        Passes an argument by reference rather than by value. This means any changes made to the parameter inside the method will directly update the original variable passed into it. The variable must be initialized before it is passed.

        *   **Syntax Structure:**
            ```csharp
            // Method Definition
            public void ModifyValue(ref int number)
            {
                number += 10; // Changes the original variable directly
            }

            // Method Call
            int originalValue = 5; // Must be initialized
            ModifyValue(ref originalValue);
            // originalValue is now 15
            ```

    *   **2. Out Parameter Modifier**
        Passes an argument by reference, similar to `ref`, but specifically used when a method needs to return multiple values. The variable does not need to be initialized before being passed, but the method *must* assign a value to it before returning.

        *   **Syntax Structure:**
            ```csharp
            // Method Definition
            public void GetCoordinates(out int x, out int y)
            {
                x = 10; // Must be assigned before method exits
                y = 20; // Must be assigned before method exits
            }

            // Method Call
            int currentX; // Does not need initialization
            GetCoordinates(out currentX, out int currentY); // Can also declare inline
            // currentX is 10, currentY is 20
            ```

    *   **3. In Parameter Modifier**
        Passes an argument by reference but prevents the method from modifying its value. This ensures memory efficiency for large value types (like large structures) by avoiding a copy, while safely guaranteeing that the data remains read-only.

        *   **Syntax Structure:**
            ```csharp
            // Method Definition
            public void DisplayDetails(in BigStructure data)
            {
                // data.Value = 10; // Compile Error: Cannot modify an 'in' parameter
                Console.WriteLine(data.LargeDataChunk);
            }

            // Method Call
            BigStructure originalData = new BigStructure();
            DisplayDetails(in originalData); // 'in' keyword is optional on call but recommended
            ```



### Day 4: Const & Readonly Modifiers

*   **Constants and Readonly Fields**

    *   **1. Const Keyword**
        Defines a compile-time constant. Its value must be assigned at the time of declaration and can never be changed afterward. Because it is evaluated at compile time, it cannot rely on runtime computations or object initialization. Constants are implicitly static.

        *   **Syntax Structure:**
            ```csharp
            // Declaration inside a class or method
            public const double Pi = 3.14159; 
            // public const DateTime CurrentTime = DateTime.Now; // Compile Error: Not a compile-time constant

            // Usage
            double area = Pi * radius * radius;
            ```

    *   **2. Readonly Keyword**
        Defines a runtime constant. A `readonly` field can be initialized either at the time of declaration or inside a constructor of the same class. This allows its value to be determined dynamically at runtime, but once the constructor finishes executing, the value cannot be modified.

        *   **Syntax Structure:**
            ```csharp
            public class Configuration
            {
                // Initialization at declaration
                public readonly string ConnectionString = "Server=myServerAddress;";
                public readonly DateTime InstanceCreationTime;

                // Initialization inside a constructor
                public Configuration()
                {
                    InstanceCreationTime = DateTime.Now; // Allowed at runtime
                }

                public void UpdateSettings()
                {
                    // ConnectionString = "NewServer;"; // Compile Error: Cannot modify outside a constructor
                }
            }
            ```


### Day 5: Class, Struct, & Record Type Declarations

*   **Types and Data Structures**

    *   **1. Class**
        Defines a reference type that supports object-oriented programming principles like inheritance and polymorphism. Instances of a class are stored on the heap, and variables hold a reference to the memory address. Copying a class variable copies the reference, meaning both variables point to the same object.

        *   **Syntax Structure:**
            ```csharp
            // Definition
            public class Customer
            {
                public int Id { get; set; }
                public string Name { get; set; }

                public Customer(int id, string name)
                {
                    Id = id;
                    Name = name;
                }
            }

            // Usage
            Customer customer1 = new Customer(1, "Alice");
            Customer customer2 = customer1; // Copies reference; both point to the same object
            ```

    *   **2. Struct**
        Defines a value type that is typically used for small, lightweight data structures with little to no behavior. Struct instances are stored on the stack (unless part of a reference type) and contain their actual data directly. Copying a struct duplicates the entire values of its members, making the new copy independent of the original. Structs do not support inheritance.

        *   **Syntax Structure:**
            ```csharp
            // Definition
            public struct Point
            {
                public int X { get; set; }
                public int Y { get; set; }

                public Point(int x, int y)
                {
                    X = x;
                    Y = y;
                }
            }

            // Usage
            Point point1 = new Point(10, 20);
            Point point2 = point1; // Copies values; point2 is an independent copy
            ```

    *   **3. Record**
        Introduced in C# 9, a record is a specialized type (can be reference-based `record class` or value-based `record struct`) optimized for immutable data models and value-based equality. Instead of comparing memory references, two distinct record instances are considered equal if all their properties hold identical values. They feature a clean positional syntax for declaration.

        *   **Syntax Structure:**
            ```csharp
            // Definition (Positional Record Class - Immutable by default)
            public record Product(int Id, string Name, double Price);

            // Usage
            Product product1 = new Product(101, "Laptop", 999.99);
            Product product2 = new Product(101, "Laptop", 999.99);

            // Value-based equality evaluation
            bool isEqual = (product1 == product2); // Evaluates to true

            // Non-destructive mutation using the 'with' expression
            Product updatedProduct = product1 with { Price = 899.99 };
            ```

### Day 6: Virtual, Override, & New Modifiers

*   **Polymorphism and Method Overriding**

    *   **1. Virtual Modifier**
        Used inside a base class to declare that a method, property, or indexer can be overridden in any deriving subclass. A `virtual` member provides a default implementation but opens the door for specialized behavior down the inheritance chain.

        *   **Syntax Structure:**
            ```csharp
            public class BaseClass
            {
                // Declares a virtual method with a base implementation
                public virtual void DisplayMessage()
                {
                    Console.WriteLine("Message from BaseClass");
                }
            }
            ```

    *   **2. Override Modifier**
        Used inside a derived subclass to extend or replace the implementation of an inherited `virtual` or `abstract` member. This enables runtime polymorphism: even if the subclass object is referenced via a base class variable, the overridden subclass method will run.

        *   **Syntax Structure:**
            ```csharp
            public class SubClass : BaseClass
            {
                // Overrides the base class implementation completely
                public override void DisplayMessage()
                {
                    Console.WriteLine("Message from SubClass");
                }
            }

            // Polymorphic Behavior Usage:
            BaseClass reference = new SubClass();
            reference.DisplayMessage(); // Outputs: "Message from SubClass"
            ```

    *   **3. New Modifier (Method Hiding)**
        Explicitly hides a member inherited from a base class. Instead of overriding, it creates a completely independent member with the exact same name. If the object is cast or referenced as the base class type, the original base class method will run instead of the hidden subclass method.

        *   **Syntax Structure:**
            ```csharp
            public class AnotherSubClass : BaseClass
            {
                // Hides the base class method explicitly
                public new void DisplayMessage()
                {
                    Console.WriteLine("Message from AnotherSubClass");
                }
            }

            // Method Hiding Behavior Usage:
            BaseClass reference = new AnotherSubClass();
            reference.DisplayMessage(); // Outputs: "Message from BaseClass"

            AnotherSubClass directReference = new AnotherSubClass();
            directReference.DisplayMessage(); // Outputs: "Message from AnotherSubClass"
            ```

### Day 7: Abstract Classes & Interfaces

*   **Abstraction Mechanisms**

    *   **1. Abstract Class**
        Defines a partial blueprint intended strictly for inheritance. It cannot be instantiated directly. An `abstract` class can contain both implemented members (methods with bodies) and abstract members (methods without bodies that *must* be overridden by derived classes). It is used to establish an "is-a" relationship across closely related objects.

        *   **Syntax Structure:**
            ```csharp
            // Definition
            public abstract class Vehicle
            {
                // Abstract method (no body, must be implemented by subclass)
                public abstract void StartEngine();

                // Fully implemented method (inherited by subclass)
                public void Honk()
                {
                    Console.WriteLine("Beep beep!");
                }
            }

            // Implementation
            public class Car : Vehicle
            {
                public override void StartEngine()
                {
                    Console.WriteLine("Car engine started via ignition key.");
                }
            }
            ```

    *   **2. Interface**
        Defines a strict contract that implementing types must fulfill. An interface contains declarations of methods, properties, events, or indexers, but traditionally no data fields. While C# allows default implementations inside interfaces, they remain decoupled from class state. Classes and structs can implement multiple interfaces, allowing a "can-do" relationship that bypasses single-inheritance limitations.

        *   **Syntax Structure:**
            ```csharp
            // Definition
            public interface IPrintable
            {
                void Print(); // Contract method declaration
            }

            public interface IStorable
            {
                void Save(string path);
            }

            // Implementation of multiple interfaces
            public class Document : IPrintable, IStorable
            {
                public void Print()
                {
                    Console.WriteLine("Printing document text...");
                }

                public void Save(string path)
                {
                    Console.WriteLine(\$"Document saved safely to {path}");
                }
            }
            ```


## 📁 Phase_1_Basics / Week-3: Abstract Classes & Interfaces, Static vs Instance Members, Throw vs Throw ex Statements, Task vs Thread Abstractions, Async vs Await Directives, Lock vs Monitor Synchronization, Is vs As vs Explicit Casting, IEnumerable vs IQueryable Execution

### Day 1: Static vs Instance Members   

*   **Static vs Instance Members**

    *   **1. Static Members**
        Belong directly to the class structure itself rather than to individual instances (objects) created from the class. A static member is shared globally across all instances, meaning only one copy exists in memory. It is accessed directly via the class name and cannot reference non-static fields or methods without an explicit object reference.

        *   **Syntax Structure:**
            ```csharp
            // Definition
            public class Counter
            {
                // Shared static field across all instances
                public static int InstanceCount { get; private set; }

                public Counter()
                {
                    InstanceCount++; // Updates the shared global count
                }

                // Static utility method
                public static void ResetCount()
                {
                    InstanceCount = 0;
                }
            }

            // Usage
            Counter c1 = new Counter();
            Counter c2 = new Counter();
            int total = Counter.InstanceCount; // Accessed via class name: evaluates to 2
            ```

    *   **2. Instance Members**
        Belong explicitly to a specific object instance created from the class template. Every object maintains its own distinct copy of instance fields, independent of other objects. Instance members can freely access both other instance properties and static variables within the same class context.

        *   **Syntax Structure:**
            ```csharp
            // Definition
            public class User
            {
                // Unique to every individual instance
                public string Username { get; set; }

                public User(string username)
                {
                    Username = username;
                }

                // Instance method operating on instance data
                public void DisplayProfile()
                {
                    Console.WriteLine(\$"User: {Username}");
                }
            }

            // Usage
            User user1 = new User("Alice");
            User user2 = new User("Bob");
            user1.DisplayProfile(); // Outputs data unique to user1: "User: Alice"
            ```


### Day 2: Throw vs Throw ex Statements

*   **Exception Handlers (Rethrowing)**

    *   **1. Throw Statement (Preserving Stack Trace)**
        Rethrows the caught exception exactly as it is, preserving the complete original stack trace. This allows developers to trace the error back to its authentic origin point rather than where it was caught and rethrown.

        *   **Syntax Structure:**
            ```csharp
            try
            {
                // Code that causes an error deep inside the stack
                int result = int.Parse("InvalidNumber");
            }
            catch (Exception ex)
            {
                // Optional: Log the exception details locally
                throw; // Rethrows 'ex' while fully preserving its true origin line number
            }
            ```

    *   **2. Throw ex Statement (Resetting Stack Trace)**
        Rethrows the caught exception object variable explicitly, which violently overwrites the stack trace log. The execution history is completely wiped clean up to that point, making it appear to tools and debuggers as if the error originated exactly at the line where `throw ex;` was declared.

        *   **Syntax Structure:**
            ```csharp
            try
            {
                // Code that causes an error deep inside the stack
                int result = int.Parse("InvalidNumber");
            }
            catch (Exception ex)
            {
                // Bad Practice: Wipes out the source stack trace history
                throw ex; // Resets the stack trace origin to this exact line
            }
            ```

### Day 3: Task vs Thread Abstractions

*   **Asynchronous and Multithreading Abstractions**

    *   **1. Thread Abstraction (Low-Level)**
        Represents an actual operating system-level thread execution path. It gives developers direct, low-level control over concurrency, allowing them to manage priorities, abort threads, or configure background/foreground states. However, threads incur significant memory overhead and high context-switching costs, making manual thread creation inefficient for scaling small, short-lived operations.

        *   **Syntax Structure:**
            ```csharp
            using System.Threading;

            // Definition of a worker method
            void PerformHeavyWork()
            {
                Console.WriteLine("Working directly on an OS thread...");
                Thread.Sleep(2000); // Blocks the current thread
            }

            // Initialization and Start
            Thread thread = new Thread(PerformHeavyWork);
            thread.Start(); // Spins up a new operating system thread
            thread.Join();  // Blocks the calling thread until this thread finishes
            ```

    *   **2. Task Abstraction (High-Level / TPL)**
        Introduced via the Task Parallel Library (TPL), a `Task` represents a higher-level asynchronous operation rather than a specific physical thread. Tasks are managed automatically by the internal `ThreadPool`, which reuses existing system threads to eliminate heavy startup overhead. Tasks return data easily, support chaining via continuations, and power the clean `async` and `await` asynchronous syntax pattern.

        *   **Syntax Structure:**
            ```csharp
            using System.Threading.Tasks;

            // Definition of an asynchronous task-returning method
            async Task<int> FetchDataLengthAsync()
            {
                // Awaits an operation without blocking the underlying thread
                await Task.Delay(2000); 
                return 42;
            }

            // Direct execution on the ThreadPool via Task.Run
            Task task = Task.Run(() => 
            {
                Console.WriteLine("Executing efficiently via the ThreadPool...");
            });

            // Awaiting the task result
            int result = await FetchDataLengthAsync();
            ```

### Day 4: Async vs Await

*   **Asynchronous Programming Foundations**

    *   **1. Async Modifier**
        Used to mark a method, lambda expression, or anonymous method as asynchronous. The `async` modifier signals to the compiler that the method intends to perform non-blocking operations and allows the use of the `await` keyword within its body. An async method must return `Task`, `Task<T>`, `ValueTask`, `ValueTask<T>`, or `void` (though `void` should be reserved strictly for event handlers).

        *   **Syntax Structure:**
            ```csharp
            // The async modifier enables the use of await inside the method body
            public async Task<string> DownloadWebPageAsync(string url)
            {
                // Method body goes here
                return "Content";
            }
            ```

    *   **2. Await Operator**
        Suspends the evaluation of the enclosing async method until the asynchronous operation completes. Crucially, it does **not** block the underlying execution thread. Instead, it yields control back to the caller or runtime environment, keeping applications responsive. Once the awaited task finishes, execution resumes right where it left off, extracting the return value automatically.

        *   **Syntax Structure:**
            ```csharp
            public async Task ProcessDownloadAsync()
            {
                HttpClient client = new HttpClient();

                // The await operator pauses this method non-blockingly until GetStringAsync finishes
                string content = await client.GetStringAsync("https://example.com");

                // Execution resumes seamlessly here with 'content' fully populated
                Console.WriteLine(content.Length);
            }
            ```

### Day 5: Lock vs Monitor

*   **Thread Synchronization Mechanisms**

    *   **1. Lock Statement**
        Provides a clean, high-level syntactic sugar wrapper for mutual exclusion. It ensures that only one thread can enter a critical section of code at any given time. The `lock` statement automatically handles acquiring a mutual exclusion lock on a reference object and guarantees release of that lock, even if an exception occurs inside the block.

        *   **Syntax Structure:**
            ```csharp
            public class ThreadSafeCache
            {
                private readonly object _lockObject = new object();
                private int _counter = 0;

                public void IncrementCounter()
                {
                    // Syntactic sugar that guarantees mutual exclusion
                    lock (_lockObject)
                    {
                        _counter++;
                    } // Lock is automatically released here
                }
            }
            ```

    *   **2. Monitor Class**
        Provides a low-level, fine-grained static mechanism to synchronize thread access to objects. The `lock` statement is actually compiled into a `Monitor.Enter` and `Monitor.Exit` structure wrapped in a `try-finally` block. Using the `Monitor` class directly gives developers access to advanced control mechanisms like timeout thresholds during lock acquisition and explicit thread signaling (`Wait`, `Pulse`, and `PulseAll`).

        *   **Syntax Structure:**
            ```csharp
            public class AdvancedSynchronization
            {
                private readonly object _lockObject = new object();

                public void TryProcessingData()
                {
                    bool lockAcquired = false;

                    try
                    {
                        // Attempts to acquire the lock with a 2-second timeout window
                        Monitor.TryEnter(_lockObject, TimeSpan.FromSeconds(2), ref lockAcquired);

                        if (lockAcquired)
                        {
                            // Critical section execution
                            Console.WriteLine("Lock acquired successfully via Monitor.");
                        }
                        else
                        {
                            // Fallback logic if the lock was busy
                            Console.WriteLine("Lock acquisition timed out.");
                        }
                    }
                    finally
                    {
                        if (lockAcquired)
                        {
                            Monitor.Exit(_lockObject); // Must be explicitly released
                        }
                    }
                }
            }
            ```

### Day 6: Is vs As vs Casting

*   **Type Evaluation and Conversion Modifiers**

    *   **1. Type Casting (Explicit Conversion)**
        Directly forces an expression to be treated as a specific target type. If the object's runtime type matches or is derived from the target type, the conversion succeeds. However, if the object is incompatible, a `InvalidCastException` is thrown immediately, halting execution.

        *   **Syntax Structure:**
            ```csharp
            object obj = "Hello World";

            // Direct conversion attempt
            try
            {
                string text = (string)obj; // Succeeds because obj is a string
                int number = (int)obj;     // Fails: Throws InvalidCastException
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("Incompatible type mapping detected.");
            }
            ```

    *   **2. As Operator (Safe Casting)**
        Performs an explicit type conversion but handles failures gracefully. Instead of raising an exception when a type mismatch occurs, the `as` operator evaluates to `null`. Because it returns `null` upon failure, it can only be used with reference types or nullable value types.

        *   **Syntax Structure:**
            ```csharp
            object obj = "Hello World";

            // Safe cast evaluation
            string text = obj as string; // Succeeds: text contains "Hello World"
            int? number = obj as int?;   // Fails safely: number becomes null

            if (text != null)
            {
                Console.WriteLine(text.Length);
            }
            ```

    *   **3. Is Operator (Type Checking)**
        Evaluates whether an object's runtime type matches a given target type, returning a boolean `true` or `false`. Modern C# enhances the `is` operator with pattern matching, allowing developers to safely check a type and declare a strongly typed inline variable simultaneously.

        *   **Syntax Structure:**
            ```csharp
            object obj = "Hello World";

            // Traditional Type Checking
            if (obj is string)
            {
                Console.WriteLine("Object is a string instance.");
            }

            // Modern Type Checking with Inline Pattern Matching
            if (obj is string verifiedText)
            {
                // verifiedText is automatically available within this scope
                Console.WriteLine(verifiedText.Length);
            }
            ```

### Day 7: IEnumerable vs IQueryable

*   **Data Query Abstractions**

    *   **1. IEnumerable**
        Defines an in-memory forward-only collection cursor. When running queries using LINQ-to-Objects on an `IEnumerable` collection, all data is loaded directly into the application's local memory (RAM) first, and any filtering, sorting, or projection operations are executed locally. It is ideal for querying in-memory arrays, lists, or collections.

        *   **Syntax Structure:**
            ```csharp
            using System.Collections.Generic;
            using System.Linq;

            List<Product> memoryCollection = GetProductList();

            // Query executed completely in-memory (Client-Side Evaluation)
            IEnumerable<Product> filteredProducts = memoryCollection
                .Where(p => p.Price > 500)
                .Take(10);
            ```

    *   **2. IQueryable**
        Defines an out-of-memory remote data collection provider that inherits from `IEnumerable`. When running LINQ queries (such as LINQ-to-Entities in Entity Framework) against an `IQueryable` target, the operations are not run locally. Instead, they are parsed into an internal expression tree and translated directly into a native remote server-side query (e.g., SQL) before execution. This ensures that only the filtered dataset is returned over the network.

        *   **Syntax Structure:**
            ```csharp
            using System.Linq;

            MyDbContext dbContext = new MyDbContext();

            // Query parsed as an Expression Tree and executed on the Database (Server-Side Evaluation)
            IQueryable<Product> DBQuery = dbContext.Products
                .Where(p => p.Price > 500)
                .Take(10); // Generates "SELECT TOP 10 ... WHERE Price > 500" in SQL
            ```


## Keywords in C#

In C#, keywords are predefined, reserved words that carry special meaning for the compiler. 
Because they are part of the core language syntax, they cannot be used as regular identifiers 
(such as variable names, class names, or method names) unless they are prefixed with the @ symbol 
(e.g., int @class = 5;).

C# categorizes its keywords into two primary sets:

* **Reserved Keywords** (always reserved) and 

Reserved KeywordsThese are strict compiler tokens that cannot be used as identifiers anywhere in your code
without a prefix. They are categorized by functionality:

* **Contextual Keywords** (reserved only in specific code contexts).

Contextual KeywordsThese words have a special meaning only within specific language features. 
Outside of those contexts, you can freely use them as variable names without the @ prefix


* **Data & Properties:** get, set, init, value, var, dynamic, record
* **Asynchronous Programming:** async, await
* **LINQ Query Expressions:** from, where, select, join, orderby, group, into, equals
* **Miscellaneous:** nameof, when, yield, with
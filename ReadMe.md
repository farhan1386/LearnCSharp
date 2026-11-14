# 📘 Phase 1: Basics of C# Programming (`Phase_1_Basics`)

This master documentation serves as your comprehensive reference guide for foundational C# development, mapped directly to your **Week-1**, **Week-2**, and **Week-3** project folders and `.cs` source files.

---

## 📑 Table of Contents
1. [Week-1: Language Basics & Fundamentals](#week-1-language-basics--fundamentals)
   * [Day-1: Variables & Core Data Types](#day-1-variables--core-data-types)
   * [Day-2: Arithmetic & Relational Operators](#day-2-arithmetic--relational-operators)
   * [Day-3: Assignment & Logical Operators](#day-3-assignment--logical-operators)
   * [Day-4: Bitwise & Increment Operators](#day-4-bitwise--increment-operators)
   * [Day-5: Null-Coalescing & Ternary Mechanics](#day-5-null-coalescing--ternary-mechanics)
   * [Day-6: Control Flow & Decision Making](#day-6-control-flow--decision-making)
   * [Day-7: Loops & Iteration Statements](#day-7-loops--iteration-statements)
2. [Week-2: Control Statements & Parameter Keywords](#week-2-control-statements--parameter-keywords)
   * [Day-1: Control Flow Modifiers](#day-1-control-flow-modifiers)
   * [Day-2: Jump & Exception Keywords](#day-2-jump--exception-keywords)
   * [Day-3: Method Parameter Modifiers](#day-3-method-parameter-modifiers)
   * [Day-4: Value Mutability Constraints](#day-4-value-mutability-constraints)
   * [Day-5: Type Architecture & Semantics](#day-5-type-architecture--semantics)
   * [Day-6: Polymorphism Core Keywords](#day-6-polymorphism-core-keywords)
   * [Day-7: Advanced Abstraction Contracts](#day-7-advanced-abstraction-contracts)
3. [Week-3: Memory, Concurrency & Querying](#week-3-memory-concurrency--querying)
4. [C# Reserved & Contextual Keywords Reference](#c-reserved--contextual-keywords-reference)

---

## 📁 Week-1: Language Basics & Fundamentals

### Day-1: Variables & Core Data Types
* 📄 **Source File:** `VariablesAndDataTypes.cs`

* **Variable:** A named memory location used to store data during program execution. Each variable consists of:
  * **Name:** Identifier used to reference the variable.
  * **Type:** Specifies the type of data the variable can store (`int`, `char`, `double`, etc.).
  * **Value:** The actual data stored in the variable.

#### 1. Value Data Types (Stored on the Stack)
Store the actual value directly in memory. Each variable maintains its own copy of the data.
* **`int`**: Stores 32-bit signed whole numbers ($-2^{31}$ to $2^{31} - 1$).
* **`float`**: Stores single-precision decimal numbers. Requires the `f` or `F` suffix (e.g., `12.5f`).
* **`double`**: Stores high-precision 64-bit decimal numbers (default for fractional literals).
* **`char`**: Stores a single 2-byte Unicode character enclosed in single quotes (`'A'`).
* **`bool`**: Stores logical values (`true` or `false`).

#### 2. Reference Data Types (Stored on the Heap)
Store a reference (memory address) pointing to the data. Multiple variables can reference the same object.
* **`string`**: Stores an immutable sequence of characters. Reassigning creates a new string reference.
* **`object`**: The base type of all C# types; supports boxing and unboxing conversions.
* **`Array`**: A fixed-size collection of elements of the same type stored in contiguous memory.

#### 3. Pointer Data Types
* **`int* p`**: Stores raw memory addresses for low-level `unsafe` memory manipulation.

---

### Day-2: Arithmetic & Relational Operators
* 📄 **Source Files:** `Arithmetic_Operators.cs` (`ArithmeticOperators.cs`), `Relational_Operators.cs` (`RelationalOperators.cs`)

#### 1. Arithmetic Operators
* **`+` (Addition):** Sums numeric values or concatenates strings.
* **`-` (Subtraction):** Subtracts the right operand from the left operand.
* **`*` (Multiplication):** Multiplies two numeric values.
* **`/` (Division):** Divides two numbers. *Note: Integer division truncates decimals; floating-point division preserves precision.*
* **`%` (Modulus):** Returns the remainder after integer division.

#### 2. Relational Operators (Return `bool`)
* **`==` (Equal to):** Checks if two values are equal.
* **`!=` (Not equal to):** Checks if two values are different.
* **`<` (Less than)** & **`<=` (Less than or equal to)**
* **`>` (Greater than)** & **`>=` (Greater than or equal to)**

---

### Day-3: Assignment & Logical Operators
* 📄 **Source Files:** `Assignment_Operators.cs` (`AssignmentOperators.cs`), `Logical_Operators.cs` (`LogicalOperators.cs`)

#### 1. Assignment Operators
* **`=`**: Standard assignment.
* **Compound Assignments:** `+=`, `-=`, `*=`, `/=`, `%=` perform the arithmetic operation and update the variable in one step.

#### 2. Logical Operators
* **`&&` (Logical AND):** Returns `true` only if both conditions are true. Uses **short-circuit evaluation** (skips the second check if the first is `false`).
* **`||` (Logical OR):** Returns `true` if at least one condition is true. Short-circuits if the first condition is `true`.
* **`!` (Logical NOT):** Inverts a boolean value (`!true` becomes `false`).

---

### Day-4: Bitwise & Increment Operators
* 📄 **Source Files:** `Bitwise_Operators.cs` (`BitwiseOperators.cs`), `Increment_Decrement_Operators.cs` (`IncrementDecrementOperators.cs`)

#### 1. Increment (`++`) & Decrement (`--`) Operators
* **Post-Increment (`x++`) / Post-Decrement (`x--`):** Evaluates the current value of `x` in the expression first, then modifies `x` by 1.
* **Pre-Increment (`++x`) / Pre-Decrement (`--x`):** Modifies `x` by 1 first, then returns the updated value.

#### 2. Bitwise Operators
Perform binary bit-level operations directly on integer types (`&`, `|`, `^`, `~`, `<<`, `>>`), commonly used in flags, cryptography, and low-level networking.

---

### Day-5: Null-Coalescing & Ternary Mechanics
* 📄 **Source Files:** `Null_Coalescing_Operator.cs` (`NullCoalescingOperator.cs`), `Ternary_Operator.cs` (`TernaryOperator.cs`)

#### 1. Null-Coalescing Operator (`??`)
Provides a default fallback value when an expression evaluates to `null`:
```csharp
string displayName = username ?? "GuestUser";
```

#### 2. Ternary Conditional Operator (`?:`)
A concise inline shorthand for an `if-else` expression:
```csharp
string status = (score >= 50) ? "Pass" : "Fail";
```

---

### Day-6: Control Flow & Decision Making
* 📄 **Source Files:**
  * `if_statement.cs` (`IfStatement.cs`)
  * `if-else statement.cs` (`IfElseStatement.cs`)
  * `If-Else-If_Ladder_Statement.cs` (`IfElseIfLadderStatement.cs`)
  * `Nested-If_Statement.cs` (`NestedIfStatement.cs`)
  * `switch-statement.cs` (`SwitchStatement.cs`)
  * `Nested_Switch_Statement.cs` (`NestedSwitchStatement.cs`)

#### Decision-Making Constructs
* **`if` / `if-else` / `if-else-if` Ladder:** Evaluates boolean conditions sequentially from top to bottom and executes the first matching branch.
* **Nested `if`:** Places a dependent `if` condition inside an outer `if` block.
* **`switch` & Nested `switch`:** Matches a single expression against discrete `case` constants. Each non-empty `case` must terminate with `break` (or `return`/`goto`), with an optional `default` fallback branch.

```csharp
switch (command)
{
    case "START":
        Console.WriteLine("System starting...");
        break;
    case "STOP":
        Console.WriteLine("System stopping...");
        break;
    default:
        Console.WriteLine("Unknown command.");
        break;
}
```

---

### Day-7: Loops & Iteration Statements
* 📄 **Source Files:**
  * `for-loop.cs` (`ForLoop.cs`)
  * `for-each-loop.cs` (`ForEachLoop.cs`)
  * `while-loop.cs` (`WhileLoop.cs`)
  * `do-while-loop.cs` (`DoWhileLoop.cs`)
  * `nested_loops.cs` (`NestedLoops.cs`)

* **`for` Loop:** Executes a block a predetermined number of times using an initializer, condition, and iterator (`for (int i = 0; i < 10; i++)`).
* **`foreach` Loop:** Safely iterates through every element in a collection (`IEnumerable`) without manual indexing.
* **`while` Loop:** Entry-controlled loop; checks the condition *before* running the body (may run 0 times).
* **`do-while` Loop:** Exit-controlled loop; runs the body *at least once* before checking the condition.
* **Nested Loops:** Places an inner loop inside an outer loop for 2D grids, matrices, and tabular processing.

---

## 📁 Week-2: Control Statements & Parameter Keywords

### Day-1: Control Flow Modifiers
* 📄 **Source Files:** `Break_statement.cs` (`BreakStatement.cs`), `Continue_Statement.cs` (`ContinueStatement.cs`)

* **`break`:** Immediately exits the nearest enclosing loop (`for`, `while`, `do-while`, `foreach`) or `switch` statement.
* **`continue`:** Skips the remaining statements in the current loop iteration and jumps straight to the next iteration.

---

### Day-2: Jump & Exception Keywords
* 📄 **Source Files:** `Goto_Statement.cs` (`GotoStatement.cs`), `Return_Statement.cs` (`ReturnStatement.cs`), `Throw_Statement.cs` (`ThrowStatement.cs`)

* **`goto`:** Transfers execution directly to a named label (`MyLabel:`). Generally avoided in modern code except for jumping between `switch` cases.
* **`return`:** Exits the current method immediately and returns control (and an optional result) to the caller.
* **`throw`:** Signals a runtime exception (`throw new ArgumentNullException(...)`) or rethrows an active exception inside a `catch` block (`throw;`).

---

### Day-3: Method Parameter Modifiers
* 📄 **Source Files:** `in_parameter_keyword.cs` (`InParameterKeyword.cs`), `out_parameter_keyword.cs` (`OutParameterKeyword.cs`), `ref_parameter_keyword.cs` (`RefParameterKeyword.cs`)

| Modifier | Direction | Caller Must Initialize? | Method Must Assign? | Primary Use Case |
| :--- | :--- | :--- | :--- | :--- |
| **`ref`** | Bidirectional (In & Out) | **Yes** | No | Modifying an existing variable directly in place. |
| **`out`** | Outbound only | No | **Yes** | Returning multiple values from a single method call. |
| **`in`** | Inbound (Read-Only) | **Yes** | Forbidden (Read-only) | Passing large `struct` values by reference without copying or mutating. |

```csharp
public void CalculateMetrics(in LargeStruct input, ref int counter, out string status)
{
    counter++;
    status = input.IsValid ? "OK" : "Invalid";
}
```

---

### Day-4: Value Mutability Constraints
* 📄 **Source Files:** `const_modifier_keyword.cs` (`ConstModifierKeyword.cs`), `readonly_modifier_keyword.cs` (`ReadonlyModifierKeyword.cs`)

* **`const` (Compile-Time Constant):** Must be assigned a literal/constant expression at declaration. Implicitly `static` and cannot be changed at runtime.
* **`readonly` (Runtime Constant):** Can be initialized at declaration **or** inside a class constructor, allowing dynamic runtime configuration that becomes immutable once constructed.

---

### Day-5: Type Architecture & Semantics
* 📄 **Source Files:** `class_reference_keyword.cs` (`ClassReferenceKeyword.cs`), `struct_value_keyword.cs` (`StructValueKeyword.cs`), `record_semantic_keyword.cs` (`RecordSemanticKeyword.cs`)

* **`class`:** Reference type allocated on the Heap; supports inheritance and reference equality.
* **`struct`:** Lightweight value type allocated on the Stack (or inline); copies full data on assignment and does not support class inheritance.
* **`record`:** Specialized type (`record class` or `record struct`) designed for immutable data models, built-in **value-based equality**, and non-destructive mutation via `with` expressions:
```csharp
public record Product(int Id, string Name, decimal Price);
var discounted = originalProduct with { Price = 49.99m };
```

---

### Day-6: Polymorphism Core Keywords
* 📄 **Source Files:** `virtual_modifier_keyword.cs` (`VirtualModifierKeyword.cs`), `override_modifier_keyword.cs` (`OverrideModifierKeyword.cs`)

* **`virtual`:** Marks a base class method or property as eligible to be overridden by derived classes.
* **`override`:** Replaces or extends a `virtual` or `abstract` base member in a child class, enabling **runtime polymorphism**.
* **`new` (Method Hiding):** Hides a base class member with a separate implementation when accessed via the derived type reference.

---

### Day-7: Advanced Abstraction Contracts
* 📄 **Source Files:** `abstract_keyword.cs` (`AbstractKeyword.cs`), `interface_keyword.cs` (`InterfaceKeyword.cs`)

* **`abstract` Class:** An incomplete base class that cannot be instantiated directly (`new`). Can mix concrete implemented methods with unimplemented `abstract` methods that derived classes must override.
* **`interface`:** A pure behavioral contract defining methods, properties, events, or indexers without instance state fields. Classes and structs can implement multiple interfaces simultaneously.

---

## 📁 Week-3: Memory, Concurrency & Querying

* **Static vs. Instance Members:** `static` members belong to the type itself (shared globally); instance members belong to individual object instances.
* **`throw` vs. `throw ex`:** Always use bare `throw;` to preserve the original call stack trace; `throw ex;` overwrites the stack trace origin.
* **`Thread` vs. `Task`:** `Thread` wraps a heavy OS thread directly; `Task` schedules lightweight asynchronous work onto the managed `ThreadPool`.
* **`async` & `await`:** `async` enables asynchronous execution in a method; `await` suspends the method non-blockingly until the awaited `Task` completes.
* **`lock` vs. `Monitor`:** `lock (_obj)` provides clean mutual exclusion; `Monitor` exposes low-level timeout (`Monitor.TryEnter`) and thread signaling (`Wait`/`Pulse`).
* **Type Checking & Casting:**
  * `(TargetType)obj`: Explicit cast; throws `InvalidCastException` on mismatch.
  * `obj as TargetType`: Safe cast; returns `null` on mismatch (reference/nullable types only).
  * `obj is TargetType typedVar`: Pattern-matching type check.
* **`IEnumerable` vs. `IQueryable`:** `IEnumerable` filters collections in local application memory; `IQueryable` translates expression trees into remote database queries (e.g., SQL).

---

## 🔑 C# Reserved & Contextual Keywords Reference

* **Reserved Keywords:** Always reserved by the compiler (`int`, `class`, `public`, `return`, `void`, `if`, `switch`, etc.). Can only be used as identifiers if prefixed with `@` (e.g., `@class`).
* **Contextual Keywords:** Reserved only within specific language constructs (`get`, `set`, `init`, `value`, `var`, `dynamic`, `record`, `async`, `await`, `from`, `where`, `select`, `nameof`, `when`, `yield`, `with`).

# Phase 2: Intermediate C# Programming (`Phase_2_Intermediate`)

This master documentation serves as a comprehensive reference guide for core Object-Oriented Programming (OOP) principles, modern collection pipelines, defensive error handling, and LINQ data querying in C#.

---

## 📑 Table of Contents

1. [Week-3: Object-Oriented Programming (OOP)](#week-3-object-oriented-programming-oop)
   - [Day-1: Class Object & Constructor](#day-1-class-object--constructor)
   - [Day-2: Access Modifiers & Properties](#day-2-access-modifiers--properties)
   - [Day-3: Abstraction & Encapsulation](#day-3-abstraction--encapsulation)
   - [Day-4: Inheritance & Polymorphism](#day-4-inheritance--polymorphism)
   - [Day-5: Polymorphism Mechanics](#day-5-polymorphism-mechanics)
   - [Day-6: Advanced Abstraction](#day-6-advanced-abstraction)
   - [Day-7: Performance & Custom Types](#day-7-performance--custom-types)
2. [Week-4: Collections, Error Interruption, & LINQ](#week-4-collections-error-interruption--linq)
   - [Day-1: Memory Optimization & Null Safety](#day-1-memory-optimization--null-safety)
   - [Day-2: Dynamic Data Structures & Fast Lookups](#day-2-dynamic-data-structures--fast-lookups)
   - [Day-3: Linear Pipelines & Type Reusability](#day-3-linear-pipelines--type-reusability)
   - [Day-4: Defensive Error Handling & Custom Flags](#day-4-defensive-error-handling--custom-flags)
   - [Day-5: Function Pointers & Anonymous Inline Logic](#day-5-function-pointers--anonymous-inline-logic)
   - [Day-6: Collection Data Querying (LINQ)](#day-6-collection-data-querying-linq)
   - [Day-7: Enterprise Integration & Architecture Review](#day-7-enterprise-integration--architecture-review)

---

## 📁 Week-3: Object-Oriented Programming (OOP)

*(Note: Mapped directly to your `Phase_2_Intermediate / Week-3 Object-Oriented Programming (OOP)` folder structure, including recommended PascalCase file names in parentheses.)*

### Day-1: Class Object & Constructor
* **Solution Files:** `Classe_and_Objects.cs` *(Recommended: `ClassesAndObjects.cs`)*, `Constructors.cs`

In Object-Oriented Programming, classes and objects are fundamental concepts used to represent real-world concepts and entities.

* **Class:** A blueprint used to create objects with similar properties and behaviors.
* **Object:** An instance of a class allocated in memory.
* **Constructors:** Special methods automatically called when an object of the class is created. They share the exact name of the class, have no return type, and initialize the object's data members.
* **Constructor Overloading:** Defining multiple constructors within the same class using different parameter signatures.
* **Constraints:** Constructors cannot be `virtual` or `abstract`. Only a parameterless class-level constructor can be `static`.

#### Types of Constructors
1. **Default Constructor:** Takes no arguments. If omitted, the C# compiler automatically generates one that initializes fields to their standard default values.
2. **Parameterized Constructor:** Accepts one or more parameters to initialize an object's fields with custom values upon instantiation.
3. **Copy Constructor:** Initializes a new object instance by copying the member values from an existing object of the same class.
4. **Private Constructor:** Marked with `private` to prevent external classes from instantiating the class directly (commonly used in Singleton patterns and static utility classes).
5. **Static Constructor:** A special class-level constructor used to initialize `static` fields or execute one-time setup logic before the first instance is created or any static member is accessed.

```csharp
public class Employee
{
    public string Name { get; set; }
    public static string CompanyName;

    // 1. Static Constructor (runs once per type)
    static Employee()
    {
        CompanyName = "TechCorp Global";
    }

    // 2. Default Constructor
    public Employee()
    {
        Name = "Unassigned";
    }

    // 3. Parameterized Constructor
    public Employee(string name)
    {
        Name = name;
    }

    // 4. Copy Constructor
    public Employee(Employee existingEmployee)
    {
        Name = existingEmployee.Name;
    }
}
```

---

### Day-2: Access Modifiers & Properties
* **Solution Files:** `Access_Modifiers.cs` *(Recommended: `AccessModifiers.cs`)*, `Properties.cs`

Encapsulation isolates data implementation details to protect objects from unintended external interference.

* **Access Modifiers:** Keywords that establish visibility and accessibility boundary rules across code files and compiled assemblies:
  * **`public`:** Exposed with zero restrictions; accessible by any external class, assembly, or project.
  * **`private`:** Completely restricted; visible and modifiable only within the declaring class.
  * **`protected`:** Accessible within the declaring class and inherited by derived child classes.
  * **`internal`:** Accessible only by classes compiled inside the exact same assembly project.
  * **`protected internal`:** Accessible anywhere within the same assembly project, OR by derived child classes located in external assemblies.
  * **`private protected`:** Accessible strictly within the declaring class and derived child classes located inside the exact same assembly project.
* **Properties (Encapsulation):** Language wrappers that shield private backing fields from direct mutation while exposing them safely:
  * **Getters (`get`):** Executed when the property is read, allowing values to be computed or formatted before leaving the object.
  * **Setters (`set`):** Executed when data is written, enforcing validation rules to prevent invalid states.

```csharp
public class BankAccount
{
    private decimal _balance;

    public decimal Balance
    {
        get => _balance;
        private set
        {
            if (value >= 0)
            {
                _balance = value;
            }
        }
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0) Balance += amount;
    }
}
```

---

### Day-3: Abstraction & Encapsulation
* **Solution Files:** `Abstraction.cs`, `Encapsulation.cs`

* **Encapsulation (Data Hiding):** Bundling data (fields) and methods into a single unit while restricting direct operational access to internal states, ensuring objects remain sovereign over their own data integrity.
* **Abstraction:** The strategic architectural practice of hiding complex background implementation mechanics and exposing only clean, essential functionality contracts to the caller.

---

### Day-4: Inheritance & Polymorphism
* **Solution Files:** `Inheritance.cs`, `Polymorphism.cs`

* **Inheritance:** A mechanism where a derived child class acquires the non-private fields, properties, and methods of a base parent class using the `:` syntax. Promotes code reuse and allows invoking parent constructors via `base()`.
* **Polymorphism Foundations:** Designing structural hierarchies that allow diverse derived objects to be stored and processed uniformly through a shared base class or interface reference.

```csharp
public class Vehicle
{
    public string Brand { get; }
    public Vehicle(string brand) => Brand = brand;
    public virtual void Drive() => Console.WriteLine($"{Brand} vehicle is moving.");
}

public class ElectricCar : Vehicle
{
    public ElectricCar(string brand) : base(brand) { }
    public override void Drive() => Console.WriteLine($"{Brand} electric car is gliding silently.");
}
```

---

### Day-5: Polymorphism Mechanics
* **Solution Files:** `Method_Overloading.cs` *(Recommended: `MethodOverloading.cs`)*, `Method_Overriding.cs` *(Recommended: `MethodOverriding.cs`)*

Polymorphism enables objects to take multiple behavioral forms at compile time and runtime.

* **Method Overloading (Compile-Time Polymorphism):** Defining multiple methods within the same class sharing the same name but having distinct parameter signatures (different parameter counts, types, or order). Resolved by the compiler.
* **Method Overriding (Runtime Polymorphism):** Replacing or extending the implementation of a parent `virtual` or `abstract` method in a derived class using `override`. Resolved at runtime based on the actual object instance type rather than the reference variable type.

---

### Day-6: Advanced Abstraction
* **Solution Files:** `Abstract_Class.cs` *(Recommended: `AbstractClass.cs`)*, `Interface_Basic.cs` *(Recommended: `InterfaceBasic.cs`)*

* **Abstract Classes:** Incomplete architectural templates declared with `abstract`. They cannot be instantiated directly with `new` and can contain both fully implemented methods and unimplemented `abstract` method signatures that child classes must override.
* **Interfaces & Explicit Binding:** Pure functional contracts (`interface`) that decouple *what* a component does from *how* it does it. Supports multiple interface inheritance and **explicit interface implementation** (`void IFirst.Execute()`) to resolve method signature collisions cleanly.

---

### Day-7: Performance & Custom Types
* **Solution Files:** `Static_and_Synthesis.cs` *(Recommended: `StaticAndSynthesis.cs`)*, `Structs_and_Enums.cs` *(Recommended: `StructsAndEnums.cs`)*

* **Structs (`struct`):** Lightweight value-type structures typically allocated on the Stack where assignment copies the raw data directly rather than a memory reference.
* **Enums (`enum`):** Strongly-typed named integer constant blocks that replace arbitrary magic numbers or error-prone strings.
* **Static Members (`static`):** Fields and methods tied directly to the class definition itself rather than individual object instances.
* **Consolidation Challenge:** Synthesizing encapsulated classes, inheritance hierarchies, interfaces, enums, and static configurations into a unified console application.

---

## 📁 Week-4: Collections, Error Interruption, & LINQ

*(Note: Mapped to the second week of `Phase_2_Intermediate`, covering modern collection pipelines, defensive safety operations, and declarative data querying.)*

### Day-1: Memory Optimization & Null Safety
* **StringBuilder (Memory Tuning):**
  * **String Immutability Pitfall:** Standard `string` objects are immutable. Repeated concatenation inside loops allocates new Heap objects on every iteration, creating heavy Garbage Collector pressure.
  * **StringBuilder Utility:** A mutable character buffer (`System.Text.StringBuilder`) that modifies text in place without allocating intermediate string copies.
* **Null Safety Infrastructure:**
  * **Nullable Value Types (`T?`):** Allows value types (e.g., `int?`, `bool?`) to represent an unassigned `null` state.
  * **Null-Conditional Operator (`?.`):** Short-circuits member access and returns `null` immediately if the target instance is `null`, preventing `NullReferenceException`.
  * **Null-Coalescing Operator (`??`):** Evaluates the left operand and returns a fallback default value if it is `null`.

```csharp
using System.Text;

var sb = new StringBuilder();
for (int i = 0; i < 100; i++)
{
    sb.Append($"Item-{i} ");
}

string? rawInput = null;
int length = rawInput?.Length ?? 0; // Evaluates safely to 0
```

---

### Day-2: Dynamic Data Structures & Fast Lookups
* **Dynamic Arrays (`List<T>`):** Strongly-typed, auto-resizing sequential collection backed by an internal contiguous array that expands dynamically as items are added or removed.
* **Key-Value Hashes (`Dictionary<TKey, TValue>`):** Hash-table collection storing unique keys mapped to values, delivering near-instantaneous $O(1)$ average-time lookups, insertions, and deletions.

---

### Day-3: Linear Pipelines & Type Reusability
* **Linear Processing Streams:**
  * **`Queue<T>`:** Enforces **FIFO** (First-In, First-Out) processing using `.Enqueue()` and `.Dequeue()`. Ideal for background job queues and message pipelines.
  * **`Stack<T>`:** Enforces **LIFO** (Last-In, First-Out) processing using `.Push()` and `.Pop()`. Ideal for undo/redo histories and expression parsing.
* **Generic Architecture (`<T>`):** Parameterizes classes, interfaces, and methods with type placeholders (`T`), enabling code reuse across distinct types with full compile-time type safety and zero value-type boxing overhead.

---

### Day-4: Defensive Error Handling & Custom Flags
* **Exception Lifecycle Management:**
  * **`try`:** Wraps code blocks that may throw runtime exceptions (e.g., file I/O, network calls, parsing).
  * **`catch`:** Intercepts specific exception types to log diagnostics, recover gracefully, or translate errors.
  * **`finally`:** Executes unconditionally whether an exception occurred or not, ensuring deterministic cleanup of open handles and resources.
* **Custom Application Flags:** Defining domain-specific exception classes inheriting from `System.Exception` to enforce business rule validation cleanly.

```csharp
public class InsufficientFundsException : Exception
{
    public InsufficientFundsException(string message) : base(message) { }
}
```

---

### Day-5: Function Pointers & Anonymous Inline Logic
* **Type-Safe Function Pointers (`delegate`, `Action`, `Func`, `Predicate`):** Encapsulate method signatures into first-class variables that can be passed as callbacks or stored in event pipelines.
* **Anonymous Inline Logic (Lambdas `=>`):** Concise, inline anonymous functions (`x => x * 2`) used to pass custom logic directly into methods without declaring separate named methods.

---

### Day-6: Collection Data Querying (LINQ)
Language Integrated Query (LINQ) provides a unified syntax for filtering, sorting, and projecting data collections without manual loop boilerplate.

* **Fluent Method Syntax:** Chains extension methods powered by lambda expressions (`.Where()`, `.OrderBy()`, `.Select()`, `.GroupBy()`).
* **Declarative Query Syntax:** Uses readable SQL-like clauses (`from`, `where`, `orderby`, `select`) compiled directly into standard LINQ method calls.

```csharp
var numbers = new List<int> { 12, 5, 28, 3, 19 };

// Fluent Method Syntax
var highFluent = numbers
    .Where(n => n > 10)
    .OrderByDescending(n => n)
    .Select(n => $"Value: {n}");

// Declarative Query Syntax
var highQuery = from n in numbers
                where n > 10
                orderby n descending
                select $"Value: {n}";
```

---

### Day-7: Enterprise Integration & Architecture Review
* **Advanced Production Capstone:** Combining encapsulated domain models, generic `Dictionary<TKey, TValue>` lookups, custom exception guards, `StringBuilder` report formatting, and fluent LINQ queries into a cohesive dashboard application.
* **Architectural Cleanup Audit:** Reviewing code against enterprise standards—flattening deep nesting, eliminating redundant loops with LINQ, verifying null-safety boundaries, and ensuring clean separation of concerns.

# 📙 Phase 3: Advanced C# Programming (`Phase_3_Advanced`)

This master documentation serves as a comprehensive reference guide for enterprise asynchronous design, thread synchronization, resource lifecycles, metaprogramming, and performance-tuned data processing structures.

---

## 📑 Table of Contents

* [Week 1: Asynchrony, Concurrency, & Core Communication](#week-1-asynchrony-concurrency--core-communication)
  * [Day 1: Async Non-Blocking Foundations](#day-1-async-non-blocking-foundations)
  * [Day 2: Concurrent Multi-Threading](#day-2-concurrent-multi-threading)
  * [Day 3: Component Communication Engines](#day-3-component-communication-engines)
  * [Day 4: Safe Notifications & Exception Interception](#day-4-safe-notifications--exception-interception)
  * [Day 5: Explicit Resource & Memory Cleanup](#day-5-explicit-resource--memory-cleanup)
  * [Day 6: Performance Optimization Types](#day-6-performance-optimization-types)
  * [Day 7: Asynchronous Systems Consolidation](#day-7-asynchronous-systems-consolidation)
* [Week 2: Enterprise Architecture, Metaprogramming, & Extensibility](#week-2-enterprise-architecture-metaprogramming--extensibility)
  * [Day 1: Advanced Data Iterators](#day-1-advanced-data-iterators)
  * [Day 2: Dynamic Programming Extensions](#day-2-dynamic-programming-extensions)
  * [Day 3: Metaprogramming & Runtime Blueprint Analysis](#day-3-metaprogramming--runtime-blueprint-analysis)
  * [Day 4: File Pipelines & Object Serialization](#day-4-file-pipelines--object-serialization)
  * [Day 5: Enterprise Exception Pipelines](#day-5-enterprise-exception-pipelines)

---

## 📁 Week 1: Asynchrony, Concurrency, & Core Communication

### Day 1: Async Non-Blocking Foundations
Writing non-blocking operations to keep user interfaces responsive and optimize system throughput.

* **`async_await_basics.cs` *(Recommended: `AsyncAwaitBasics.cs`)* — Async and Await Architecture:**
  * **Asynchronous Programming:** Bypasses sequential execution locks. The `async` keyword allows methods to execute operations without tying up the calling thread, returning control instantly.
  * **Await Execution:** The `await` keyword pauses method execution non-blockingly until the awaited task finishes, automatically resuming on the original runtime context when complete.

```csharp
using System;
using System.Net.Http;
using System.Threading.Tasks;

public class AsyncBasicsDemo
{
    public async Task FetchPageLengthAsync(string url)
    {
        using HttpClient client = new HttpClient();
        string content = await client.GetStringAsync(url);
        Console.WriteLine($"Downloaded {content.Length} characters.");
    }
}
```

* **`task_return_types.cs` *(Recommended: `TaskReturnTypes.cs`)* — `Task`, `Task<T>`, and `ValueTask` Operations:**
  * **`Task`:** Represents an ongoing background operation that does not return a value (equivalent to an asynchronous `void`).
  * **`Task<T>`:** Represents a background operation that eventually yields a specific value of type `T`.
  * **`ValueTask<T>`:** A high-performance, stack-allocated alternative structure to `Task<T>`. It avoids heap allocation costs when a method completes synchronously or retrieves cached data.

```csharp
using System.Threading.Tasks;

public class ReturnTypesDemo
{
    private string? _cachedToken = "XYZ-123";

    public ValueTask<string> GetAuthTokenAsync()
    {
        // Zero heap allocation when returning synchronously from cache
        if (_cachedToken != null)
        {
            return new ValueTask<string>(_cachedToken);
        }

        return new ValueTask<string>(FetchTokenFromServerAsync());
    }

    private async Task<string> FetchTokenFromServerAsync()
    {
        await Task.Delay(500);
        return "NEW-TOKEN-999";
    }
}
```

---

### Day 2: Concurrent Multi-Threading
Distributing intensive algorithmic processes across hardware resources while protecting data states.

* **`parallel_library_processing.cs` *(Recommended: `ParallelLibraryProcessing.cs`)* — Task Parallel Library (TPL):**
  * **Data Parallelism:** Uses `Parallel.For` and `Parallel.ForEach` to automatically partition data arrays and split loop steps across all available physical CPU cores simultaneously.

```csharp
using System;
using System.Threading.Tasks;

public class ParallelDemo
{
    public void ProcessBatch(int[] items)
    {
        Parallel.ForEach(items, item =>
        {
            Console.WriteLine($"Processing {item} on Thread {Environment.CurrentManagedThreadId}");
        });
    }
}
```

* **`thread_safety_locks.cs` *(Recommended: `ThreadSafetyLocks.cs`)* — Thread Synchronization (Race Conditions):**
  * **Race Conditions:** Occur when multiple background threads mutate a single shared variable simultaneously, leading to hidden data corruption.
  * **Lock Statement Primitive (`lock`):** Marks a code block as a protected critical section using a mutual exclusion synchronization object. Only one thread can enter the block at a time, forcing other threads to wait in line.

```csharp
public class SafeCounter
{
    private readonly object _lockPadlock = new object();
    private int _count = 0;

    public void Increment()
    {
        lock (_lockPadlock)
        {
            _count++;
        }
    }
}
```

---

### Day 3: Component Communication Engines
Building decoupled notification systems where components react to structural state changes.

* **`event_publisher_subscriber.cs` *(Recommended: `EventPublisherSubscriber.cs`)* — Publisher-Subscriber Decoupling:**
  * **Events Pattern:** A pattern where a class (Publisher) fires a notification message trigger and external listening classes (Subscribers) receive and process the update without the publisher knowing who they are.
* **`event_handler_pattern.cs` *(Recommended: `EventHandlerPattern.cs`)* — Standard System Design Benchmarks:**
  * **`EventHandler`:** The unified, standard Microsoft system design structure designed for zero-data notification signals.
  * **`EventHandler<TEventArgs>`:** A generic design pattern that accepts a custom data payload class inheriting from `System.EventArgs`, shipping transactional metadata variables safely along with the broadcast notification.

```csharp
using System;

public class OrderEventArgs : EventArgs
{
    public string OrderId { get; }
    public OrderEventArgs(string orderId) => OrderId = orderId;
}

public class OrderService
{
    public event EventHandler<OrderEventArgs>? OrderPlaced;

    public void PlaceOrder(string orderId)
    {
        OrderPlaced?.Invoke(this, new OrderEventArgs(orderId));
    }
}
```

---

### Day 4: Safe Notifications & Exception Interception
Defending messaging paths from unexpected runtime thread disruptions.

* **`null_conditional_broadcasting.cs` *(Recommended: `NullConditionalBroadcasting.cs`)* — Thread-Safe Event Invocations:**
  * **Null-Broadcast Crash Vulnerability:** Triggering an event that has zero active subscribers causes a fatal `NullReferenceException`.
  * **Null-Conditional Operator (`?.`):** Protects the invocation line safely (`MyEvent?.Invoke(this, EventArgs.Empty)`), checking for listeners immediately before execution.
* **`invocation_list_interception.cs` *(Recommended: `InvocationListInterception.cs`)* — Exception Handling inside Multicast Chains:**
  * **Chained Exceptions Vulnerability:** Standard multicast event triggers execute matching listeners sequentially. If one listener crashes mid-run, the remaining listeners are skipped entirely.
  * **Manual Invocation Processing:** Using `.GetInvocationList()` to fetch every individual delegate observer object in the chain, allowing you to wrap each callback inside its own isolated `try-catch` block so one failure cannot bring down the entire system.

```csharp
using System;

public class SafeBroadcaster
{
    public event EventHandler? OnBroadcast;

    public void BroadcastSafely()
    {
        if (OnBroadcast == null) return;

        foreach (EventHandler subscriber in OnBroadcast.GetInvocationList())
        {
            try
            {
                subscriber.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Subscriber failed safely without stopping chain: {ex.Message}");
            }
        }
    }
}
```

---

### Day 5: Explicit Resource & Memory Cleanup
Managing external system handles, file locks, and high-frequency allocations to maintain stability.

* **`idisposable_pattern.cs` *(Recommended: `IDisposablePattern.cs`)* — Unmanaged Resource Lifecycle Management:**
  * **`IDisposable` Interface:** Enforces the implementation of the `Dispose()` method. Used to manually release unmanaged system resources like file streams, database connections, graphic handles, and network sockets that the automatic Garbage Collector cannot track.
* **`using_statements_context.cs` *(Recommended: `UsingStatementsContext.cs`)* — Deterministic Variable Scoping:**
  * **Using Block Syntax:** Automatically converts code blocks into an implicit `try-finally` sequence behind the scenes. This guarantees that `Dispose()` fires immediately when the object falls out of scope, even if the application throws a critical error.

```csharp
using System;
using System.IO;

public class ResourceManagerDemo
{
    public void WriteLog(string path, string text)
    {
        using (StreamWriter writer = new StreamWriter(path, append: true))
        {
            writer.WriteLine(text);
        } // writer.Dispose() is guaranteed to execute here
    }
}
```

---

### Day 6: Performance Optimization Types
Utilizing allocation-free types and modern thread-safe data models.

* **`record_types_immutability.cs` *(Recommended: `RecordTypesImmutability.cs`)* — Immutable Reference Configurations (`record`):**
  * **Record Utility:** A lightweight type that defaults to absolute state immutability. Unlike standard classes that match objects by their memory address reference, records implement value-based equality out-of-the-box (matching by field values).
* **`memory_span_allocation.cs` *(Recommended: `MemorySpanAllocation.cs`)* — High-Speed Allocation-Free Chunks (`Span<T>`):**
  * **`Span<T>` / `ReadOnlySpan<T>`:** Contiguous views of arbitrary memory partitions (stack, heap, or unmanaged space). They allow text manipulation, array slicing, and parsing loops to execute without creating new heap objects, drastically reducing garbage collector pressure.

```csharp
using System;

public class SpanParsingDemo
{
    public int ExtractYear(ReadOnlySpan<char> isoDate)
    {
        // Slices the first 4 characters without allocating a new string on the heap
        ReadOnlySpan<char> yearSlice = isoDate.Slice(0, 4);
        return int.Parse(yearSlice);
    }
}
```

---

### Day 7: Asynchronous Systems Consolidation
Fusing async loops, thread locks, and notification patterns into a concurrent engine.

* **`async_telemetry_downloader.cs` *(Recommended: `AsyncTelemetryDownloader.cs`)* — Concurrent Telemetry Capstone (Part 1):**
  * **Synthesis App Part 1:** Constructing a multi-threaded web tracking processor that queries multiple mock data sources concurrently (`Task.WhenAll`), maps responses across thread paths, applies safe lock blocks, and fires standard event alerts across layers.
* **`week_1_performance_audit.cs` *(Recommended: `Week1PerformanceAudit.cs`)* — Memory and Structural Profiling:**
  * **Auditing Benchmarks:** Profiling task completion lifecycles, evaluating lock contention delays, and auditing component scopes to ensure all structural files meet rigorous performance standards.

---

## 📁 Week 2: Enterprise Architecture, Metaprogramming, & Extensibility

### Day 1: Advanced Data Iterators
Streaming massive sequence rows efficiently without exhausting available system memory pools.

* **`yield_return_streams.cs` *(Recommended: `YieldReturnStreams.cs`)* — Stateful Lazy Iteration Logic:**
  * **`yield return`:** Instructs the compiler to automatically build a state machine under the hood. It returns collection elements one by one, custom-tailored for streaming high-volume database entries without loading massive datasets into system RAM all at once.

```csharp
using System.Collections.Generic;

public class StreamIteratorDemo
{
    public IEnumerable<int> GenerateSequence(int count)
    {
        for (int i = 0; i < count; i++)
        {
            yield return i; // Yields one item at a time lazily
        }
    }
}
```

* **`custom_enumerators.cs` *(Recommended: `CustomEnumerators.cs`)* — Custom `IEnumerable` Mechanics:**
  * **Iteration Engine Customization:** Manually implementing the `IEnumerable` interface and overriding underlying structural collection behaviors to build unique, customized sorting or traversal behaviors directly into domain data structures.

---

### Day 2: Dynamic Programming Extensions
Extending class behaviors and safely managing loose runtime types.

* **`extension_methods.cs` *(Recommended: `ExtensionMethods.cs`)* — Sealed Object Decoupled Decoration:**
  * **Extension Methods:** Injecting new custom operations directly into existing classes (even sealed system types like `string` or `int`) without modifying their original source files, using `static` methods and the `this` parameter prefix keyword.

```csharp
public static class StringExtensions
{
    public static bool IsNullOrEmptyCustom(this string? value)
    {
        return string.IsNullOrEmpty(value);
    }
}
```

* **`dynamic_keyword_runtime.cs` *(Recommended: `DynamicKeywordRuntime.cs`)* — Late-Bound Structural Processing:**
  * **Dynamic Utility (`dynamic`):** Bypasses strict static compiler checking entirely, deferring type evaluation until runtime execution. Highly effective for integrating with loose JSON objects, COM interoperability layers, and complex dynamic configuration files.

---

### Day 3: Metaprogramming & Runtime Blueprint Analysis
Inspecting component structures at runtime and parsing user annotation attributes.

* **`reflection_basics.cs` *(Recommended: `ReflectionBasics.cs`)* — Runtime Assembly Structure Metadata Parsing:**
  * **Reflection:** Code that reads its own compiled binary assembly files dynamically at runtime to extract metadata about methods, namespaces, classes, fields, and constructors.
* **`custom_attributes_tags.cs` *(Recommended: `CustomAttributesTags.cs`)* — Declarative Metadata Annotation Marking:**
  * **Attributes (`[Attribute]`):** Custom inline metadata tags attached directly to elements (classes, properties). Combined with reflection, they allow you to build automated serialization and validation frameworks.

```csharp
using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property)]
public class AuditTagAttribute : Attribute
{
    public string Description { get; }
    public AuditTagAttribute(string description) => Description = description;
}

[AuditTag("Core Customer Entity")]
public class CustomerRecord { }
```

---

### Day 4: File Pipelines & Object Serialization
Persisting running application objects securely onto hardware storage disks.

* **`file_streams_io.cs` *(Recommended: `FileStreamsIO.cs`)* — Asynchronous I/O Memory Buffering:**
  * **Streams Processing:** Reading and writing large raw data sets in chunks using asynchronous byte streams (`FileStream`, `StreamReader`, `StreamWriter`), keeping disk operations out of memory blocks to avoid scaling limitations.
* **`json_serialization_engine.cs` *(Recommended: `JsonSerializationEngine.cs`)* — Runtime Object Transformation Filters:**
  * **Serialization:** Parsing complex object states directly into standard text-based JSON lines (`System.Text.Json.JsonSerializer`) for cross-platform network shipping.
  * **Deserialization:** Converting incoming raw text streams back into strongly-typed C# object instances.

```csharp
using System.Text.Json;

public record TelemetryPayload(string SensorId, double Value);

public class JsonDemo
{
    public string SerializePayload(TelemetryPayload payload) =>
        JsonSerializer.Serialize(payload);

    public TelemetryPayload? DeserializePayload(string json) =>
        JsonSerializer.Deserialize<TelemetryPayload>(json);
}
```

---

### Day 5: Enterprise Exception Pipelines
Managing distributed runtime errors across concurrent environments.

* **`exception_filters_when.cs` *(Recommended: `ExceptionFiltersWhen.cs`)* — Conditional Pattern Interception Filters:**
  * **Exception Filters (`when`):** Allows `catch` blocks to evaluate a boolean condition *before* unwinding the stack. If the condition returns `false`, the runtime continues searching for another matching `catch` block without altering the original exception stack trace.

```csharp
using System;
using System.Net.Http;

public class ExceptionFilterDemo
{
    public void HandleRequest()
    {
        try
        {
            throw new HttpRequestException("Service Unavailable", null, System.Net.HttpStatusCode.ServiceUnavailable);
        }
        catch (HttpRequestException ex) when (ex.StatusCode == System.Net.HttpStatusCode.ServiceUnavailable)
        {
            Console.WriteLine("Caught transient 503 error specifically for retry logic.");
        }
    }
}
```

# C# Learning Syllabus

## Module 1: Fundamentals (2-3 weeks)
### Week 1: Basic Syntax and Data Types
- Development environment setup
- **Basic program structure**
  - **Top-level statements**: 
  - **Program's entry point**: điểm bắt đầu và kết thúc của 1 C# program khi được khởi chạy (thường là **static void Main()**, trong Unity là **Awake()** và **Start()**)
  - **Command-line arguments**: 
  
- Variables and data types (`int`, `string`, `bool`, etc.)
  - variable - constant, constructs
  - Type conversion
  - Mutation: In programming, "mutation" means changing the state of an object (its properties or data). 
  - Destructive Mutation: This is the traditional way of modifying objects. You change the object's properties directly, altering its original state. 
  - Nondestructive Mutation: Instead of changing the original object, you create a new object with the desired modifications. The original object remains unchanged.
- Type inference with `var`
- Constants with `const`
- Basic operators

### Week 2: Control Flow
- `if`, `else` statements
- `switch` statements
- Loops (`for`, `while`, `do-while`)
- `break`, `continue`
- Basic error handling with `try-catch`
- **Project**: Number guessing game

### Week 3: Methods and Arrays
- Method declaration and parameters
- Return types and `void`
- Method overloading
- Arrays and basic collections
- `foreach` loops
- **Project**: Array manipulation utility

## Module 2: Object-Oriented Programming (4 weeks)
### Week 4: Classes and Objects
- Class structure
- `public`, `private`, `protected`
- Properties and fields
- Constructors
- `this` keyword
- **Project**: Student management system

### Week 5: Inheritance and Polymorphism
- Inheritance basics
- `virtual` and `override`
- Abstract classes with `abstract`
- Method hiding with `new`
- `base` keyword
- **Project**: Shape hierarchy system

### Week 6: Interfaces and Advanced OOP
- Interface declaration and implementation
- Multiple interfaces
- `is` and `as` operators
- Polymorphic interfaces
- **Project**: Plugin system

### Week 7: Advanced Class Concepts
- Static members with `static`
- Extension methods
- Partial classes
- Nested classes
- **Project**: Mathematics library

## Module 3: Memory Management and Advanced Features (3 weeks)
### Week 8: Memory Management
- Value vs Reference types
- Garbage collection
- `using` statements
- IDisposable pattern
- **Project**: Resource management system

### Week 9: Generics and Collections
- Generic classes and methods
- Generic constraints with `where`
- Collection interfaces
- Generic collections
- **Project**: Custom generic collection

### Week 10: Delegates and Events
- Delegate declaration
- Event handling
- Lambda expressions
- Anonymous methods
- **Project**: Event-driven application

## Module 4: Modern C# Features (3 weeks)
### Week 11: LINQ
- LINQ syntax
- Query expressions
- Method syntax
- LINQ operators
- **Project**: Data analysis tool

### Week 12: Asynchronous Programming
- `async` and `await`
- Task Parallel Library
- Async patterns
- Exception handling in async code
- **Project**: Async file processor

### Week 13: Advanced Modern Features
- Pattern matching
- Records
- Nullable reference types
- Switch expressions
- **Project**: Modern C# showcase application

## Module 5: Professional Development (4 weeks)
### Week 14: Error Handling and Logging
- Exception handling patterns
- Custom exceptions
- Logging frameworks
- Debugging techniques
- **Project**: Logging system

### Week 15: Testing
- Unit testing basics
- Test-driven development
- Mocking
- Integration testing
- **Project**: Test suite for previous projects

### Week 16: Design Patterns
- Common design patterns
- SOLID principles
- Clean code practices
- Code organization
- **Project**: Design pattern implementation

### Week 17: Real-World Application
- Final project incorporating all concepts
- Code review practices
- Performance optimization
- Documentation
- **Project**: Full-scale application

## Learning Resources
1. Documentation:
    - Microsoft C# Documentation
    - .NET API Browser
    - C# Language Specification

2. Practice Platforms:
    - LeetCode
    - HackerRank
    - Exercism.io (C# track)

3. Tools:
    - Visual Studio
    - Visual Studio Code
    - ReSharper/Rider
    - GitHub

## Study Tips
1. Code daily (minimum 1-2 hours)
2. Build projects beyond the syllabus requirements
3. Read other developers' code on GitHub
4. Participate in code reviews
5. Join C# community forums
6. Watch conference talks and coding tutorials

## Assessment Methods
1. Weekly coding exercises
2. Module projects
3. Code reviews
4. Technical writing exercises
5. Final project presentation

## Progression Markers
- Basic: Complete Modules 1-2
- Intermediate: Complete Modules 1-3
- Advanced: Complete Modules 1-4
- Professional: Complete all Modules

Each module builds upon the previous ones, so ensure thorough understanding before moving forward.


# Week 1: Advanced Object-Oriented Programming & Design Patterns

Lectures: Deep dive into OOP principles (polymorphism, encapsulation, inheritance), SOLID principles, common design patterns (Singleton, Factory, Observer, Strategy), and their application in game development (e.g., managing game objects, AI).

Exercises: Implementing design patterns in C#, refactoring existing code to improve design.

Assignment: Design and implement a simple game system using a chosen design pattern (e.g., a state machine for enemy AI).

# Week 2: Memory Management & Performance Optimization

Lectures: Garbage collection in C#, memory leaks, profiling tools, optimization techniques (e.g., object pooling, reducing allocations), understanding the impact of memory management on game performance.

Exercises: Profiling a simple game, identifying performance bottlenecks, implementing optimization strategies.

Assignment: Optimize a given game segment to improve performance (e.g., reduce frame time).

# Week 3: Multithreading & Concurrency

Lectures: Threads, tasks, async/await, parallel programming, thread safety, race conditions, deadlocks, using concurrent collections.

Exercises: Implementing multithreaded game logic (e.g., background loading, AI processing).

Assignment: Develop a multithreaded system for a specific game task (e.g., loading assets concurrently).

# Week 4: Delegates, Events, and Lambda Expressions
## Delegate
Delegate là 1 dạng **reference to a method**, nó là 1 con trỏ để trỏ tới 1 đoạn mã 

Delegate cung cấp cơ chế **late binding** trong .NET. Late Binding means that you create an algorithm where the caller also supplies at least one method that implements part of the algorithm.
In C#, a delegate is a type that represents a reference to a method. It's essentially a type-safe function pointer. You define a delegate with a specific signature (return type and parameters), and then you can create instances of that delegate that point to methods matching that signature.

**Ưu điểm**
- **Event Handling**: Delegates là nền tảng của cơ chế **event handling** trong C# - events cho phép object A thông báo tới các objects khác khi có 1 điều gì đó xảy ra
- **Callback Functions**: Delegates enable callback functionality. You can pass a delegate to a method, and that method can then call the delegate at a later time, effectively allowing you to customize its behavior. **Callback function** is a function passed as an argument to another function. It's invoked by the called function at some point to perform a specific task.
- **Flexibility and Extensibility**: Delegates make your code more flexible and extensible. You can change the behavior of a part of your program without modifying its core logic by simply changing the delegate instance it uses. 
- **Asynchronous Programming**: Delegates are used extensively in asynchronous programming to represent methods that will be executed when an asynchronous operation completes.
- **Functional Programming Paradigms**: Delegates support functional programming paradigms like passing functions as arguments to other functions (higher-order functions).
- **Decoupling**: Delegates promote decoupling between components. One component can call methods in another component without needing a direct reference to that component, as long as it has a delegate to the appropriate method.

**Nhược điểm**:
- **Slight Performance Overhead**: Calling a method through a delegate involves a small performance overhead compared to a direct method call. However, this overhead is usually negligible in most applications.
- **Can Increase Complexity (if overused)**: Overuse of delegates can sometimes make code harder to understand, especially if the delegate chains become long or complex. It's important to use delegates judiciously.
- **Memory Management (for multicast delegates)**: Multicast delegates (delegates that hold references to multiple methods) require some memory management. If you add and remove methods from a multicast delegate frequently, you might need to be mindful of potential memory leaks (though this is less of a concern with modern garbage collection).
- **Debugging Can Be Slightly More Complex**: Debugging code that uses delegates can sometimes be slightly more complex because you need to trace the execution flow through the delegate chain.

**Khi nào thì dùng delegate**:
- **Event handling**: The most common use case.
- **Callbacks**: When you need to pass a piece of functionality to another method.
- **Asynchronous operations**: To handle completion or progress updates.
- **Customizing algorithms or behavior**: To allow users of your code to inject their own logic.
- **Implementing design patterns**: Many design patterns, such as Observer, Strategy, and Command, rely on delegates.

Lectures: Advanced usage of delegates and events for event-driven programming, lambda expressions for concise code, functional programming concepts in C#.

Exercises: Implementing event-driven systems in a game (e.g., player input, collision detection).

Assignment: Create a custom event system for a game feature (e.g., triggering animations).

# Week 5: LINQ (Language Integrated Query)

Lectures: Using LINQ for data manipulation and querying, efficient data processing, working with different data sources.

Exercises: Using LINQ to query game data (e.g., finding enemies within a certain range).

Assignment: Implement a data-driven system using LINQ (e.g., loading game levels from a database).

# Week 6: Generics and Collections

Lectures: Advanced generics, custom generic classes and methods, efficient use of collections (List, Dictionary, HashSet), understanding collection performance characteristics.

Exercises: Implementing custom generic data structures for game objects.

Assignment: Develop a generic inventory system for a game.

# Week 7: Reflection and Serialization

Lectures: Reflection: inspecting and manipulating types at runtime, serialization: saving and loading game data, JSON serialization, binary serialization.

Exercises: Using reflection to inspect game objects, implementing a system for saving and loading game state.

Assignment: Create a system to save and load game progress using JSON serialization.

# Week 8: Networking Fundamentals (Optional: Choose one focus)

Option A (Unity): Unity's networking features (UNET or Mirror), client-server architecture, handling network messages.

Option B (Unreal Engine): Unreal Engine's networking system, replication, handling network latency.

Exercises: Implementing basic network functionality in chosen engine.

Assignment: Create a simple multiplayer game feature (e.g., a chat system).

# Week 9: Advanced Game Engine Integration (Specific to chosen engine)

Lectures: Deep dive into chosen engine's API, advanced scripting techniques, optimizing performance within the engine.

Exercises: Implementing complex game mechanics using engine features.

Assignment: Develop a significant game feature using advanced engine capabilities.

# Week 10: Project Presentation & Review

Lectures: Code review best practices, presentation skills.

Exercises: Peer code review.

Assignment: Present a final project showcasing learned skills. This could be a small complete game or a significant feature for a larger game.

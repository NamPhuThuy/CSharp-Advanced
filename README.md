# C--Advanced

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

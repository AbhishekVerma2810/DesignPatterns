# Factory Method Design Pattern

## Overview

The Factory Method pattern is a Creational Design Pattern that provides an interface for creating objects in a superclass but allows subclasses to alter the type of objects that will be created. This promotes loose coupling by delegating object creation to subclasses instead of directly instantiating objects in the client code.

## Key Features:

- **Encapsulates Object Creation** – Hides the object creation logic from the client.

- **Supports Open/Closed Principle** – New product types can be added without modifying existing client code.

- **Promotes Loose Coupling** – The client depends on an interface rather than a concrete class.

## Real-World Analogy

Consider a logging system where logs can be written to different mediums like console logs or file logs. Instead of directly instantiating ConsoleLogger or FileLogger, the Factory Method ensures that we use a LoggerFactory to decide which implementation to create dynamically.
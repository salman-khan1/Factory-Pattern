# Factory Pattern in C#

A simple implementation of the **Factory Design Pattern** in C#. This project demonstrates how to centralize object creation, making your code more flexible, maintainable, and loosely coupled.

This repository is intended for **learning, interview preparation, and quick revision** of one of the most commonly asked design patterns in .NET interviews.

---

## What is the Factory Pattern?

The **Factory Pattern** is a **Creational Design Pattern** that creates objects for you instead of requiring the client to create them directly using the `new` keyword.

Rather than knowing which concrete class to instantiate, the client requests an object from a factory, and the factory decides which object to create.

In simple words:

> Instead of creating objects yourself, you ask a factory to create the appropriate object for you.

---

## Why Do We Need It?

Suppose an application supports multiple types of vehicles:

* Car
* Bike
* Truck

All of them implement a common interface:

```csharp
public interface IVehicle
{
    void Drive();
}
```

Without the Factory Pattern, every place that needs a vehicle must decide which object to create.

```csharp
if(vehicleType == "Car")
    vehicle = new Car();
else if(vehicleType == "Bike")
    vehicle = new Bike();
else if(vehicleType == "Truck")
    vehicle = new Truck();
```

If this logic exists throughout the application and a new vehicle type is added later, every location must be updated.

The Factory Pattern solves this by moving all object creation into a single class.

---

## How It Works

A Factory Pattern typically consists of three parts:

### 1. Product Interface

Defines the common behavior that all products implement.

```csharp
public interface IVehicle
{
    void Drive();
}
```

### 2. Concrete Products

Each class provides its own implementation.

```csharp
Car
Bike
Truck
```

### 3. Factory Class

The factory receives input, creates the appropriate object, and returns it.

```csharp
IVehicle vehicle = VehicleFactory.GetVehicle("Bike");
```

The client doesn't know or care which class was instantiated.

---

## Example

```csharp
IVehicle vehicle = VehicleFactory.GetVehicle("Car");

vehicle.Drive();
```

**Output**

```
Driving Car
```

The application only interacts with the `IVehicle` interface while the factory handles object creation internally.

---

## Why Use a Factory?

Without a factory, every class decides which object to create.

This leads to:

* Duplicate object creation logic
* Tight coupling with concrete classes
* Difficult maintenance
* Poor scalability

With a factory:

* Object creation is centralized.
* The application depends on abstractions instead of concrete classes.
* Adding new object types becomes much easier.

---

## Benefits

* Centralizes object creation.
* Promotes loose coupling.
* Improves code maintainability.
* Makes applications easier to extend.
* Reduces duplicate code.
* Follows the Open/Closed Principle more closely.

---

## Limitations

* Adds an extra layer of abstraction.
* Factory classes may become large if they create many object types.
* Simple applications may not need this pattern.

---

## Real-World Use Cases

The Factory Pattern is commonly used for:

* Payment gateways (Credit Card, PayPal, Stripe, etc.)
* Database providers
* Notification services (Email, SMS, Push Notifications)
* File parsers
* Vehicle or product creation
* Report generators

---

## Factory vs Direct Object Creation

### Without Factory

```csharp
Car car = new Car();
```

The client knows exactly which class to instantiate.

### With Factory

```csharp
IVehicle vehicle = VehicleFactory.GetVehicle("Car");
```

The client requests an object, while the factory decides which implementation to return.

---

## Factory vs Singleton

| Singleton                         | Factory                           |
| --------------------------------- | --------------------------------- |
| Ensures only one object exists    | Creates objects when requested    |
| Controls the number of instances  | Controls how objects are created  |
| Usually has a private constructor | Constructors are typically public |
| Returns the same instance         | Returns the appropriate object    |

---

## Quick Interview Revision

Remember these key points:

* Factory Pattern is a **Creational Design Pattern**.
* It encapsulates object creation.
* The client depends on an interface, not concrete classes.
* Object creation logic is centralized in one place.
* It promotes loose coupling and improves maintainability.

---

## Note

The implementation in this repository represents the **Simple Factory Pattern**, which is commonly used to introduce the concept of object creation.

The original **Gang of Four (GoF) Factory Method Pattern** is more advanced and relies on inheritance and polymorphism rather than a single static factory class.

Understanding the Simple Factory first makes it much easier to learn:

* Factory Method Pattern
* Abstract Factory Pattern

---

Happy Coding! 🚀

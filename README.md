7-Day Advanced C# OOP Study Plan with Practice Checklist
Day 1 – OOP Foundations (Classes & Objects)

Study:

Classes, Objects

Fields, Properties

Constructors (default, parameterized, copy)

Access Modifiers

Practice Checklist:

Create a Student class with name, age → create multiple objects.

Add a constructor to initialize student details.

Create a Book class → assign values using this keyword.

Try different access modifiers (make one field private, another public).

Create a Product class with a DisplayInfo() method.

Day 2 – Encapsulation

Study:

Encapsulation

Getters & Setters (Properties in C#)

Auto-properties { get; set; }

Read-only & Write-only properties

Practice Checklist:

Create a BankAccount class → balance is private, methods for Deposit & Withdraw.

Add a read-only property for Balance.

Add validation: prevent withdrawing more than balance.

Create Employee class with salary as private, expose only getter.

Create User class with password → allow setting but not reading (write-only).

Day 3 – Abstraction

Study:

Abstract classes & methods

Interfaces

Difference: Abstract vs Interface

Practice Checklist:

Create abstract class Shape with Area() method.

Implement Circle & Rectangle.

Create interface IVehicle with Drive().

Implement Car and Bike.

Create abstract Appliance → implement WashingMachine, Fridge.

Write a program where one class uses multiple interfaces.

Revise: abstract class vs interface differences (write down examples).

Day 4 – Inheritance

Study:

Types of Inheritance (Single, Multilevel, Hierarchical)

Constructor Chaining with base

Method Hiding (new) vs Overriding (override)

Sealed classes & methods

Practice Checklist:

Create Person → Derived Student, Teacher.

Create Animal → Derived Dog → Derived Puppy (Multilevel).

Use constructor chaining (base) in derived class.

Show method hiding (new) vs method overriding (override).

Create a sealed class and try inheriting (observe error).

Day 5 – Polymorphism

Study:

Compile-time Polymorphism (Overloading, Operator Overloading)

Runtime Polymorphism (Overriding, Virtual methods)

Upcasting & Downcasting

Dynamic binding

Practice Checklist:

Create Calculator class with multiple Add() methods (overloading).

Create Animal → override Speak() in Dog, Cat.

Demonstrate upcasting (Animal a = new Dog();).

Demonstrate downcasting (Dog d = (Dog)a;).

Try operator overloading (+ operator in a Complex class).

Day 6 – Advanced OOP Features in C#

Study:

Static classes & members

Partial classes

Structs vs Classes

Indexers

Records (C# 9+)

Practice Checklist:

Create MathHelper static class with utility methods.

Split Student class into two files using partial class.

Create a PointStruct and PointClass, compare behavior.

Create a Library class with indexer (library[0]).

Create a record PersonRecord and compare with normal class.

Day 7 – Delegates, Events & Final Integration

Study:

Delegates

Events (publisher-subscriber)

Anonymous methods & Lambda expressions

Event-driven OOP

Practice Checklist:

Create a delegate that references a method (CalculatorDelegate).

Create an event OnTransaction in BankAccount class.

Raise event when deposit/withdraw happens.

Use anonymous method with delegate.

Build Mini Project – ATM Simulation (Encapsulation + Abstraction + Inheritance + Polymorphism + Events).

✅ Tips for Execution

⏰ Spend 2–3 hrs study + 2–3 hrs coding daily.

📒 Maintain a notes file with definitions + differences (Encapsulation vs Abstraction, Abstract vs Interface, Hiding vs Overriding).

💻 Do all practice tasks → they’ll act as ready-made interview answers.

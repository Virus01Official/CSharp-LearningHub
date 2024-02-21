### Lesson 6: Object-Oriented Programming (OOP) Concepts

Welcome to Lesson 6 of our C# learning journey! In this lesson, we'll dive into Object-Oriented Programming (OOP) concepts in C#. OOP is a programming paradigm that revolves around the concept of objects, which encapsulate data and behavior.

#### Classes and Objects

In C#, a class is a blueprint for creating objects. An object is an instance of a class that encapsulates data (fields) and behavior (methods).

```csharp
// Class declaration
class Person
{
    // Fields
    public string Name;
    public int Age;

    // Method
    public void Greet()
    {
        Console.WriteLine("Hello, my name is " + Name + " and I'm " + Age + " years old.");
    }
}

// Creating objects of the Person class
Person person1 = new Person();
person1.Name = "Alice";
person1.Age = 30;

Person person2 = new Person();
person2.Name = "Bob";
person2.Age = 25;

// Calling the Greet method on objects
person1.Greet(); // Output: Hello, my name is Alice and I'm 30 years old.
person2.Greet(); // Output: Hello, my name is Bob and I'm 25 years old.
```

#### Encapsulation

Encapsulation is the bundling of data (fields) and methods that operate on the data within a class. It allows you to hide the internal state of an object and only expose the necessary functionality.

```csharp
class BankAccount
{
    private double balance;

    public void Deposit(double amount)
    {
        balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (amount <= balance)
            balance -= amount;
        else
            Console.WriteLine("Insufficient funds.");
    }

    public double GetBalance()
    {
        return balance;
    }
}
```

#### Inheritance

Inheritance is a mechanism where a class (derived class) inherits properties and behavior from another class (base class). It promotes code reusability and establishes a hierarchical relationship between classes.

```csharp
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animal is eating.");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dog is barking.");
    }
}
```

#### Polymorphism

Polymorphism allows objects of different classes to be treated as objects of a common base class. It enables you to invoke methods dynamically based on the actual type of the object at runtime.

```csharp
class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape.");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a circle.");
    }
}

class Rectangle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a rectangle.");
    }
}
```

#### Summary

- Classes are blueprints for creating objects that encapsulate data and behavior.
- Encapsulation hides the internal state of an object and exposes only the necessary functionality.
- Inheritance allows classes to inherit properties and behavior from other classes.
- Polymorphism enables objects of different classes to be treated as objects of a common base class.

Practice implementing classes, inheritance, encapsulation, and polymorphism in your C# programs to build robust and scalable applications.

Stay tuned for the next lesson where we'll explore error handling and exception handling in C#.

Happy coding!

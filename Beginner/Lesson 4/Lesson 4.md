### Lesson 4: Functions and Methods

Welcome back to our C# learning journey! In this lesson, we'll explore functions and methods in C#. Functions are essential building blocks of any C# program, allowing you to modularize your code and improve readability and maintainability.

#### What are Functions?

A function is a block of code that performs a specific task. It takes input parameters (if any), performs the necessary operations, and returns a result (if any). Functions help break down a program into smaller, manageable chunks, making it easier to understand and maintain.

#### Declaring and Calling Functions

In C#, you declare a function using the `void` keyword if it doesn't return a value, or you specify the return type if it does. Here's a simple function that calculates the sum of two numbers:

```csharp
// Function declaration
int Sum(int a, int b)
{
    return a + b;
}

// Calling the function
int result = Sum(5, 3);
Console.WriteLine("Sum: " + result); // Output: Sum: 8
```

#### Return Type and Parameters

- **Return Type**: Functions can return a value of a specific data type or void if they don't return anything.
- **Parameters**: Functions can take zero or more input parameters, which are used as variables inside the function.

#### Void Functions

Void functions do not return any value. They are typically used for tasks that perform actions without returning a result.

```csharp
// Void function declaration
void DisplayMessage(string message)
{
    Console.WriteLine("Message: " + message);
}

// Calling the void function
DisplayMessage("Hello, World!"); // Output: Message: Hello, World!
```

#### Method Overloading

Method overloading allows you to define multiple methods with the same name but different parameter lists. The compiler determines which method to call based on the number and types of arguments provided.

```csharp
// Method overloading
int Multiply(int a, int b)
{
    return a * b;
}

double Multiply(double a, double b)
{
    return a * b;
}
```

#### Summary

- Functions are blocks of code that perform specific tasks.
- They can have a return type to return a value or void if they don't return anything.
- Functions can take zero or more input parameters.
- Method overloading allows you to define multiple methods with the same name but different parameter lists.

Practice defining and calling functions in your C# programs to improve code organization and reusability.

Stay tuned for the next lesson where we'll explore arrays and collections in C#.

Happy coding!

[Your Name](link to your profile)

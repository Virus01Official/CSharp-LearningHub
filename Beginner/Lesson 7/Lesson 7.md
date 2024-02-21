### Lesson 7: Error Handling and Exception Handling

Welcome to Lesson 7 of our C# learning journey! In this lesson, we'll explore error handling and exception handling in C#. Errors and exceptions are inevitable in any program, but handling them gracefully is essential for writing robust and reliable code.

#### Types of Errors

In C#, errors can be categorized into two types:

1. **Compile-Time Errors**: These errors occur during the compilation of the program and prevent the compiler from generating executable code. Common compile-time errors include syntax errors and type errors.

2. **Run-Time Errors**: These errors occur during the execution of the program and can cause the program to terminate abnormally. Common run-time errors include division by zero, array index out of bounds, and null reference exceptions.

#### Exception Handling

Exception handling is a mechanism used to handle run-time errors gracefully and prevent program termination. In C#, exception handling is done using `try-catch` blocks.

```csharp
try
{
    // Code that may throw an exception
    int result = 10 / 0; // This will throw a DivideByZeroException
}
catch (DivideByZeroException ex)
{
    // Code to handle the exception
    Console.WriteLine("Error: " + ex.Message);
}
```

#### The finally Block

The `finally` block is used to execute code regardless of whether an exception occurs or not. It is typically used to perform cleanup operations such as closing files or releasing resources.

```csharp
try
{
    // Code that may throw an exception
}
catch (Exception ex)
{
    // Code to handle the exception
}
finally
{
    // Cleanup code
}
```

#### Throwing Exceptions

You can also manually throw exceptions using the `throw` keyword. This allows you to create custom exception types and provide meaningful error messages.

```csharp
int age = -10;
try
{
    if (age < 0)
    {
        throw new ArgumentException("Age cannot be negative.");
    }
}
catch (ArgumentException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}
```

#### Summary

- Errors in C# can be compile-time errors or run-time errors.
- Exception handling using `try-catch` blocks allows you to handle run-time errors gracefully.
- The `finally` block is used for cleanup operations and is executed regardless of whether an exception occurs or not.
- You can manually throw exceptions using the `throw` keyword to indicate exceptional conditions in your code.

Practice implementing exception handling in your C# programs to handle unexpected scenarios and improve the robustness of your applications.

Stay tuned for the next lesson where we'll explore file I/O operations in C#.

Happy coding!

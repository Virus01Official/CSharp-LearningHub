### Intermediate Lesson 3: Exception Handling and Error Logging

Welcome to Intermediate Lesson 3 of our C# learning journey! In this lesson, we'll explore more advanced techniques for exception handling and error logging in C#. Exception handling is crucial for handling unexpected errors gracefully, and error logging helps in diagnosing and troubleshooting issues in production environments.

#### Handling Exceptions

In addition to the `try-catch` blocks we've seen before, C# provides more advanced exception handling features, such as `try-catch-finally`, `throw` statements, and custom exception classes.

```csharp
try
{
    // Code that may throw an exception
}
catch (DivideByZeroException ex)
{
    // Handle specific exception types
}
catch (Exception ex)
{
    // Handle general exception types
}
finally
{
    // Cleanup code that always executes
}
```

#### Logging Errors

Error logging is the process of recording information about errors that occur during the execution of a program. This information can include timestamps, error messages, stack traces, and more. C# provides various logging frameworks, such as Serilog, NLog, and log4net.

```csharp
using Serilog;
class Program
{
    static void Main()
    {
        // Configure Serilog logger
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day)
            .CreateLogger();

        try
        {
            // Code that may throw an exception
        }
        catch (Exception ex)
        {
            // Log the exception
            Log.Error(ex, "An error occurred");
        }
        finally
        {
            // Close the logger
            Log.CloseAndFlush();
        }
    }
}
```

#### Handling Unhandled Exceptions

In some cases, exceptions may occur that are not caught by any `try-catch` block. To handle such unhandled exceptions, you can subscribe to the `AppDomain.CurrentDomain.UnhandledException` event or use global exception handling in ASP.NET applications.

```csharp
AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
{
    Exception ex = (Exception)args.ExceptionObject;
    // Log the unhandled exception
};
```

#### Summary

- Exception handling in C# allows you to handle unexpected errors gracefully using `try-catch` blocks.
- Advanced exception handling features include `try-catch-finally`, `throw` statements, and custom exception classes.
- Error logging helps in diagnosing and troubleshooting issues by recording information about errors.
- C# provides various logging frameworks for error logging, such as Serilog, NLog, and log4net.

Practice implementing exception handling and error logging in your C# applications to improve error handling and debugging capabilities.

Stay tuned for the next intermediate lesson where we'll explore more advanced C# topics!

Happy coding!

### Lesson 3: Control Flow Statements

Welcome back to our C# learning journey! In this lesson, we'll explore control flow statements in C#. Control flow statements allow you to control the flow of execution in your programs based on certain conditions.

#### Conditional Statements (if-else)

Conditional statements are used to execute code based on certain conditions. In C#, we have the `if`, `else if`, and `else` statements.

```csharp
int age = 20;

if (age >= 18)
{
    Console.WriteLine("You are an adult.");
}
else
{
    Console.WriteLine("You are a minor.");
}
```

#### Switch Statement

The switch statement allows you to select one of many code blocks to be executed based on the value of a variable.

```csharp
int day = 3;
string dayName;

switch (day)
{
    case 1:
        dayName = "Monday";
        break;
    case 2:
        dayName = "Tuesday";
        break;
    case 3:
        dayName = "Wednesday";
        break;
    default:
        dayName = "Unknown";
        break;
}

Console.WriteLine("Today is " + dayName);
```

#### Loops

Loops are used to execute a block of code repeatedly. C# supports different types of loops such as `for`, `while`, and `do-while`.

**For Loop:**
```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Iteration: " + i);
}
```

**While Loop:**
```csharp
int n = 0;
while (n < 5)
{
    Console.WriteLine("Iteration: " + n);
    n++;
}
```

**Do-While Loop:**
```csharp
int m = 0;
do
{
    Console.WriteLine("Iteration: " + m);
    m++;
} while (m < 5);
```

#### Break and Continue Statements

- **Break**: Terminates the loop and transfers control to the statement immediately following the loop.
- **Continue**: Skips the current iteration of the loop and continues with the next iteration.

```csharp
for (int i = 0; i < 10; i++)
{
    if (i == 5)
        break; // terminates the loop when i equals 5
    if (i % 2 == 0)
        continue; // skips even numbers
    Console.WriteLine("Number: " + i);
}
```

#### Summary
- Conditional statements (`if-else`) allow you to execute code based on certain conditions.
- The `switch` statement selects one of many code blocks to execute based on the value of a variable.
- Loops (`for`, `while`, `do-while`) allow you to execute a block of code repeatedly.
- The `break` and `continue` statements provide control over loop execution.

Practice using these control flow statements to create more dynamic and interactive C# programs.

Stay tuned for the next lesson where we'll delve into functions and methods in C#.

Happy coding!

### Lesson 2: Variables and Data Types

Welcome back to our C# learning journey! In this lesson, we'll dive deeper into variables and data types in C#. Understanding variables and data types is crucial as they form the building blocks of any C# program.

#### Variables in C#
A variable is a named storage location used to store data that can change during the execution of a program. In C#, every variable has a data type that determines the type of data it can hold.

#### Data Types
C# supports various data types, including:
- **Numeric Types**: Integers (`int`, `long`, `short`, `byte`), Floating-point numbers (`float`, `double`, `decimal`)
- **Boolean Type**: `bool` (true/false)
- **Characters**: `char`
- **Strings**: `string`
- **Others**: `object`, `dynamic`

#### Declaring Variables
To declare a variable in C#, you specify the data type followed by the variable name. Here's an example:
```csharp
int age; // Declares an integer variable named age
```

#### Initializing Variables
You can also initialize a variable at the time of declaration:
```csharp
int age = 30; // Initializes the variable age with the value 30
```

#### Variable Naming Rules
- Variable names must start with a letter or an underscore.
- They can contain letters, digits, and underscores.
- C# is case-sensitive, so `age`, `Age`, and `AGE` are considered different variables.

#### Using Variables
Once a variable is declared and initialized, you can use it in your program:
```csharp
int age = 30;
Console.WriteLine("Age: " + age);
```

#### Type Inference (var keyword)
C# also supports type inference using the `var` keyword, which allows the compiler to infer the data type based on the value assigned to the variable:
```csharp
var name = "John"; // Compiler infers name as string
var height = 6.2;   // Compiler infers height as double
```

#### Constants
In addition to variables, you can also declare constants using the `const` keyword. Constants are variables whose values cannot be changed once assigned:
```csharp
const double PI = 3.14159;
```

#### Summary
- Variables are named storage locations used to store data.
- C# supports various data types, including numeric types, boolean, characters, strings, and others.
- Variables must be declared with a specific data type before they can be used.
- Constants are variables whose values cannot be changed once assigned.

Now that you understand variables and data types in C#, it's time to practice! Try declaring different types of variables and using them in simple programs to reinforce your understanding.

Stay tuned for the next lesson where we'll explore control flow statements in C#.

Happy coding!

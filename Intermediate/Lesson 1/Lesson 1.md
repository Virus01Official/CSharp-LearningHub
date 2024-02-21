### Intermediate Lesson 1: Introduction to File I/O Operations

Welcome to Intermediate Lesson 1 of our C# learning journey! In this lesson, we'll dive into File Input/Output (I/O) operations in C#. Working with files is a crucial aspect of many applications, allowing you to read from and write to external files to store and retrieve data.

#### Reading from Files

C# provides various classes and methods for reading data from files. The `StreamReader` class is commonly used to read text files line by line.

```csharp
using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            // Specify the file path
            string filePath = "example.txt";

            // Open the file for reading
            using (StreamReader reader = new StreamReader(filePath))
            {
                // Read the file line by line
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
```

#### Writing to Files

Similarly, C# provides classes and methods for writing data to files. The `StreamWriter` class is commonly used to write text to files.

```csharp
using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            // Specify the file path
            string filePath = "output.txt";

            // Open the file for writing
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Write data to the file
                writer.WriteLine("Hello, World!");
                writer.WriteLine("This is a sample text.");
            }

            Console.WriteLine("Data has been written to the file successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
```

#### Summary

- File I/O operations in C# allow you to read from and write to external files.
- The `StreamReader` class is used for reading text files line by line.
- The `StreamWriter` class is used for writing text to files.

Practice using file I/O operations in your C# programs to work with external data files effectively.

Stay tuned for the next intermediate lesson where we'll explore more advanced file handling techniques!

Happy coding!

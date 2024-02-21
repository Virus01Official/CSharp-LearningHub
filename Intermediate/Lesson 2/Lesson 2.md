### Intermediate Lesson 2: Working with Streams and Binary Files

Welcome to Intermediate Lesson 2 of our C# learning journey! In this lesson, we'll delve deeper into file I/O operations by exploring streams and binary files. Streams provide a flexible way to work with data, and binary files allow us to store and manipulate binary data efficiently.

#### Streams in C#

In C#, a stream is an abstract representation of a sequence of bytes. Streams are used for reading from or writing to a data source, such as files, network connections, or memory buffers.

```csharp
using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            // Create a FileStream to read from a file
            using (FileStream stream = new FileStream("example.txt", FileMode.Open))
            {
                // Read bytes from the stream
                byte[] buffer = new byte[1024];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);

                // Convert bytes to string and display
                string text = System.Text.Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine("Read from file: " + text);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
```

#### Binary Files

Binary files are files that contain data in a binary format, which is a sequence of 0s and 1s. Unlike text files, which store data as human-readable characters, binary files store data in its raw form, making them more efficient for certain types of data.

```csharp
using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            // Create a BinaryWriter to write to a binary file
            using (BinaryWriter writer = new BinaryWriter(File.Open("data.bin", FileMode.Create)))
            {
                // Write integer and double values to the file
                writer.Write(10);
                writer.Write(3.14);
            }

            // Create a BinaryReader to read from the binary file
            using (BinaryReader reader = new BinaryReader(File.Open("data.bin", FileMode.Open)))
            {
                // Read integer and double values from the file
                int intValue = reader.ReadInt32();
                double doubleValue = reader.ReadDouble();
                Console.WriteLine("Read from binary file: " + intValue + ", " + doubleValue);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
```

#### Summary

- Streams in C# provide a flexible way to work with data from various sources.
- Binary files store data in its raw binary format, making them more efficient for certain types of data.
- The `FileStream`, `BinaryWriter`, and `BinaryReader` classes are used for working with streams and binary files.

Practice using streams and binary files in your C# programs to manipulate data efficiently and handle different data formats.

Stay tuned for the next intermediate lesson where we'll explore more advanced file handling techniques!

Happy coding!

using System;

class Program
{
    static void Main()
    {
        // Declaring variables
        int age;
        double height;

        // Initializing variables
        age = 30;
        height = 6.2;

        // Using variables
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Height: " + height + " feet");

        // Type inference with var keyword
        var name = "John";
        var isMarried = false;

        Console.WriteLine("Name: " + name);
        Console.WriteLine("Married: " + isMarried);

        // Constants
        const double PI = 3.14159;
        Console.WriteLine("Value of PI: " + PI);
    }
}

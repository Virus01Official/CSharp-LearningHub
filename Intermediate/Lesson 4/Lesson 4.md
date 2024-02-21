### Intermediate Lesson 4: Working with Databases in C#

Welcome to Intermediate Lesson 4 of our C# learning journey! In this lesson, we'll explore how to work with databases in C#. Databases are crucial for storing and managing structured data, and C# provides several libraries and frameworks to interact with databases efficiently.

#### Connecting to a Database

To connect to a database in C#, you typically use ADO.NET, which is a set of classes in the .NET Framework for accessing and managing data from various data sources.

```csharp
using System;
using System.Data.SqlClient;

class Program
{
    static void Main()
    {
        // Connection string
        string connectionString = "Data Source=your_server;Initial Catalog=your_database;User ID=your_username;Password=your_password";

        // Create connection
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                // Open connection
                connection.Open();

                // Connection successful
                Console.WriteLine("Connection successful!");
            }
            catch (Exception ex)
            {
                // Connection failed
                Console.WriteLine("Connection failed: " + ex.Message);
            }
        }
    }
}
```

#### Executing SQL Queries

Once connected, you can execute SQL queries to retrieve, insert, update, or delete data from the database using `SqlCommand`.

```csharp
// Create SQL command
string sqlQuery = "SELECT * FROM Customers";
SqlCommand command = new SqlCommand(sqlQuery, connection);

// Execute SQL query
using (SqlDataReader reader = command.ExecuteReader())
{
    while (reader.Read())
    {
        Console.WriteLine(reader["CustomerName"]);
    }
}
```

#### Using Entity Framework

Entity Framework is an ORM (Object-Relational Mapping) framework that simplifies database interactions by mapping database tables to C# classes. It provides a higher-level abstraction for working with databases.

```csharp
using Microsoft.EntityFrameworkCore;

class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class ApplicationDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("your_connection_string");
    }
}

class Program
{
    static void Main()
    {
        using (var context = new ApplicationDbContext())
        {
            var customers = context.Customers.ToList();
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.Name);
            }
        }
    }
}
```

#### Summary

- C# provides ADO.NET for interacting with databases, allowing you to connect to databases, execute SQL queries, and retrieve data.
- Entity Framework is an ORM framework that provides a higher-level abstraction for working with databases, simplifying data access and manipulation.

Practice working with databases in your C# applications to store and manage structured data efficiently.

Stay tuned for the next intermediate lesson where we'll explore more advanced C# topics!

Happy coding!

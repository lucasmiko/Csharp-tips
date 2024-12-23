// Tip: Understanding Serialization and Deserialization in C#

/*
Serialization is the process of converting an object into a format that can be easily stored or transmitted, such as JSON, XML, or binary. Deserialization is the reverse process, where the stored or transmitted data is converted back into an object. These processes are essential in various scenarios, including:

1. Data Storage: Serialization allows you to save the state of an object to a file or database. This is useful for persisting data between application sessions.
2. Data Transmission: When sending data over a network, serialization converts objects into a format that can be transmitted, such as JSON or XML. Deserialization on the receiving end reconstructs the object.
3. APIs and Web Services: Serialization is commonly used in APIs and web services to exchange data between clients and servers in a structured format like JSON or XML.
4. Caching: Serialized objects can be stored in a cache to improve performance by avoiding repeated computation or database access.
5. Configuration Files: Applications often use serialization to read and write configuration settings in JSON or XML files.

Below are some examples of serialization and deserialization in C# using JSON:
*/

// JSON Serialization and Deserialization using Newtonsoft.Json
using Newtonsoft.Json;

public class Customer {
    public string Name { get; set; }
    public int Age { get; set; }
}

public class SerializationExample {
    public void SerializeCustomer() {
        var customer = new Customer { Name = "John Doe", Age = 30 };
        string json = JsonConvert.SerializeObject(customer);
        Console.WriteLine(json); // Output: {"Name":"John Doe","Age":30}
    }

    public void DeserializeCustomer(string json) {
        var customer = JsonConvert.DeserializeObject<Customer>(json);
        Console.WriteLine($"Name: {customer.Name}, Age: {customer.Age}");
    }
}

// Example usage
var example = new SerializationExample();
example.SerializeCustomer();
string json = "{\"Name\":\"Jane Doe\",\"Age\":25}";
example.DeserializeCustomer(json);

/*
In this example, we use the `JsonConvert.SerializeObject` method to serialize a `Customer` object to a JSON string, and the `JsonConvert.DeserializeObject` method to deserialize a JSON string back into a `Customer` object.

Serialization and deserialization are powerful tools in C# that enable efficient data storage, transmission, and manipulation. Understanding these concepts can greatly enhance your ability to work with data in various formats and scenarios.
*/

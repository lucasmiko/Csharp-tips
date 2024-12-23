// What's New in C# 13

/*1. Params Collections
The params modifier is now more versatile, allowing it to be used with any recognized collection type, not just arrays. This includes types like System.Span<T>, System.ReadOnlySpan<T>, and any type that implements System.Collections.Generic.IEnumerable<T> and has an Add method.

Example:*/

public void Concat<T>(params ReadOnlySpan<T> items)
{
  for (int i = 0; i < items.Length; i++)
  {
    Console.Write(items[i]);
    Console.Write(" ");
  }
  
  Console.WriteLine();
}

/*2. New Lock Object
C# 13 introduces a new type for thread synchronization: System.Threading.Lock. This type provides better thread synchronization through its API. The Lock.EnterScope() method enters an exclusive scope, and the ref struct returned supports the Dispose() pattern to exit the scope.

Example:*/

var myLock = new System.Threading.Lock();
using (myLock.EnterScope()) {
    // Critical section
}

/*3. New Escape Sequence
A new escape sequence \e has been added to represent the ASCII escape character.

Example:*/

string escapeSequence = "\e[31mThis text is red\e[0m";
Console.WriteLine(escapeSequence);

/*4. Method Group Natural Type
Improvements have been made to the natural type of method groups, making it easier to work with delegates and lambda expressions.

Example:*/

Func<int, int> square = x => x * x;
var numbers = new[] { 1, 2, 3, 4 };
var squares = numbers.Select(square);

/*5. Implicit Indexer Access in Object Initializers
You can now use implicit indexer access in object initializers, simplifying the initialization of collections.

Example:*/

var dictionary = new Dictionary<int, string>
{
  [1] = "One",
  [2] = "Two",
  [3] = "Three"
};

/*6. Ref Locals and Unsafe Contexts in Iterators and Async Methods
C# 13 allows ref locals and unsafe contexts in iterators and async methods, providing more flexibility in performance-critical code.

Example:*/

public async Task ProcessDataAsync()
{
  Span<int> data = stackalloc int[100];
  // Unsafe code here
}

/*7. Partial Properties and Indexers
Partial properties and indexers are now allowed in partial types, enhancing modularity and code organization.

Example:*/

public partial class MyClass
{
  public partial int MyProperty { get; set; }
}
/*
8. Overload Resolution Priority
Library authors can now designate one overload as better than others, improving the clarity and usability of APIs.

Example:*/

public void Print(string message) => Console.WriteLine(message);
public void Print(object obj) => Console.WriteLine(obj.ToString());

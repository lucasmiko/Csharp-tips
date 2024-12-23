// Basic foreach syntax
// Use this syntax to iterate over any collection that implements IEnumerable.
foreach (var item in collection)
{
    // Code to execute for each item
}

// Foreach with lambda expression
// This syntax is available for List<T> and allows for a more concise iteration.
collection.ForEach(item => Console.WriteLine(item));

// Foreach with LINQ
// Use this syntax to filter or transform collections before iterating over them.
collection.Where(item => item.Condition).ToList().ForEach(item => Console.WriteLine(item));

// Foreach with arrays
// Arrays also implement IEnumerable, so you can use the basic foreach syntax.
int[] numbers = { 1, 2, 3, 4, 5 };
foreach (int number in numbers)
{
    Console.WriteLine(number);
}

// Foreach with IEnumerable
// Any collection that implements IEnumerable can be iterated using foreach.
IEnumerable<int> enumerableNumbers = new List<int> { 1, 2, 3, 4, 5 };
foreach (int number in enumerableNumbers)
{
    Console.WriteLine(number);
}

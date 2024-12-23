// Basic
int number = 2;
switch (number)
{
    case 1:
        Console.WriteLine("One");
        break;
    case 2:
        Console.WriteLine("Two");
        break;
    case 3:
        Console.WriteLine("Three");
        break;
    default:
        Console.WriteLine("Other");
        break;
}

// switch com múltiplos casos
char grade = 'B';
switch (grade)
{
    case 'A':
    case 'B':
    case 'C':
        Console.WriteLine("Pass");
        break;
    case 'D':
    case 'F':
        Console.WriteLine("Fail");
        break;
    default:
        Console.WriteLine("Invalid grade");
        break;
}

// switch com goto
int x = 1;
switch (x)
{
    case 1:
        Console.WriteLine("Case 1");
        goto case 3;
    case 2:
        Console.WriteLine("Case 2");
        break;
    case 3:
        Console.WriteLine("Case 3");
        break;
}

// Expressão switch (C# 8.0+)
var result = number switch
{
    1 => "One",
    2 => "Two",
    3 => "Three",
    _ => "Other"
};
Console.WriteLine(result);

// switch com padrões
object obj = 42;
switch (obj)
{
    case int i when i > 0:
        Console.WriteLine("Positive integer");
        break;
    case string s:
        Console.WriteLine($"String of length {s.Length}");
        break;
    default:
        Console.WriteLine("Other type");
        break;
}

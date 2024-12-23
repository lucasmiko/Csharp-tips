// Basic Syntax
// The basic syntax of a `for` loop in C# is:
for (initialization; condition; iteration)
{
    // Code to be executed
}
```
/* Initialization: Executed once before the loop starts. Used to initialize the loop control variable.
Condition: Evaluated before each iteration. If true, the loop continues; if false, the loop ends.
Iteration: Executed after each iteration of the loop. Used to update the loop control variable.*/
// Examples

// 1. Simple Loop
   for (int i = 0; i < 5; i++)
   {
       Console.WriteLine(i);
   }

// 2. Loop with Different Step
   for (int i = 0; i <= 10; i += 2)
   {
       Console.WriteLine(i);
   }

// 3. Nested Loops
   for (int i = 1; i <= 2; i++)
   {
       Console.WriteLine("Outer: " + i);
       for (int j = 1; j <= 3; j++)
       {
           Console.WriteLine(" Inner: " + j);
       }
   }

// 4. Loop with Multiple Variables
   for (int i = 0, j = 10; i < j; i++, j--)
   {
       Console.WriteLine($"i: {i}, j: {j}");
   }

// 5. Infinite Loop
   for (;;)
   {
       Console.WriteLine("This will run forever");
   }

// 6. Loop with Complex Conditions
   for (int i = 0; i < 10 && someCondition; i++)
   {
       // Code to be executed
   }

// Practical Use Cases

// 1. Summing Numbers
   int sum = 0;
   for (int i = 1; i <= n; i++)
   {
       sum += i;
   }
   Console.WriteLine("Sum: " + sum);

// 2. Iterating Over Arrays
   int[] numbers = { 1, 2, 3, 4, 5 };
   for (int i = 0; i < numbers.Length; i++)
   {
       Console.WriteLine(numbers[i]);
   }

// 3. Using Break and Continue
   for (int i = 0; i < 10; i++)
   {
       if (i == 5)
           break; // Exit the loop
       if (i % 2 == 0)
           continue; // Skip the rest of the loop body
       Console.WriteLine(i);
   }
// Iterate through a code block using for statement in C#

// ------ ITERATION STATEMENTS ------
/*    

    The for statement iterates through a code block a specific number of times. This level of control makes the for statement unique 
    among the other iteration statements. The foreach statement iterates through a block of code once for each item in a sequence of data 
    like an array or collection. The while statement iterates through a block of code until a condition is met.
*/

for (int i = 0; i < 10; i++) // (i = 0; then if i less than 10 iterate; then i + 1)
{
    Console.WriteLine(i); // note that 10 does not get printed> if less than 10 happens before print
}

for (int i = 10; i >= 0; i--) // (i = 10; then if i is greater than 0 iterate; then i - 1)
{
    Console.WriteLine(i);
    if (i == 7) break; // iterate until i = 7, note that print is first so 7 gets printed
}

// ------ iterate through each element of an array ------

string[] names = {"Alex", "Eddie", "David", "Michael"};
for (int i = names.Length - 1; i >= 0; i--) // length is 4 but array starts from 0 so now 0-3
{
    System.Console.WriteLine(names[i]);
}

// ------ limitation of the foreach ------
//foreach (var name in names)
//{
//    // Can't do this:
//    if (name == "David") name = "Sammy";
//}

string[] names2 = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names2.Length; i++)
    // Can do this:
    if (names2[i] == "David") names2[i] = "Sammy";

foreach (var name in names2) Console.WriteLine(name);

// ------ CHALLENGE ------
// This is my third time encountering FizzBuzz challenge...

for (int i = 0; i < 101; i++)
{
    
    if (i % 3 == 0 && i % 5 == 0) // Could as well be (i % 15 == 0) but && is a cool sign
        System.Console.WriteLine(i + " - FizzBuzz");
    else if (i % 5 == 0)
        System.Console.WriteLine(i + " - Buzz");
    else if (i % 3 == 0)
        System.Console.WriteLine(i + " - Fizz");
    else System.Console.WriteLine(i);
}


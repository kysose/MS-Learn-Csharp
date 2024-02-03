// Control variable scope and logic using code blocks in C#

//bool flag = true;
//int value = 0;
//
//if (flag)
//{
//    Console.WriteLine($"Inside the code block: {value}");
//}
//
//value = 10;
//Console.WriteLine($"Outside the code block: {value}");

/*
// Code sample 1
bool flag = true;
int value;

if (flag)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {value}");

// path when flag = true
int value;
value = 10;
Console.WriteLine($"Inside the code block: {value}");
Console.WriteLine($"Outside the code block: {value}");
// path when flag = false
int value;
Console.WriteLine($"Outside the code block: {value}");

// Code sample 2
int value;

if (true)
{
    value = 10;
    Console.WriteLine($"Inside the code block: {value}");
}

Console.WriteLine($"Outside the code block: {value}");

// path
int value;
value = 10;
Console.WriteLine($"Inside the code block: {value}");
Console.WriteLine($"Outside the code block: {value}");
*/

//bool flag = true;
//if (flag) Console.WriteLine(flag); //I've been doing this since the beginning
//
//string name = "steve";
//if (name == "bob") Console.WriteLine("Found Bob");
//else if (name == "steve") Console.WriteLine("Found Steve");
//else Console.WriteLine("Found Chuck"); 

// Above is a tad too compact, fixed below

//string name = "steve";
//
//if (name == "bob")
//    Console.WriteLine("Found Bob");
//else if (name == "steve") 
//    Console.WriteLine("Found Steve");
//else
//    Console.WriteLine("Found Chuck");

// ------ CHALLENGE ------

int[] numbers = { 4, 8, 15, 16, 23, 42 };
bool found = false;
int total = 0; 

foreach (int number in numbers)
{
    total += number;

    if (number == 42) found = true;
}

if (found) Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {total}");
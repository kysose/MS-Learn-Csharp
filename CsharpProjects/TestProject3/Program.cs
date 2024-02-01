//     Store and iterate through sequences of data using Arrays and the foreach statement in C# 
/*
string[] fraudulentOrderIDs = new string[3]; //new instance of an array in the computer's memory. Element count set to 3

fraudulentOrderIDs[0] = "A123"; //elements are assigned as strings. They start from 0!
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000"; causes error message: System.IndexOutOfRangeException: Index was outside the bounds of the array.
*/

string[] fraudulentOrderIDs = { "A123", "B456", "C789" }; // initializing the array for compactness


Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000"; //reassign 1st array element 

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

/* ------ RECAP ------

Here's the most important things to remember when working with arrays:

    An array is a special variable that holds a sequence of related data elements.
    You should memorize the basic format of an array variable declaration.
    Access each element of an array to set or get its values using a zero-based index inside of square brackets.
    If you attempt to access an index outside of the boundary of the array, you get a run time exception.
    The Length property gives you a programmatic way to determine the number of elements in an array.
*/

// ------ FOREACH ------

string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
    Console.WriteLine(name);
}

//----------------------

int[] inventory = {200, 450, 700, 175, 250};
int sum = 0;
int bin = 0;
foreach (int items in inventory)
{
    sum += items;
    bin++;
    System.Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

System.Console.WriteLine($"We have {sum} items in inventory.");
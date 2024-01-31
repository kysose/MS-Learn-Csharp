//microsoft learn: Call methods from the .NET Class Library using C# 


Random dice = new Random(); //class = random / instance of the class = dice <- dice is the object
//new requests memory from the computer, to store the new object, based on the Random class
//new object is created and stored in a memory address, which is returned and saved in "dice"-variable
//newer .NET don't require the class name after new() so:
// Random dice = new(); <- this is sufficient
int roll = dice.Next(1, 7); //Next generates a random number from the date and time down to a millisecond
// dice.Next(); = Random.Next(); since dice is an instance of Random
// 1 and 7 are arguments (input parameters) and , is the separator
Console.WriteLine(roll);

//int result = Random.Next(); // <- redline because Next() is stateful
Random dice2 = new();
int roll2 = dice.Next(); // <- no redline, because instance is stateless

// syntax -> ClassName.MethodName() 

// void methods do not return a value

int number = 7;
string text = "seven";

Console.WriteLine(number);
Console.WriteLine();
Console.WriteLine(text);

//above shows three separate overloads of Console.WriteLine
//below shows three separate overloads of Next();
Random dice3 = new Random();
int roll11 = dice3.Next(); //no boundaries so returns anything between 0 to 2,147,483,647 max an int an store
int roll12 = dice3.Next(101); //returns anything below 101 so 0-100 
int roll13 = dice3.Next(50, 101); // returns 50-100

Console.WriteLine($"First roll: {roll11}");
Console.WriteLine($"Second roll: {roll12}");
Console.WriteLine($"Third roll: {roll13}");

// ------ RECAP ------
/*
    Methods might accept no parameters or multiple parameters, depending on how they were designed and implemented. 
    When passing in multiple input parameters, separate them with a , symbol.
    Methods might return a value when they complete their task, or they might return nothing (void).
    Overloaded methods support several implementations of the method, 
    each with a unique method signature (the number of input parameters and the data type of each input parameter).
    IntelliSense can help write code more quickly. It provides a quick reference to methods, their return values, 
    their overloaded versions, and the types of their input parameters.
    learn.microsoft.com is the "source of truth" when you want to learn how methods in the .NET Class Library work. */  

// Challenge

int firstValue = 500;
int secondValue = 600;
int largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine($"largerValue is: {largerValue}");  

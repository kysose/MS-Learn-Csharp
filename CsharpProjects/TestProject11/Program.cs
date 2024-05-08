// 	Convert data types using casting and conversion techniques in C# 
//
/*
int first = 2;
string second = "4";
// int result = first + second; this doesn't work
string result = first + second; // this works but prints 24 instead of 6
System.Console.WriteLine(result);
*/
/* Data conversion techniques:

    Use a helper method on the data type
    Use a helper method on the variable
    Use the Convert class' methods
*/

int myInt = 3;
System.Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt; // this is not a problem since any integer fits inside decimal
System.Console.WriteLine($"decimal: {myDecimal} \n");
// Widening conversion = converting a data type that holds more data to a type that holds less data
// If you need widening, you can rely on implicit conversion

decimal myDecimal2 = 3.14m; //remember the "m" wih decimals
System.Console.WriteLine($"decimal2: {myDecimal2}");

int myInt2 = (int)myDecimal; //explicit conversion decimal -> int
System.Console.WriteLine($"int2: {myInt2} \n");

// testing two casts to determine which loses less data:
decimal myDecimal3 = 1.23456789m;
float myFloat = (float)myDecimal3;

Console.WriteLine($"Decimal: {myDecimal3}");
Console.WriteLine($"Float  : {myFloat} \n"); // a float is less precise, hence 8 rounded to 9

// .ToString() and .Parse()

int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
System.Console.WriteLine(message + "\n");

string sfirst = "5";
string ssecond = "7";
int sum = int.Parse(sfirst) + int.Parse(ssecond);
Console.WriteLine(sum + "\n");

// Convert -class

string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result + "\n"); //int32 because it's the full name of int in .NET Class Library 

// casting vs convertion

int value3 = (int)1.5m; // casting truncates
Console.WriteLine(value3);

int value4 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value4 + "\n");

// 

string name = "Bob";
// Console.WriteLine(int.Parse(name)); input string error

string value5 = "102";
int result2 = 0;
if (int.TryParse(value5, out result2))
{
   Console.WriteLine($"Measurement: {result2} \n");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
/*
    When calling a method with an out parameter, you must use the keyword out before the variable, which holds the value. 
    The out parameter is assigned to the result variable in the code (int.TryParse(value, out result). 
    You can then use the value the out parameter contains throughout the rest of your code using the variable result.

    The int.TryParse() method returns true if it successfully converted the string variable value into an int; otherwise, 
    it returns false. So, surround the statement in an if statement, and then perform the decision logic, accordingly.

    The converted value is stored in the int variable result. The int variable result is declared and initialized before this line 
    of code, so it should be accessible both inside the code blocks that belong to the if and else statements, as well as outside 
    of them.

    The out keyword instructs the compiler that the TryParse() method doesn't return a value the traditional way only 
    (as a return value), but also communicates an output through this two-way parameter.
*/
//To demonstrate that the result variable that was declared earlier, 
//is populated by the out parameter and is also usable later in your code:
string value6 = "102";
int result3 = 0;
if (int.TryParse(value6, out result3))
{
   Console.WriteLine($"Measurement: {result3}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}
Console.WriteLine($"Measurement (w/ offset): {50 + result3}\n");

/* example for failing parse
string value = "bad";
int result = 0;
if (int.TryParse(value, out result))
{
   Console.WriteLine($"Measurement: {result}");
}
else
{
   Console.WriteLine("Unable to report the measurement.");
}

if (result > 0)
   Console.WriteLine($"Measurement (w/ offset): {50 + result}");
*/

// Challenge: combine string array values as strings and as integers
System.Console.WriteLine("\nChallenge\n");

string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal sumTotal = 0m;
string messageFinal = "";

foreach (var item in values)
{
    decimal result4;
    bool isNumeric = decimal.TryParse(item, out result4);
    if (isNumeric) sumTotal += result4;
    else
    {
        messageFinal += item;
    }

}
System.Console.WriteLine($"Message: {messageFinal}");
System.Console.WriteLine($"Total: {sumTotal}");

// ms learn answer (I added tens):
string[] values10 = { "12.3", "45", "ABC", "11", "DEF" };

decimal total10 = 0m;
string message10 = "";

foreach (var value in values10)
{
    decimal number10; // stores the TryParse "out" value
    if (decimal.TryParse(value, out number10))
    {
        total10 += number10;
    } else
    {
        message10 += value;
    }
}

Console.WriteLine($"\nMessage: {message10}");
Console.WriteLine($"Total: {total10}");
//I am finnish so neither answer provides the right answer actually. This has to do with how . and , are treated in different languages
//If you are on en-US it should work, but for me both print 12.3ABCDEF and 56
//One solution would be bool: isNumeric = decimal.TryParse(item, NumberStyles.Any, CultureInfo.InvariantCulture, out result4);

// Chalenge 2 math ops as specific num types
System.Console.WriteLine("\nChallenge 2\n");
int value20 = 11;
decimal value21 = 6.2m;
float value22 = 4.3f;

// Hint: You need to round the result to nearest integer (don't just truncate)
int result20 = Convert.ToInt32(value20 / value21);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result20}");

decimal result21 = value21 / (decimal)value22;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result21}");

float result22 = value22 / value20;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result22}");

// Casting is the best technique when converting decimal -> int
// Convert.ToInt32() rounds with fractional precision
// Always use .TryParse() when converting strings to numerics
// .TryParse() returns a pool hence: bool succes = decimal.TryParse(input, out decimal number)





//  Choose the correct data type in your C# code 
/*
Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
*/

//Because floating-point types can hold large numbers with precision, their values can be represented using "E notation", 
//which is a form of scientific notation that means "times 10 raised to the power of." So, a value like 5E+2 would be 
//the value 500 because it's the equivalent of 5 * 10^2, or 5 x 10

/*
    A value type variable stores its values directly in an area of storage called the stack. 
    The stack is memory allocated to the code that is currently running on the CPU (also known as the stack frame, 
    or activation frame). When the stack frame has finished executing, the values in the stack are removed.

    A reference type variable stores its values in a separate memory region called the heap. The heap is a memory area 
    that is shared across many applications running on the operating system at the same time. The .NET Runtime communicates 
    with the operating system to determine what memory addresses are available, and requests an address where it can store the value. 
    The .NET Runtime stores the value, and then returns the memory address to the variable. When your code uses the variable, 
    the .NET Runtime seamlessly looks up the address stored in the variable, and retrieves the value that's stored there.
*/

int[] data; //int array named data
data = new int[1]; //instanciate data, stored in heap

// compact version: int[] data = new int[3];

/*
    The string data type is also a reference type. You might be wondering why a new operator wasn't used when declaring a string. 
    This is purely a convenience afforded by the designers of C#. Because the string data type is used so frequently, 
    you can use this format:
*/
string shortenedString = "Hello World!";
Console.WriteLine(shortenedString);

/*
    Your choice of a data type can help to set the boundaries for the size of the data you might store in that particular variable. 
    For example, if you know a particular variable should only store a number between 1 and 10,000 otherwise it's outside of the 
    boundaries of what would be expected, you would likely avoid byte and sbyte since their ranges are too low.

    Furthermore, you would likely not need int, long, uint, and ulong because they can store more data than is necessary. 
    Likewise, you would probably skip float, double, and decimal if you didn't need fractional values. You might narrow it down 
    to short and ushort, of which both may be viable. If you're confident that a negative value would have no meaning in your 
    application, you might choose ushort (positive unsigned integer, 0 to 65,535). Now, any value assigned to a 
    variable of type ushort outside of the boundary of 0 to 65535 would throw an exception, thereby subtly helping you 
    nforce a degree of sanity checking in your application.
*/
//You may be tempted to choose the data type that uses the fewest bits to store data thinking it improves your 
//application's performance. However, some of the best advice related to application performance 
//(that is, how fast your application runs) is to not "prematurely optimize"

/*
    Sometimes, you must consider how the information will be consumed by other applications or other systems like a database. 
    For example, SQL Server's type system is different from C#'s type system. As a result, some mapping between the two must happen 
    before you can save data into that database.

    If your application's purpose is to interface with a database, then you would likely need to consider how the data is stored 
    and how much data is stored. The choice of a larger data type might impact the amount (and cost) of the physical storage 
    required to store all the data your application will generate.
*/
/*
    
    int for most whole numbers
    decimal for numbers representing money
    bool for true or false values
    string for alphanumeric value
    
    byte: working with encoded data that comes from other computer systems or using different character sets.
    double: working with geometric or scientific purposes. double is used frequently when building games involving motion.
    System.DateTime for a specific date and time value.
    System.TimeSpan for a span of years / months / days / hours / minutes / seconds / milliseconds.
*/

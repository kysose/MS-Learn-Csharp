// 	Create readable code with conventions, whitespace, and comments in C#

/*There are some variable naming rules that are enforced by the C# compiler.

    Variable names can contain alphanumeric characters and the underscore character. 
    Special characters like the pound #, the dash -, and the dollar sign $ are not allowed.
    Variable names must begin with an alphabetical letter or an underscore, not a number. 
    Developers use the underscore for a special purpose, so try to not use that for now.
    Variable names must NOT be a C# keyword. For example, these variable name declarations won't be allowed: float float; or string string;.
    Variable names are case-sensitive, meaning that string MyValue; and string myValue; are two different variables.

Variable name conventions

    
    Variable names should use camel case, which is a style of writing that uses a lower-case letter at the beginning of the 
    first word and an upper-case letter at the beginning of each subsequent word. For example: string thisIsCamelCase;.
    Variable names should be descriptive and meaningful in your application. You should choose a name for your variable that represents 
    the kind of data it will hold (not the data type). For example: bool orderComplete;, NOT bool isComplete;.
    Variable names should be one or more entire words appended together. Don't use contractions because 
    the name of the variable may be unclear to others who are reading your code. For example: decimal orderAmount;, NOT decimal odrAmt;.
    Variable names shouldn't include the data type of the variable. You might see some advice to use a style like string strMyValue;. 
    It was a popular style years ago. However, most developers don't follow this advice anymore and there are good reasons not to use it.

*/

char userOption;

int gameScore;

float particlesPerMillion;

bool processedCustomer;

/*
Comments are useful in three situations:

    When you want to leave a note about the intent of a passage of code. It can be helpful to include code comments that describe the purpose 
    or the thought process when you're writing a particularly challenging set of coding instructions. Your future self will thank you.
    
    When you want to temporarily remove code from your application to try a different approach, but you're not yet convinced your new idea 
    will work. You can comment out the code, write the new code, and once you're convinced the new code will work the way you want it to, 
    you can safely delete the old (commented code).
    
    Adding a message like TODO to remind you to look at a given passage of code later. While you should use this judiciously, it's a useful 
    approach. You may be working on another feature when you read a line of code that sparks a concern. Rather than ignoring the new concern, 
    you can mark it for investigation later.
*/

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/

Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

// ------ RECAP ------
/*
The main takeaways from this exercise:

    Use code comments to leave meaningful notes to yourself about the problem your code solves.
    Don't use code comments that explain how C# or the .NET Class Library works.
    Use code comments when temporarily trying alternative solutions until you're ready to commit to the new code solution, at which point you can delete the old code.
    Never trust comments. They may not reflect the current state of the code after many changes and updates.
*/
// ------ WHITESPACES RECAP ------
// Couldn't be bothered with this one in VS Code
/*
    Use whitespace judiciously to improve the readability of your code.
    Use line feeds to create empty lines to separate phrases of code. A phrase includes lines of code that are similar, or work together.
    Use line feeds to separate code block symbols so that they are on their own line of code.
    Use the tab key to line up a code block with the keyword they're associated with.
    Indent code inside of a code block to show ownership.
*/

// ------ CHALLENGE ------
/*
First convert the message to a char array, then reverse the array. Print out reversed mesage.
Secondly count every "o"-letter and print out how many there are.
*/
string str = "The quick brown fox jumps over the lazy dog.";

char[] charMessage = str.ToCharArray();

Array.Reverse(charMessage);
int x = 0;

foreach (char i in charMessage) 
{ 
    if (i == 'o') 
    { 
        x++; 
    } 
}

Console.WriteLine(new String(charMessage));
Console.WriteLine($"'o' appears {x} times.");

// ------ MS LEARN SOLUTION ------
/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.


string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");
*/
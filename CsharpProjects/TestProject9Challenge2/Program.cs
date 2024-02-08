
//      Add looping logic to your code using the do-while and while statements in C# Challenge 2
/*
    In this challenge, you'll be presented with conditions for three separate coding projects. 
    Each project will require you to implement an iteration code block using either a do-while or a while statement. 
    You'll need to evaluate the specified conditions in order to choose between the do-while and while statements. 
    You can switch after you start if your first choice isn't working out as well as you had hoped.
*/
/*
    When using a Console.ReadLine() statement to obtain user input, it's common practice to use a 
    nullable type string (designated string?) for the input variable and then evaluate the value entered by the user. 
    The following code sample uses a nullable type string to capture user input. The iteration continues while the user-supplied value is null:
        
        string? readResult;
        Console.WriteLine("Enter a string:");
        do
        {
            readResult = Console.ReadLine();
        } while (readResult == null);
    
    The Boolean expression evaluated by the while statement can be used to ensure user input meets a specified requirement. 
    For example, if a prompt asks the user to enter a string that includes at least three characters, the following code could be used:

    string? readResult;
    bool validEntry = false;
    Console.WriteLine("Enter a string containing at least three characters:");
    do
    {
        readResult = Console.ReadLine();
        if (readResult != null)
        {
            if (readResult.Length >= 3)
            {
                validEntry = true;
            }
            else
            {
                Console.WriteLine("Your input is invalid, please try again.");
            }
        }
    } while (validEntry == false);

    If you want to use Console.ReadLine() input for numeric values, you need to convert the string value to a numeric type.

    The int.TryParse() method can be used to convert a string value to an integer. The method uses two parameters, 
    a string that will be evaluated and the name of an integer variable that will be assigned a value. The method returns a Boolean value. 
    The following code sample demonstrates using the int.TryParse() method:

    // capture user input in a string variable named readResult

    int numericValue = 0;
    bool validNumber = false;

    validNumber = int.TryParse(readResult, out numericValue);

    If the string value assigned to readResult represents a valid integer, the value will be assigned to the integer variable 
    named numericValue, and true will be assigned to the Boolean variable named validNumber. 
    If the value assigned to readResult doesn't represent a valid integer, validNumber will be assigned a value of false. 
    For example, if readResult is equal to "7", the value 7 will be assigned to numericValue.
*/

// ------ Code project 1 - write code that validates integer input ------

int userInput = 0;
System.Console.WriteLine("Please enter a value between 5 and 10:");
do
{
    
    userInput = int.Parse(Console.ReadLine());
    if (userInput < 5 || userInput > 10)
    {
        System.Console.WriteLine($"input {userInput} is out of range, please try again");
    }
} while (userInput < 5 || userInput > 10);

// ------ Code project 2 - write code that validates string input ------

System.Console.WriteLine("Please enter role: Administrator|Manager|User");
string role1 = "administrator";
string role2 = "manager";
string role3 = "user";
string userRole = "";

while (userRole == "")
{
    string selectedUserRole = Console.ReadLine();
    selectedUserRole = selectedUserRole.Trim();
    selectedUserRole = selectedUserRole.ToLower();
    if (selectedUserRole == role1 || selectedUserRole == role2 || selectedUserRole == role3){
        userRole = selectedUserRole;
        break;
    }
    else{
        System.Console.WriteLine("User role does not exist, please try again");
    }
}
System.Console.WriteLine($"Your user role has been assigned as {userRole}");

// ------ Code project 3 - Write code that processes the contents of a string array ------

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
string myString = "";
int periodLocation = 0;
int stringLength = myStrings.Length;

for (int i = 0; i < stringLength; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");
    
    string newString;

    while (periodLocation != -1)
    {
        newString = myString.Remove(periodLocation);
        myString = myString.Substring(periodLocation + 1);
        myString = myString.TrimStart();
        periodLocation = myString.IndexOf(".");

        System.Console.WriteLine(newString);
    }
    
    newString = myString.Trim();
    System.Console.WriteLine(newString);
}

// ------ MS LEARN solutions ------
/*
string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        valueEntered = readResult;
    }

    validNumber = int.TryParse(valueEntered, out numValue);

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
    else 
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine();
-----
string? readResult;
string roleName = "";
bool validEntry = false;

do
{                
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        roleName = readResult.Trim();
    }

    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
    {
        validEntry = true;
    }
    else
    {
        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
    }

} while (validEntry == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");
readResult = Console.ReadLine();
 ----
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}
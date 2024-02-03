// Code challenge: write code to display the result of a coin flip
/*
Here are your challenge requirements:

    Use the Random class to generate a value.
    Consider the range of numbers that is required.
    Based on the value generated, use the conditional operator to display either heads or tails.
    There should be a 50% chance that the result is either heads or tails.
    Your code should be easy to read, but with as few lines as possible.
    You should be able to accomplish the desired result in three lines of code.
*/

//Random coin = new();
//int coinFlip = coin.Next(0,2);
//System.Console.WriteLine((coinFlip == 0) ? "heads" : "tails");

// ------ MS LEARN compact solution ------

//Random coin = new Random();
//Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");

/*Decision logic challenge

    In this challenge, you'll implement decision logic based on a series of business rules. 
    The business rules specify the access that will be granted to users based on their role-based permissions and their career level. 
    Code branches will display a different message to the user depending on their permissions and level.
*/

string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        System.Console.WriteLine("Welcome, Super Admin user.");
    }
    else if (level <= 55)
    {
        System.Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level > 20)
    {
        System.Console.WriteLine("Contact Admin for access.");
    }
    else if (level <= 20)
    {
        System.Console.WriteLine("You do not have sufficient privileges.");
    }
}
else System.Console.WriteLine("You do not have sufficient privileges.");
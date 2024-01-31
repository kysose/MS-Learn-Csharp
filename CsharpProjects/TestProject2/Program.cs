//microsoft learn: Add Decision Logic to Your Code Using if, else, and else if statements in C# 
//note this is not 1 to 1 with the actual lesson, I've done some edits for myself -kysose

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if (total > 14) // this is a boolean expression, returns true if total > 14, otherwise it returns false
{
    Console.WriteLine("Spoiler: You win!");
}
if (total < 15)
{
    Console.WriteLine("Spoiler: Sorry, you lose.");
}

// ------ Boolean expression ------

string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog"); // this one check if the string contains another string
Console.WriteLine(result); // "dog" is included in the string so "true"

if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
}

/* ------ Implement the doubles bonus ------
Next, you can implement the rule: "If any two dice you roll result in the same value, you get two bonus points for rolling doubles". 
Modify the code from the previous step to match the following code listing:

Next, you can implement the rule: "If all three dice you roll result in the same value, you get six bonus points for rolling triples." 
Modify the code from the previous steps to match the following code listing:
didn't modify added new code instead: */
Console.WriteLine("\nGame number 2:\n");
int total2 = total; //if statements can't use total2 if it's not declared. It needs to be same as total initially.

// double test roll
//roll1 = 6;
//roll2 = 6;
//roll3 = 5;

// triple test roll
//roll1 = 6;
//roll2 = 6;
//roll3 = 6;


if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) //compound condition. || is logical "OR" operator 
{
    if ((roll1 == roll2) && (roll2 == roll3)) // && is logical "AND" operator
    {
        total2 += 6; //simple way of adding 6
        Console.WriteLine($"You rolled triples! +6 bonus to total! \nTotal is now {total2}");
    }
    else
    {
        total2 = total2 + 2; //easier to understand way of adding 2, but same as previous.
        Console.WriteLine("You rolled doubles! +2 bonus to total!" + $"\nTotal is now: {total2}"); //notice that $ needs to be on the correct string, if we use 2 strings
    }

}
else Console.WriteLine($"No doubles or triples. \nTotal is: {total2}"); // note no {} block needed, when only one line of code

if (total2 >= 15)
{
    Console.WriteLine("You win!");
}
else 
{
    Console.WriteLine("Sorry, you lose.");
}    

/* learn lesson logic change
if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}
*/
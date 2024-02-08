// Add looping logic to your code using the do-while and while statements in C#

Random random = new Random();
int current = random.Next(1, 11);

do // A do-while loop iterates at least once
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    //Console.WriteLine(current); //comment to not mess with challenge printing
} while (current != 7);

/*
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/
/* ------ RECAP ------

There's a few important ideas you should take away from this unit:

    The do-while statement iterates through a code block at least once, and might continue to iterate based on a Boolean expression. The evaluation of the Boolean expression usually depends on some value generated or retrieved inside of the code block.
    The while statement evaluates a Boolean expression first, and continues to iterate through the code block as long as the Boolean expression evaluates to true.
    The continue keyword to step immediately to the Boolean expression.
*/

// ------ CHALLENGE ------
/*write code to implement the game rules

Here are the rules for the battle game that you need to implement in your code project:

    You must use either the do-while statement or the while statement as an outer game loop.
    The hero and the monster will start with 10 health points.
    All attacks will be a value between 1 and 10.
    The hero will attack first.
    Print the amount of health the monster lost and their remaining health.
    If the monster's health is greater than 0, it can attack the hero.
    Print the amount of health the hero lost and their remaining health.
    Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
    Print the winner.
*/
int heroHealth = 10;
int monsterHealth = 10;

do
{
    int heroAttack = random.Next(1,11);
    System.Console.WriteLine($"Hero deals {heroAttack} damage to monster!");
    monsterHealth = monsterHealth - heroAttack;
    System.Console.WriteLine($"Monster health: {monsterHealth}");
    int monsterAttack = random.Next(1,11);
    if (monsterHealth > 0)
    {
        System.Console.WriteLine($"Monster deals {monsterAttack} damage to hero!");
        heroHealth = heroHealth - monsterAttack;
        System.Console.WriteLine($"Hero has {heroHealth} health remaining");
    }
    else break;
    
} while (heroHealth > 0 && monsterHealth > 0);

Console.WriteLine(heroHealth > monsterHealth ? "Winner: Hero!" : "Winner: Monster!");
System.Console.WriteLine("\nROUND 2 will begin in 5 seconds"); // accommodating the MS LEARN solution:
Thread.Sleep(new TimeSpan(0, 0, 1));
System.Console.WriteLine("4");
Thread.Sleep(new TimeSpan(0, 0, 1));
System.Console.WriteLine("3");
Thread.Sleep(new TimeSpan(0, 0, 1));
System.Console.WriteLine("2");
Thread.Sleep(new TimeSpan(0, 0, 1));
System.Console.WriteLine("1");
Thread.Sleep(new TimeSpan(0, 0, 1));
System.Console.WriteLine("\nMortal Kombat music plays...\n\nFIGHT!!!\n");
Thread.Sleep(new TimeSpan(0, 0, 1));
// ------ MS LEARN solution ------
int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
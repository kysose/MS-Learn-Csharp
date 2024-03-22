// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult; //nullable type variable - accepts 'null' if no input given
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;

        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;

        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;

        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;

    }


    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

do
{
    // display the top-level menu options

    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

    //Console.WriteLine($"You selected menu option {menuSelection}.");
    //Console.WriteLine("Press the Enter key to continue");

    // pause code execution
    //readResult = Console.ReadLine();

    switch (menuSelection)
    {
        case "0": //my secret exit - I've become too lazy to write exit million times during this module
            menuSelection = "exit";
            break;
        case "1":
            // List all of our current pet information
            /*
                The first dimension of the ourAnimals array corresponds to the different pets.
                The second dimension of the ourAnimals array corresponds to the characteristics of each pet.
                The if statement prevents the inner loop from running when there's no pet data assigned to the current pet.
                The inner loop completes all of its iterations for each iteration of the outer loop.
            */
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ") //ignores the id when it is set to default!
                {
                    System.Console.WriteLine(); //this one creates the empty line between pets
                    for (int j = 0; j < 6; j++) // j<6 because we store 6 characteristics
                    {
                        System.Console.WriteLine(ourAnimals[i, j]);
                    }
                }
            }
            System.Console.WriteLine("Pess the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "2":
            // Add a new animal  friend to teh ourAnimals array
            string anotherPet = "y";
            int petCount = 0;
            for (int i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    petCount += 1;
                }
            }

            if (petCount < maxPets)
            {
                Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
            }

            while (anotherPet == "y" && petCount < maxPets)
            {
                bool validEntry = false;

                //get species
                do
                {
                    Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalSpecies = readResult.ToLower();
                        if (animalSpecies != "dog" && animalSpecies != "cat")
                        {
                            //Console.WriteLine($"You entered: {animalSpecies}.");
                            validEntry = false;
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);

                // build the animal ID number - e.g. C for cat, D for dog
                animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

                //get the pet's age. Can be ? at initial entry.
                do
                {
                    int petAge;
                    System.Console.WriteLine("Enter the pet's age or enter ? if unknown");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalAge = readResult;
                        if (animalAge != "?")
                        {
                            validEntry = int.TryParse(animalAge, out petAge);
                        }
                        else
                        {
                            validEntry = true;
                        }
                    }
                } while (validEntry == false);

                //get pet description
                do
                {
                    System.Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPhysicalDescription = readResult.ToLower();
                        if (animalPersonalityDescription == "")
                        {
                            animalPhysicalDescription = "tbd";
                        }
                    }
                } while (animalPhysicalDescription == "");

                // get a description of pet personality
                do
                {
                    System.Console.WriteLine("Enter a description of pet's personality (likes or dislikes, tricks, energy level)");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalPersonalityDescription = readResult.ToLower();
                        if (animalPersonalityDescription == "")
                        {
                            animalPersonalityDescription = "tbd";
                                }
                    }
                } while (animalPersonalityDescription == "");

                // get the pet's nickname
                do
                {
                    Console.WriteLine("Enter a nickname for the pet");
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        animalNickname = readResult.ToLower();
                        if (animalNickname == "")
                        {
                            animalNickname = "tbd";
                        }
                    }
                } while (animalNickname == "");

                //store the information in the ourAnimals array
                ourAnimals[petCount, 0] = "ID #: " + animalID;
                ourAnimals[petCount, 1] = "Species: " + animalSpecies;
                ourAnimals[petCount, 2] = "Age: " + animalAge;
                ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
                ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
                ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

                // increment petCount (the array is zero-based, so we increment the counter after adding to the array)
                petCount = petCount + 1;

                // check maxPet limit
                if (petCount < maxPets)
                {
                    // another pet?
                    Console.WriteLine("Do you want to enter info for another pet (y/n)");
                    do
                    {
                        readResult = Console.ReadLine();

                        if (readResult != null)
                        {
                            anotherPet = readResult.ToLower();
                        }

                    } while (anotherPet != "y" && anotherPet != "n");
                }
            }

            if (petCount >= maxPets)
            {
                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                Console.WriteLine("Press the Enter key to continue.");
                readResult = Console.ReadLine();
            }

            break;

        case "3":
            // Ensure animal ages and physical descriptions are complete
            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "4":
            // Ensure animal nicknames and personality descriptions are complet
            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "5":
            // Edit an animal’s age
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "6":
            // Edit an animal’s personality description
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "7":
            // Display all cats with a specified characteristic
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "8":
            // Display all dogs with a specified characteristic
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        default:
            break;
    }

} while (menuSelection != "exit");

/*
Take a minute to consider the choice between a for statement and a foreach statement when iterating through the ourAnimals array.
The goal is to iterate through each animal in the ourAnimals array one at a time. So why not use a foreach loop? After all, 
you know that the foreach statement is designed for cases when you want to iterate through each item in an array of items.
The reason why you don't use a foreach loop in this situation is because the ourAnimals array is multidimensional array. 

Since ourAnimals is a multidimensional string array, each element contained within ourAnimals is a separate item of type string. 
If you used a foreach loop to iterate through ourAnimals, the foreach would recognize each string as a separate item 
in a list of 48 string items (8 x 6 = 48). The foreach statement wouldn't process the two array dimensions separately. 
In other words, a foreach loop won't recognize 8 rows of string elements, where each row contains a column of 6 items. 
Since you want to work with one animal at a time, and process all six animal characteristics during a single iteration, a foreach statement 
isn't the right choice.
However, if the ourAnimals array was a jagged array configured as an array of string arrays, you could use a foreach statement. 
In this case, you would create a foreach for an outer loop and second foreach for an inner loop. The outer loop would iterate through 
the "string array" elements in the jagged array. The string arrays are the "rows" in the two-dimensional array. The inner loop would 
iterate through the "string" elements contained in the string arrays. The string elements in the string arrays are the "columns" 
in the two-dimensional array.
The following code sample demonstrates the jagged array approach.

string[][] jaggedArray = new string[][]
{
    new string[] { "one1", "two1", "three1", "four1", "five1", "six1" },
    new string[] { "one2", "two2", "three2", "four2", "five2", "six2" },
    new string[] { "one3", "two3", "three3", "four3", "five3", "six3" },
    new string[] { "one4", "two4", "three4", "four4", "five4", "six4" },
    new string[] { "one5", "two5", "three5", "four5", "five5", "six5" },
    new string[] { "one6", "two6", "three6", "four6", "five6", "six6" },
    new string[] { "one7", "two7", "three7", "four7", "five7", "six7" },
    new string[] { "one8", "two8", "three8", "four8", "five8", "six8" }
};

foreach (string[] array in jaggedArray)
{
    foreach (string value in array)
    {
        Console.WriteLine(value);
    }
    Console.WriteLine();
}

For the Contoso Pets application, it's probably easier to use a multidimensional string array and nested for loops rather than 
a jagged array and nested foreach loops. Now that you see how each option works, you can make your own choice in future coding projects.
*/
/*
The scope of your variables should always be as narrow as possible. 
In the Contoso Pets application, you could scope petCount at the application level rather than scoping to the case "2": code block. 
The larger scope would enable you to access petCount from anywhere in the application. If petCount was scoped at the application level, 
you could assign it a value when you create the sample data and programmatically manage its value throughout the remainder of the application. 
For example, when you find a home for a pet and remove the pet from the ourAnimals array, you could reduce petCount by 1. 
The question is, at what level should you scope a variable when you're unsure whether it will be used in other parts of your application? 
In this case, it's tempting to scope petCount at the application level even though you aren't using it anywhere else. 
After all, scoping petCount at the application level ensures that it's available if you do decide to use it elsewhere. 
Maybe you could scope other variables at the application level as well. That way, your variables are always in scope and accessible. 
So why not scope variables at the application level when you think they might be used later in the application? 
Scoping variables at a higher level than necessary can lead to problems. Elevated scope inflates the resource requirements of your application 
and may expose your application to unnecessary security risks. As your applications grow larger and more complex, they require more resources. 
Phones and computers allocate memory for these resources when they're in scope. As your applications become more "real-world", 
they become more accessible. Applications are often accessible from the cloud or other applications. Compounding these issues, 
applications are often left running when they aren't being used. It's important to keep an application's resource requirements under control 
and the security footprint as small as possible. Although today's operating systems do a great job of managing resources 
and securing applications, it's still best practice to keep your variables scoped to the level where they are actually needed. 
In your Contoso Pets app, if you decide to use petCount more broadly within the application, you can update your code to scope petCountat 
a higher level. Remember to keep your variables scoped as narrowly as possible, and only increase their scope when it becomes necessary.
*/

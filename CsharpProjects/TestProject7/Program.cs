﻿// 	Branch the flow of code using the switch-case construct in C# 

string fruit = "banana";

switch (fruit)
{
    case "apple": // true if fruit == "apple"
        System.Console.WriteLine($"App will display information for apple.");
        break;

    case "banana":
        System.Console.WriteLine($"App will display information for banana");
        break;

    case "cherry":
        System.Console.WriteLine($"App will display information for cherry");
        break;
}

int employeeLevel = 200;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
        title = "Junior Associate";
        break;
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default: // default is optional
        title = "Associate";
        break; // break can be replaced with return
}

Console.WriteLine($"{employeeName}, {title}");
    
    //case 100:
    //case 200:
    //    title = "Senior Associate";
    // now both level 100 and 200 will have the same title

// ------ CHALLENGE ------

//update the code to a switch statement
// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01":
        type = "Sweat shirt";
        break;

    case "02":
        type = "T-Shirt";
        break;

    case "03":
        type = "Sweat pants";
        break;

    default: 
        type = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        color = "Black";
        break;

    case "MN":
        color = "Maroon";
        break;
    
    default:
        color = "White";
        break;
}

switch (product[2])
{
    case "S":
        size = "Small";
        break;

    case "M":
        size = "Medium";
        break;

    case "L":
        size = "Large";
        break;

    default:
        size = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {size} {color} {type}");
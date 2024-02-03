// 		Evaluate Boolean expressions to make decisions in C# 

//string value1 = " a";
//string value2 = "A ";
//Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

//Console.WriteLine("a" != "a"); // != is the inequality operator as in "not equal to" here it returns 'False' since "a" == "a"
//Console.WriteLine("a" != "A");
//Console.WriteLine(1 != 2);
//
//string myValue = "a";
//Console.WriteLine(myValue != "a");

//Console.WriteLine(1 > 2);
//Console.WriteLine(1 < 2);
//Console.WriteLine(1 >= 1);
//Console.WriteLine(1 <= 1);

/*  Some data types have methods that perform helpful utility tasks. 
    The String data type has many of these. Several return a Boolean value including
    Contains(), StartsWith(), and EndsWith(). You can learn more about them in the Microsoft Learn module 
    "Manipulate alphanumeric data using String class methods in C#".
*/    

//string pangram = "The quick brown fox jumps over the lazy dog.";
//Console.WriteLine(pangram.Contains("fox"));
//Console.WriteLine(pangram.Contains("cow"));

/*What is logical negation?

    The term "Logical Negation" refers to the unary negation operator !. 
    Some people call this operator the "not operator". When you place the ! operator before a conditional expression 
    (or any code that's evaluated to either true or false), it forces your code to reverse its evaluation of the operand. 
    When logical negation is applied, the evaluation produces true , if the operand evaluates to false , and false , 
    if the operand evaluates to true.

    Here is an example that might help you to see the connection between these ideas. 
    The following two lines of code produce the same result. The second line is more compact.

    // These two lines of code will create the same output
    Console.WriteLine(pangram.Contains("fox") == false);
    Console.WriteLine(!pangram.Contains("fox"));

*/

//string pangram = "The quick brown fox jumps over the lazy dog.";
//Console.WriteLine(!pangram.Contains("fox")); // False -> !pangram.Contains() checks that the string does not contain
//Console.WriteLine(!pangram.Contains("cow")); // True
//
//int a = 7;
//int b = 6;
//Console.WriteLine(a != b); // output: True
//string s1 = "Hello";
//string s2 = "Hello";
//Console.WriteLine(s1 != s2); // output: False

// ------ Recap ------
/*
Here's the main takeaways you learned about evaluating Boolean expressions so far:

    There are many different kinds of expressions that evaluate to either true or false.
    Evaluate equality using the == operator.
    Evaluating equality of strings requires you to consider the possibility that the strings have different case and leading or trailing spaces. Depending on your situation, use the ToLower() or ToUpper() helper methods, and the Trim() helper method to improve the likelihood that two strings are equal.
    Evaluate inequality using the != operator.
    Evaluate greater than, less than and similar operations using comparison operators like >, <, >=, and <=.
    If a method returns a bool, it can be used as a Boolean expression.
    Use the logical negation operator ! to evaluate the opposite of a given expression.
*/

// ------ CONDITIONAL OPERATOR ------
/*
The conditional operator ?: evaluates a Boolean expression and returns one of two results depending on whether the Boolean expression evaluates to true or false. The conditional operator is commonly referred to as the ternary conditional operator.

Here's the basic form:
    
    <evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

*/

int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;
// conditional operator statement has to be inside parentheses

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}"); // if over 1000 discount = 100, otherwise 50
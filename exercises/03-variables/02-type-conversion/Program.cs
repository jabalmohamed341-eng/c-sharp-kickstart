// Exercise 03-02: Type Conversion
// Create a program that demonstrates converting between different data types

using System;

Console.WriteLine("Type Conversion Demonstration");
Console.WriteLine("============================");
Console.WriteLine("");

Console.WriteLine("String to Number Conversion:");
// TODO: Create string variables and convert them to numbers
// Example:
 string ageText = "25";
 int age = int.Parse(ageText);
 Console.WriteLine("Age as text: \"" + ageText + "\"");
 Console.WriteLine("Age as number: " + age);

Console.WriteLine("");
Console.WriteLine("Number to String Conversion:");
// TODO: Create number variables and convert them to strings
// Example:
 int score = 95;
string scoreText = score.ToString();
Console.WriteLine("Score as number: " + score);
Console.WriteLine("Score as text: \"" + scoreText + "\"");

Console.WriteLine("");
Console.WriteLine("Explicit Casting:");
// TODO: Demonstrate casting from double to int
// Example:
double originalPrice = 29.99;
int roundedPrice = (int)originalPrice;
Console.WriteLine("Original Price: $" + originalPrice);
Console.WriteLine("Rounded Price: $" + roundedPrice);


Console.WriteLine("");
Console.WriteLine("Mixed Type Calculations:");
// TODO: Perform calculations with different data types
int quantity = 3;
decimal price = 19.99m;
decimal totalPrice = (decimal)quantity * price;

// Display results
Console.WriteLine("Total Price for " + quantity + " items at $" + price + " each: $" + totalPrice);

// Example: multiply int quantity by decimal price
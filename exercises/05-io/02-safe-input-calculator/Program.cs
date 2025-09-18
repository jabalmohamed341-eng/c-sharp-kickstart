// Exercise 05-02: Safe Input Calculator
// Create a calculator that safely handles invalid user input

using System;

Console.WriteLine("Safe Input Calculator");
Console.WriteLine("====================");
Console.WriteLine("");

// TODO: Get first number
Console.Write("Enter first number: ");
string input1 = Console.ReadLine();
double firstNumber = double.Parse(input1);

// TODO: Get second number
Console.Write("Enter second number: ");
string input2 = Console.ReadLine();
double secondNumber = double.Parse(input2);

// TODO: Get operation
Console.Write("Enter operation (+, -, *, /): ");
string operation = Console.ReadLine();

// TODO: Perform calculation with basic error checking
 double result = 0;
//
 if (operation == "+")
 {
     result = firstNumber + secondNumber;
 }
 else if (operation == "-")
 {
     result = firstNumber - secondNumber;
 }
 else if (operation == "*")
 {
     result = firstNumber * secondNumber;
 }
 else if (operation == "/")
 {
    if (secondNumber != 0)
    {
        result = firstNumber / secondNumber;
    }
    else
    {
        Console.WriteLine("Error: Cannot divide by zero!");
        return;
     }
 }
 else
 {
     Console.WriteLine("Error: Invalid operation!");
 }

// TODO: Display result using string interpolation
//F2: format for 2 decimal places
Console.WriteLine($"Calculation: {firstNumber} {operation} {secondNumber} = {result:F2}");
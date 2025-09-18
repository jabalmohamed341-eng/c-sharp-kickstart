// Exercise 03-01: Personal Information
// Create a program that stores and displays personal information using variables

using System;

// TODO: Declare variables for personal information
// Variables: firstName, lastName, age, height (in meters), isStudent
// Use appropriate data types: string, int, double, bool

// Example:
// string firstName = "Your Name";

string firstName = "John";
string lastName = "Doe";
int age = 30;
double height = 1.75;
bool isStudent = false;
int currentYear = 2025;
int birthYear = currentYear - age;
int favoriteNumber = 7;
Console.WriteLine("Personal Information");
Console.WriteLine("===================");

// TODO: Display the information using the variables
// Format: "Name: " + firstName + " " + lastName
Console.WriteLine("Name: " + firstName + " " + lastName);
Console.WriteLine("Age: " + age);
Console.WriteLine("Height: " + height + " meters");
Console.WriteLine("Is a student: " + (isStudent ? "Yes" : "No"));
Console.WriteLine("Birth Year: " + birthYear);
Console.WriteLine("Favorite Number: " + favoriteNumber);

// TODO: Calculate and display birth year
// int currentYear = 2024;
// int birthYear = currentYear - age;
// Exercise 05-01: User Information Collector
// Create a program that collects user information and displays a summary

using System;

Console.WriteLine("User Information Collector");
Console.WriteLine("=========================");
Console.WriteLine("");
Console.WriteLine("Please enter your information:");
Console.WriteLine("");

// TODO: Collect user information
// Use Console.ReadLine() for all input
// Convert strings to appropriate data types

Console.Write("First name: ");
string firstName = Console.ReadLine();

Console.Write("Last name:");
string lastName = Console.ReadLine();

Console.Write("Age: ");
int age = int.Parse(Console.ReadLine());

Console.Write("Height in cm:");
double height = double.Parse(Console.ReadLine());

Console.Write("Favorite number: ");
int favoriteNumber = int.Parse(Console.ReadLine());

Console.Write("Are you a student? (yes/no): ");
 string studentInput = Console.ReadLine();
bool isStudent = studentInput.ToLower() == "yes";

Console.WriteLine("");
Console.WriteLine("Summary");
Console.WriteLine("=======");

// TODO: Display formatted summary using string interpolation
 Console.WriteLine($"Name: {firstName} {lastName}");
 Console.WriteLine($"Age: {age} years old");
 Console.WriteLine($"Height: {height} cm");
 Console.WriteLine($"Favorite Number: {favoriteNumber}");
 Console.WriteLine($"Student Status: {(isStudent ? "Yes" : "No")}");

Console.WriteLine("");
Console.WriteLine("Thank you for using the User Information Collector!");
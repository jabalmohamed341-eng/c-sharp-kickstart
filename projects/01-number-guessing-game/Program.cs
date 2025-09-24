// Project 1: Number Guessing Game
// A complete game that combines variables, I/O, selections, and iterations

using System;

Console.WriteLine("🎯 Number Guessing Game");
Console.WriteLine("======================");
Console.WriteLine("");

// TODO: Initialize game variables
Random random = new Random();
bool playAgain = true;
int gamesPlayed = 0;
int totalAttempts = 0;
int bestScore = 0;

// TODO: Main game loop
while (playAgain)
{
    // Start new round
    gamesPlayed++;
    int secretNumber = random.Next(1, 101);
    int attempts = 0;
    bool gameWon = false;

    Console.WriteLine($"🎯 Number Guessing Game - Round {gamesPlayed}");
    Console.WriteLine("I'm thinking of a number between 1 and 100...");
    Console.WriteLine("");

    //     // TODO: Guessing loop
    while (!gameWon)
    {
        //         // TODO: Get and validate user guess
        int guess;
        while (true)
        {
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out guess) && guess >= 1 && guess <= 100)
            {
                break;
            }
            Console.WriteLine("Invalid input. Please enter a number between 1 and 100.");
        }
        //         // TODO: Provide feedback (too high, too low, correct)
        attempts++;
        if (guess < secretNumber)
        {
            Console.WriteLine("Too low! Try again.");
        }
        else if (guess > secretNumber)
        {
            Console.WriteLine("Too high! Try again.");
        }
        else
        {
            Console.WriteLine($"Correct! You've guessed the number {secretNumber} in {attempts} attempts.");
            gameWon = true;
            totalAttempts += attempts;
            int score = Math.Max(100 - (attempts - 1) * 10, 10);
            bestScore = bestScore == 0 ? score : Math.Max(bestScore, score);
            Console.WriteLine($"You scored {score} points this round.");
        }
        //         // TODO: Count attempts
        //         // TODO: Check if game is won
        if (gameWon) break;

        //         // TODO: Check if game is won
    }
    //     
    //     // TODO: Calculate and display score
    //     // TODO: Check if player wants to play again
    // }
    //     // TODO: Update statistics
    //     // TODO: Ask if player wants to play again
    Console.Write("Do you want to play again? (y/n): ");
    string playAgainInput = Console.ReadLine().ToLower();
    playAgain = (playAgainInput == "y" || playAgainInput == "yes");
    if (!playAgain)
    {
        Console.WriteLine("Exiting the game...");
    }   
    // }

    // TODO: Display final statistics
    Console.WriteLine("Game Statistics:");
    Console.WriteLine("===============");
    Console.WriteLine($"Games Played: {gamesPlayed}");
    Console.WriteLine($"Total Attempts: {totalAttempts}");
    Console.WriteLine($"Average Attempts: {(double)totalAttempts / gamesPlayed:F1}");
    Console.WriteLine($"Best Score: {bestScore} points");

    Console.WriteLine("");
    Console.WriteLine("Thanks for playing!");
}
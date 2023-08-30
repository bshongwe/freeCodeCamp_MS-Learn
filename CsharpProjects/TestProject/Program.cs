﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello C#!");

// Random dice = new Random();
// int roll = dice.Next(1, 7);
// Console.WriteLine(roll);

// Overloaded methods
// #1.
// int number = 7;
// string text = "seven";

// Console.WriteLine(number);
// Console.WriteLine();
// Console.WriteLine(text);

// #2.
// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");
// dice.Next(0);

// Math class methods challenge
// int firstValue = 500;
// int secondValue = 600;
// int largerValue;

// largerValue = Math.Max(firstValue, secondValue);

// Console.WriteLine(largerValue);

// Create decision logic with if statements
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// Add another if statement to implement the doubles bonus
if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    // Console.WriteLine("You rolled doubles! +2 bonus to total!");
    Console.WriteLine("You rolled triples! +6 bonus to total!"); // modified new Writeline
    total += 2;
}

// Add an if statement to display different messages based on the value of the total variable
if (total >= 15) // changed second if
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello C#!");

// Random dice = new Random();
// int roll = dice.Next(1, 7);
// Console.WriteLine(roll);

// Overloaded methods
// #1.
int number = 7;
string text = "seven";

Console.WriteLine(number);
Console.WriteLine();
Console.WriteLine(text);

// #2.
Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
dice.Next(0);
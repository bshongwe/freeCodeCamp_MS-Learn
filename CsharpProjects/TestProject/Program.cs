// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello C#!");

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
// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// Add another if statement to implement the doubles bonus
// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     // Console.WriteLine("You rolled doubles! +2 bonus to total!");
//     Console.WriteLine("You rolled triples! +6 bonus to total!"); // modified new Writeline
//     total += 2;
// }

// Add an if statement to display different messages based on the value of the total variable
// if (total >= 15) // changed second if
// {
//     Console.WriteLine("You win!");
// }

// if (total < 15)
// {
//     Console.WriteLine("Sorry, you lose.");
// }

// Exercise - Create nested decision logic with if, else if, and else
// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// Hardcode Test
// roll1 = 6;
// roll2 = 6;
// roll3 = 5;
// roll3 = 6; // Hard test step 2

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     if ((roll1 == roll2) && (roll2 == roll3))
//     {
//         Console.WriteLine("You rolled triples!  +6 bonus to total!");
//         total += 6;
//     }
//     else
//     {
//         Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//         total += 2;
//     }
// }

// if (total >= 15)
// {
//     Console.WriteLine("You win!");
// }
// else 
// {
//     Console.WriteLine("Sorry, you lose.");
// }

// Use if, else, and else if statements to give a prize instead of a win-lose message - reset code to re-run hard-test
// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     if ((roll1 == roll2) && (roll2 == roll3))
//     {
//         Console.WriteLine("You rolled triples!  +6 bonus to total!");
//         total += 6;
//     }
//     else
//     {
//         Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//         total += 2;
//     }
// }

// if (total >= 16)
// {
//     Console.WriteLine("You win a new car!");
// }
// else if (total >= 10)
// {
//     Console.WriteLine("You win a new laptop!");
// }
// else if (total == 7)
// {
//     Console.WriteLine("You win a trip for two!");
// }
// else
// {
//     Console.WriteLine("You win a kitten!");
// }

// Complete a challenge activity to apply business rules Exercise
// Random random = new Random();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// Your code goes here - (solution below)
// if (daysUntilExpiration == 0)
// {
//     Console.WriteLine("Your subscription has expired.");
// }
// else if (daysUntilExpiration == 1)
// {
//     Console.WriteLine("Your subscription expires within a day!");
//     discountPercentage = 20;
// }
// else if (daysUntilExpiration <= 5)
// {
//     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
//     discountPercentage = 10;
// }
// else if (daysUntilExpiration <= 10)
// {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }

// if (discountPercentage > 0)
// {
//     Console.WriteLine($"Renew now and save {discountPercentage}%.");
// }

// Exercise - Get started with array basics
/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";
*/

// string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

// Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// fraudulentOrderIDs[0] = "F000";

// Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");

// Exercise - Implement the foreach statement
// string[] names = { "Rowena", "Robin", "Bao" };
// foreach (string name in names)
// {
//     Console.WriteLine(name);
// }

// array of int
// int[] inventory = { 200, 450, 700, 175, 250 };
// int sum = 0;
// int bin = 0;
// foreach (int items in inventory)
// {
//     sum += items;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
// }
// Console.WriteLine($"We have {sum} items in inventory.");

// nested iteration and selection statements challenge activity
// string[] orderIDs = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

// foreach (string orderID in orderIDs)
// {
//     if (orderID.StartsWith("B"))
//     {
//         Console.WriteLine(orderID);
//     }
// }

// Exercise - Create effective code comments
//#1.
// string firstName = "Bob";
// int widgetsPurchased = 7;
// // Testing a change to the message.
// int widgetsSold = 7;
// Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
// Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");

//#2.
/*
string firstName = "Bob";
int widgetsPurchased = 7;
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
*/
// Random random = new Random();
// string[] orderIDs = new string[5];
// Loop through each blank orderID
// for (int i = 0; i < orderIDs.Length; i++)
// {
    // Get a random value that equates to ASCII letters A through E
    // int prefixValue = random.Next(65, 70);
    // Convert the random value into a char, then a string
    // string prefix = Convert.ToChar(prefixValue).ToString();
    // Create a random number, pad with zeroes
    // string suffix = random.Next(1, 1000).ToString("000");
    // Combine the prefix and suffix together, then assign to current OrderID
    // orderIDs[i] = prefix + suffix;
// }
// Print out each orderID
// foreach (var orderID in orderIDs)
// {
    // Console.WriteLine(orderID);
// }

// #2.2
// /*
//   The following code creates five random OrderIDs
//   to test the fraud detection process.  OrderIDs 
//   consist of a letter from A to E, and a three
//   digit number. Ex. A123.
// */
// Random random = new Random();
// string[] orderIDs = new string[5];

// for (int i = 0; i < orderIDs.Length; i++)
// {
//     int prefixValue = random.Next(65, 70);
//     string prefix = Convert.ToChar(prefixValue).ToString();
//     string suffix = random.Next(1, 1000).ToString("000");

//     orderIDs[i] = prefix + suffix;
// }

// foreach (var orderID in orderIDs)
// {
//     Console.WriteLine(orderID);
// }

// #3.
/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

// string originalMessage = "The quick brown fox jumps over the lazy dog.";

// char[] message = originalMessage.ToCharArray();
// Array.Reverse(message);

// int letterCount = 0;

// foreach (char letter in message)
// {
//     if (letter == 'o')
//     {
//         letterCount++;
//     }
// }

// string newMessage = new String(message);

// Console.WriteLine(newMessage);
// Console.WriteLine($"'o' appears {letterCount} times.");

// Do and while challenge activity
int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

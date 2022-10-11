// //roll 3 dices using random function
// Random dice = new Random();
// int dice1 = dice.Next(1, 7);
// int dice2 = dice.Next(1, 7);
// int dice3 = dice.Next(1, 7);

// // dice1 = 6;
// // dice2 = 6;
// // dice3 = 6;

// int total = dice1 + dice2 + dice3;
// Console.WriteLine("Dice 1: " + dice1);
// Console.WriteLine("Dice 2: " + dice2);
// Console.WriteLine("Dice 3: " + dice3);
// //print "Dice roll: dice1 + dice2 + dice3 = total"
// Console.WriteLine("Dice roll: " + dice1 + " + " + dice2 + " + " + dice3 + " = " + total);

// //if total greater than 14  print "You win!" else print "You lose!"



// //if two of dice are same add 2 to total
// if (dice1 == dice2 || dice1 == dice3 || dice2 == dice3)
// {
//     //if all three dice are same add 6 to total
//     if (dice1 == dice2 && dice1 == dice3)
//     {
//         total += 6;
//         Console.WriteLine("You rolled triples! +6 bonus to total!");
//     }
//     else
//     {
//         total += 2;
//         Console.WriteLine("You rolled doubles! +2 bonus to total!");
//     }
// }

// if (total >= 16)
// {
//     Console.WriteLine("You win a new car");
// }
// else if (total >= 10)
// {
//     Console.WriteLine("You win a new laptop");
// }
// else if (total == 7)
// {
//     Console.WriteLine("You win a trip for two!");
// }
// else
// {
//     Console.WriteLine("You win a kitten!");
// }

// string message = "The quick brown fox jumps over the lazy dog.";
// bool result = message.Contains("dog");
// Console.WriteLine(result);

// if (message.Contains("fox"))
// {
//     Console.WriteLine("What does the fox say?");
// }



Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;
// print daysUntilExpiration
Console.WriteLine("Days until expiration: " + daysUntilExpiration);

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    Console.WriteLine("Your subscription expires within a day!\nRenew now and save " + discountPercentage + "%!");
}
else if (daysUntilExpiration <= 5)
{
    discountPercentage = 10;
    Console.WriteLine("Your subscription expires in " + daysUntilExpiration + " days.\nRenew now and save " + discountPercentage + "%!");
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription expires soon. Renew now!");
}
else
{}
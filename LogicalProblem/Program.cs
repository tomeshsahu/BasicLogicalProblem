using System;
using LogicalProblem;


Console.WriteLine("Welcome to Basic Programs");
Console.WriteLine("1.FlipCoin");
Console.WriteLine("Take an option to execute");
int Option=Convert.ToInt32(Console.ReadLine());
switch (Option)
{
    case 1:
        FlipCoin Coin = new FlipCoin();
        Coin.Flip();
        break;
    default:
        Console.WriteLine("Enter proper Option to Execute");
        break;
}
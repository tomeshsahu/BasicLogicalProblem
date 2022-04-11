using System;
using LogicalProblem;


Console.WriteLine("Welcome to Basic Programs");
Console.WriteLine("1.FlipCoin\n2.LeapYear\n3.Power");
Console.WriteLine("Take an option to execute");
int Option=Convert.ToInt32(Console.ReadLine());
switch (Option)
{
    case 1:
        FlipCoin Coin = new FlipCoin();
        Coin.Flip();
        break;
    case 2:
        LeapYear Leap = new LeapYear();
        Leap.Year();
        break;
    case 3:
        Power Powr = new Power();
        Powr.Powerv();
        break;
    default:
        Console.WriteLine("Enter proper Option to Execute");
        break;
}
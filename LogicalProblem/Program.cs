using System;
using LogicalProblem;


Console.WriteLine("Welcome to Basic Programs");
Console.WriteLine("1.FlipCoin\n2.LeapYear\n3.Power\n4.Harmonic\n5.PrimeFactor\n6.QuadrantAndReminder\n7.Swap\n8.EvenOdd\n9.VovelConsonant\n10.Greater");
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
    case 4:
        Harmonic Harmo = new Harmonic();
        Harmo.Harmo();
        break;
    case 5:
        PrimeFactor prime = new PrimeFactor();
        prime.Prime();
        break;
    default:
        Console.WriteLine("Enter proper Option to Execute");
        break;
}
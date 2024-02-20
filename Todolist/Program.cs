using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using System.Xml;

Console.WriteLine("Hello!");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();


switch (userChoice)
{
    case "S":
    case "s":
        PrintSelectedOption("See all TODOs");
        break;
    case "A":
    case "a":
        PrintSelectedOption("Add all TODOs");
        break;
    case "R":
    case "r":
        PrintSelectedOption("Remove a TODO");
        break;
    case "E":
    case "e":
        PrintSelectedOption("Exit Programme");
        break;
    default:
        Console.WriteLine("Not quite right");
        break;
}



Console.ReadKey(); 

void PrintSelectedOption (string selectedOption)
{
    Console.WriteLine("Selected option: " + selectedOption);   //Implementing this method to avoid using the same line of code too many times
}
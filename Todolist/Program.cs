using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using System.Xml;

Console.WriteLine("Hello!");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();

if (userChoice == "S")
{
    PrintSelectedOption("See all TODOs");
}
if (userChoice == "A")
{
    PrintSelectedOption(" Add TODO");
}
if (userChoice == "R")
{
    PrintSelectedOption(" Remove a TODO");
}
if (userChoice == "E")
{
    PrintSelectedOption("Exit Programme");
}

Console.ReadKey(); 

void PrintSelectedOption (string selectedOption)
{
    Console.WriteLine("Selected option: " + selectedOption);
}
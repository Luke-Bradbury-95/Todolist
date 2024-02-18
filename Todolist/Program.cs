using System.ComponentModel;
using System.Xml;

Console.WriteLine("Hello!");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();

if (userChoice == "S")
{
    Console.WriteLine("Selected option: See all TODOs");
}
if (userChoice == "A")
{
    Console.WriteLine("Selected option: Add TODO");
}
if (userChoice == "R")
{
    Console.WriteLine("Selected option: Remove a TODO");
}
if (userChoice == "E")
{
    Console.WriteLine("Selected option: Exit Programme");
}

Console.ReadKey(); 
using System.ComponentModel.Design;

Console.WriteLine("Hello!");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

var userChoice = Console.ReadLine();

if (userChoice.Length <= 3)
{
    Console.WriteLine("Long Answer");
 }
else if(userChoice.Length < 10)
{
    Console.WriteLine("Longer Answer");
    }
else
{
    Console.WriteLine("WAY TO LONG SIR");
}
Console.WriteLine("User Input:"+userChoice); 



Console.ReadKey(); 
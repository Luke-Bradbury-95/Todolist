using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;
List<string> list = new List<string>();
bool exit = false;
int todoNumber = 1;
while (!exit)
{

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
            if (list.Count == 0)
            {
                Console.WriteLine("No To-Do's");
            }
            else {
                foreach (string word in list)
                {
                    Console.WriteLine(word);
                }
            }

            break;
        case "A":
        case "a":
            PrintSelectedOption("Add all TODOs");
            var input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                list.Add($"{todoNumber}){input}");
                Console.Write("ToDo Added");
                todoNumber++;
            }
            else
            {
                Console.WriteLine("Input not accepted");
            }
            break;
        case "R":
        case "r":
            PrintSelectedOption("Remove a TODO");
            Console.WriteLine("Please enter the line number of the ToDo you wish to remove");
            if (int.TryParse(Console.ReadLine(), out int index))
            {
                if (index >= 1 && index <= list.Count)
                {
                    list.RemoveAt(index - 1);
                    RenumberToDos(list); // Renumber the to-dos after removal
                    Console.WriteLine("ToDo removed");
                }
            }
            else
            {
                Console.WriteLine("Invalid index. No item removed.");
            }
            break;
        case "E":
        case "e":
            PrintSelectedOption("Exit Programme");
            break;
        default:
            Console.WriteLine("Not quite right");
            break;
    }
}


            Console.ReadKey();

            void PrintSelectedOption(string selectedOption)
            {
                Console.WriteLine("Selected option: " + selectedOption);   //Implementing this method to avoid using the same line of code too many times
            }
            static void RenumberToDos(List<string> list)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    list[i] = $"{i + 1}: {list[i].Substring(list[i].IndexOf(':') + 2)}";
                }
            }
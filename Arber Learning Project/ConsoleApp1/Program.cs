using System.Reflection.Metadata;
using System.Linq;
string[] onlyAllowed = ["S", "s", "A", "a", "R", "r", "E", "e"];
bool isEmpty;
bool isAllowed;
bool isEqualDescription;
string? userInput;
int indexToRemove;
string? todoDescription;
List<string> todos = new List<string>();
void mainMenu()
{
    do
    {

        Console.WriteLine("Hello!");
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("[S]ee all TODOs");
        Console.WriteLine("[A]dd a TODO");
        Console.WriteLine("[R]emove a TODO");
        Console.WriteLine("[E]xit");
        Console.WriteLine("Enter your option");
        userInput = Console.ReadLine();

        isEmpty = string.IsNullOrEmpty(userInput);
        if (isEmpty == true)
        {
            Console.WriteLine("Invalid input. If you use a TODO List, you will have surely to do something ;) ");
        }
        isAllowed = onlyAllowed.Contains(userInput);
        if (isAllowed == false)
        {
            Console.WriteLine("");
            Console.WriteLine("Only the initials from the options!");
            Console.WriteLine("");
        }
    } while (isEmpty == true || isAllowed == false);



    if (userInput == "S" || userInput == "s")
    {
        caseS();
    }
    else if (userInput == "A" || userInput == "a")
    {
        caseA();
    }
    else if (userInput == "R" || userInput == "r")
    {
        caseR();
    }
    else if (userInput == "E" || userInput == "e")
    {
        caseE();
    }

    Console.ReadKey();


}

void caseS()
{
    if (todos.Count == 0)
    {

        Console.WriteLine("No TODOs have been added yet!");

    }
    else
    {
        for (int i = 0; i < todos.Count(); i++)
        {

            Console.WriteLine($"{i + 1}. {todos[i]}");

        }
    }

    mainMenu();

}
void caseA()
{
    bool isEmptyDescription;
    do
    {
        Console.WriteLine("");
        Console.WriteLine("Enter the TODO description");
        todoDescription = Console.ReadLine();
        isEmptyDescription = string.IsNullOrEmpty(todoDescription);
        isEqualDescription = todos.Contains(todoDescription);
        if (isEmptyDescription)
        {
            Console.WriteLine("The description cannot be empty.");
        }

        if (isEqualDescription)
        {
            Console.WriteLine("The description must be unique");
        }

    } while (isEmptyDescription == true || isEqualDescription == true);


    Console.WriteLine($"TODO successfully added: {todoDescription} ");
    todos.Add(todoDescription);
    mainMenu();


}
void caseE()
{
    Environment.Exit(0);
}
void caseR()
{
    if (todos.Count == 0)
    {
        Console.WriteLine("No TODOs have been added yet.");
    }

    Console.WriteLine("");
    Console.WriteLine("Select the index of the TODO you want to remove!:");
    for (int i = 0; i < todos.Count(); i++)
    {

        Console.WriteLine($"{i + 1}. {todos[i]}");

    }

    indexToRemove = Convert.ToInt32(Console.ReadLine());
    if(indexToRemove <= todos.Count)
    {
  Console.WriteLine($"TODO removed: {todos[indexToRemove - 1]}");
    todos.RemoveAt(indexToRemove - 1);
    }
    else
    {
        Console.WriteLine("The given index is not valid!");
    }
  



    mainMenu();

}

mainMenu();
Console.ReadKey();
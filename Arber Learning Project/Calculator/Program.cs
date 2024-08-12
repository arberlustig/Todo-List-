partial class Program
{
    static void Main(string hallo)
    {
        Console.WriteLine("Hallo!");
    }
}



Console.WriteLine( "Hello!");
Console.WriteLine("Input the first Number");
var userInput = int.Parse(Console.ReadLine());

Console.WriteLine("Input the second number");
var userInput2 = int.Parse(Console.ReadLine());

Console.WriteLine( "What do you want to do with those numbers?" );
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");

var userChoice = Console.ReadLine();
Calculator(userInput,userInput2,userChoice);
Console.ReadKey();
int Calculator(int userInput, int userInput2, string userChoice)
{

switch (userChoice)
{
    case "A":
            Console.WriteLine(userInput + userInput2);
            break;
        
        case "S":
            Console.WriteLine(userInput - userInput2);
            break;


        case "M":
            Console.WriteLine(userInput * userInput2);
            break;
            

}
    return 0;
}

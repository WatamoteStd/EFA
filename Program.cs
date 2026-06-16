using EFA.Core;

EFACore core = new EFACore();

Console.WriteLine();
Console.WriteLine("EFA: v0.0.2");
Console.WriteLine("=====================================================================");

while(true)
{
    
    Console.Write("\nВвод: ");
    string? userInput = Console.ReadLine();
    core.ProcessInput(userInput);
    
}
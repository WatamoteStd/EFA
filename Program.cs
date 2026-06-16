using EFA.Core;

EFACore core = new EFACore();

Console.WriteLine();
Console.WriteLine("EFA: v0.0.2");
Console.WriteLine("========================================================================\n");

while(true)
{
    
    string? userInput = Console.ReadLine();
    core.ProcessInput(userInput);
    
}
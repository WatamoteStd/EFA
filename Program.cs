using EFA.Core;

EFACore core = new EFACore();

Console.WriteLine();
Console.WriteLine("EFA: v0.0.1");
Console.WriteLine("========================================================================");

while(true)
{
    
    string? userInput = Console.ReadLine();
    string? coreResponse = core.ProcessInput(userInput);
    if (!string.IsNullOrEmpty(coreResponse))
    {
        Console.WriteLine($"Request: {coreResponse}");

    }
    

}
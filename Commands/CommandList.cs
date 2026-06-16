using System.Windows.Input;
using EFA.Commands;
using EFA.Core;

namespace EFA.Commands
{
    
    public class CommandList : ICommandable
    {
        
        public void Execute(string args)
        {
            
            Console.WriteLine("\n========== СПИСОК КОММАНД ==========");
            foreach (var command in CommandHandler.CommandsDictionary.Keys)
            {
                
                Console.WriteLine($"--> {command}");

            }

            Console.WriteLine("======================================\n");

        }

    }

}
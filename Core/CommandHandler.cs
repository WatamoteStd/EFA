using System;
using EFA.Commands;

namespace EFA.Core
{
    
    public class CommandHandler
    {
        
        private string _lastCommand;

        public static readonly Dictionary<string, ICommandable> CommandsDictionary = new Dictionary<string, ICommandable>
        {
            {"открой ютюб", new BrowserSearch()}, 
            {"молодец", new EFABless()},
            {"помощь", new CommandList()},
            {"help",new CommandList()},
            {"сервер", new StartServer()},
            {"закрой", new KillProcess()},
        };

        public void ExecuteCommand(string command)
        {
            
            _lastCommand = command;

            foreach (var pair in CommandsDictionary)
            {
                
                if (command.StartsWith(pair.Key)) {

                    string key = pair.Key;
                    string argument = command.Substring(key.Length).Trim();
                    pair.Value.Execute(argument);
                    break;

                }


            }

        }

    }

}
using System;
using EFA.Commands;

namespace EFA.Core
{
    
    public class CommandHandler
    {
        
        private string _lastCommand;

        public readonly Dictionary<string, ICommandable> CommandsDictionary = new Dictionary<string, ICommandable>
        {
            {"открой ютюб", new BrowserSearch()}
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
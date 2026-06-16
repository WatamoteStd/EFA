using System;

namespace EFA.Core
{
    
    public class EFACore
    {

        private readonly  CommandHandler _commandHandler = new CommandHandler();

        public string? ProcessInput(string input)
        {
            
            if (string.IsNullOrEmpty(input)) return null;

            string clearInpute = input.Trim().ToLower();
            if (clearInpute.StartsWith("efa") || clearInpute.StartsWith("ифа"))
            {
                
                string request = clearInpute.Substring(3).Trim();
                _commandHandler.ExecuteCommand(request);

            }

            return null;

        }


    }

}
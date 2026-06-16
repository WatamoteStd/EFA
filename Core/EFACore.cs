using System;

namespace EFA.Core
{
    
    public class EFACore
    {

        

        public string? ProcessInput(string input)
        {
            
            if (string.IsNullOrEmpty(input)) return null;

            string clearInpute = input.Trim().ToLower();
            if (clearInpute.StartsWith("efa") || clearInpute.StartsWith("ифа"))
            {
                
                string request = clearInpute.Substring(3).Trim();
                return request;

            }

            return null;

        }


    }

}
using System;
using System.Diagnostics;
using EFA.Core;

namespace EFA.Commands
{
    
    public class BrowserSearch : ICommandable
    {
        
        public void Execute(string args)
        {
            ProcessStartInfo info = new ProcessStartInfo();

            if (string.IsNullOrEmpty(args))
            {
                info.FileName = "https://www.youtube.com";
                info.WindowStyle = ProcessWindowStyle.Maximized;
                info.UseShellExecute = true;
                Console.WriteLine("EFA: Открываю главную страницу ютюб.");
            }
            else
            {
                
                info.FileName = "https://www.youtube.com/results?search_query=" + args;
                info.WindowStyle = ProcessWindowStyle.Maximized;
                info.UseShellExecute = true;
                Console.WriteLine($"EFA: Открываю ютюб с запросом: {args}");

            }

            Process.Start(info);

        }

    }

}
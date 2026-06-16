using EFA.Commands;
using EFA.Core;
using System.Diagnostics;

namespace EFA.Commands
{
    
    public class KillProcess : ICommandable
    {
        
        public void Execute(string args)
        {

            string processName = string.IsNullOrWhiteSpace(args) ? "dotnet" : args.Trim();
            
            var programs = Process.GetProcessesByName(processName);
            if (programs.Length == 0)
            {
                Console.WriteLine("[EFA]: Указанное приложение не запущено.");
                return;
            }

            byte killCount = 0;
            byte errorCount = 0;
            
            foreach (var prog in programs)
            {
                
                try
                {
                    if (!prog.HasExited)
                    {
                        prog.Kill(true);
                        killCount++;
                    }

                }

                catch
                {
                    errorCount++;
                }

            }
            if (killCount > 0)
            {
                Console.WriteLine($"[EFA]: Успешно закрыто процессов: {killCount}");
            }
            if (errorCount > 0 && killCount == 0)
            {
                Console.WriteLine($"[EFA]: Ошибка, не удалось закрыть прцоессы (возможно, нужны права администратора).");
            }

        }

    }

}
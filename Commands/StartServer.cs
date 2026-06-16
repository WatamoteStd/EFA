using EFA.Commands;
using EFA.Core;
using System.Diagnostics;

namespace EFA.Commands {
    
    public class StartServer : ICommandable
    {
        
        public void Execute(string args)
        {


            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "C:/Users/linkolnwanhuten/Desktop/run_server.bat";
            if (!System.IO.File.Exists(info.FileName))
            {
                Console.WriteLine("[EFA]: Ошибка запуска сервера, путь не найден.");
                return;
            }
            info.WorkingDirectory = "C:/Users/linkolnwanhuten/Desktop";
            info.UseShellExecute = true;
            info.WindowStyle = ProcessWindowStyle.Minimized;
            Process.Start(info);
            Console.WriteLine("[EFA]: Сервер успешно запущен.");

        }

    }

}
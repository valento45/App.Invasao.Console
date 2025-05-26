using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio.Attacks.App.Detectores
{
    public class FileRenamingDetector
    {
        public static void ExecuteFileRenamingDetector()
        {
            string folder = @"C:\\TesteRansom\\";
            FileSystemWatcher watcher = new FileSystemWatcher(folder);
            watcher.Filter = "*.locked";
            watcher.Created += (s, e) =>
            {
                Console.WriteLine($"Alerta: Arquivo bloqueado detectado - {e.Name}");
            };
            watcher.EnableRaisingEvents = true;
            Console.WriteLine("Monitorando arquivos .locked...");
            Console.ReadLine();
        }
    }
}

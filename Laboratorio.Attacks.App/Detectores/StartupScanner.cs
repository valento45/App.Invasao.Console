using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio.Attacks.App.Detectores
{
    public class StartupScanner
    {
        public static void RunStartupScanner()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
            foreach (var file in Directory.GetFiles(path))
            {
                Console.WriteLine("Arquivo de inicialização detectado: " + file);
            }
        }
    }
}

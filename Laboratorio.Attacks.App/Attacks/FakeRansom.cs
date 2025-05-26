using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio.Attacks.App.Attacks
{
    class FakeRansom
    {
        static void Main()
        {
            string folder = @"C:\TesteRansom\";

            foreach (string file in Directory.GetFiles(folder))
            {
                File.Move(file, file + ".locked");
            }

            Console.WriteLine("Seus arquivos foram bloqueados! Pague 0.01 BTC para recuperar.");
        }
    }
}

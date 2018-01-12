using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kerdipangaautomaat
{
    class LogiSisse
    {
        public string tegu;

        public void logimine(string konto, string nimi)
        {
            Sisse sisse = new Sisse();
            Välja välja = new Välja();

            string path = Directory.GetCurrentDirectory() + "kontod.txt";
            string rahapath = Directory.GetCurrentDirectory() + nimi;
            bool olemas;

            if (File.Exists(path))
            {
                olemas = File.ReadAllText(path).Contains(konto);

                while (true)
                {
                    if (olemas)
                    {
                        Console.WriteLine("Teie kasutajal on: " + File.ReadAllText(rahapath) + " eurot");
                        Console.WriteLine("Kas soovite raha sisse panna või välja võtta?");
                        Console.WriteLine("1. Sisse");
                        Console.WriteLine("2. Välja");
                        Console.WriteLine("3. Lõpetada");
                        tegu = Console.ReadLine();

                        if (tegu == "sisse" || tegu == "Sisse" || tegu == "1")
                        {
                            sisse.sisse(nimi);
                        }
                        else if (tegu == "välja" || tegu == "Välja" || tegu == "2")
                        {
                            välja.välja(nimi);
                        }
                        else if (tegu == "Lõpetada" || tegu == "Lopetada" || tegu == "lõpetada" || tegu == "3")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Palun valige midagi valikust");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Kasutaja ei eksisteeri või sisestasite vale nime/PIN");
                        break;
                    }
                }
            }
        }
    }
}

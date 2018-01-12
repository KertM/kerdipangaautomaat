using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kerdipangaautomaat
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sellega näeb unicode'i nagu tm sümbol ja õ
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            LogiSisse logisisse = new LogiSisse();
            Uuskonto uuskonto = new Uuskonto();

            string path = Directory.GetCurrentDirectory() + "kontod.txt";

            if (!File.Exists(path))
            {
                File.WriteAllText(path, "");
            }

            while (true)
            {
                Console.WriteLine("Pangaautomaat v0.3");
                Console.WriteLine("1. Logi sisse");
                Console.WriteLine("2. Uus kasutaja");
                Console.WriteLine("3. Lõpetada");
                Console.WriteLine();
                string vastus = Console.ReadLine();

                if (vastus == "logi sisse" || vastus == "Logi sisse" || vastus == "login" || vastus == "1")
                {
                    Console.WriteLine("Mis on teie kasutaja nimi?");
                    string nimi = Console.ReadLine();
                    bool KõikKorras = false;
                    int pin = 0;

                    while (!KõikKorras)
                    {
                        Console.WriteLine("Mis on teie kasutaja PIN?");
                        pin = Convert.ToInt32(Console.ReadLine());

                        if (pin < 1000 || pin > 9999)
                        {
                            Console.WriteLine("PIN peab olema 4 kohaline arv");
                        }
                        else
                        {
                            break;
                        }
                    }
                    string konto = nimi + pin;
                    if (!File.Exists(Directory.GetCurrentDirectory() + nimi))
                    {
                        Console.WriteLine("Hmmm... huvitav");
                        File.WriteAllText(Directory.GetCurrentDirectory() + nimi, "0");
                    }
                    logisisse.logimine(konto, nimi);
                }

                else if (vastus == "uus kasutaja" || vastus == "Uus kasutaja" || vastus == "2")
                {
                    uuskonto.loomine();
                }

                else if (vastus == "Lõpetada" || vastus == "lõpetada" || vastus == "Lopetada" || vastus == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Palun sisestage midagi valikutest");
                }
            }
        }
    }
}

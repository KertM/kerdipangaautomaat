using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace kerdipangaautomaat
{
    class Välja
    {
        public void välja(string nimi)
        {
            string rahapath = Directory.GetCurrentDirectory() + nimi;
            Console.WriteLine("Kui palju soovite välja võtta?");

            double sisse = Convert.ToDouble(Console.ReadLine());
            double sees = Convert.ToDouble(File.ReadAllText(rahapath));
            double summa = sees - sisse;

            File.WriteAllText(rahapath, Convert.ToString(summa));
            Console.WriteLine();
        }
    }
}

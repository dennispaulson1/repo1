using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_receptek
{
    /// <summary>
    /// Pörkölt recept hozzávalóit kiírjuk
    /// 
    /// Kiegészítés: hetente egyszer érkezik hal a piacra, akkor halas étel készül, 
    /// egyébként pörkölt
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // ha péntek van, akkor halas recept, egyébként pörkölt

            var maiNap = DateTime.Today;
            var maiNapNeve = maiNap.DayOfWeek;
            var maHalVan = DayOfWeek.Friday;

            if (maiNapNeve == maHalVan)
            {
                Console.WriteLine("halas étel hozzávalók");
            }
            else
            {
                Console.WriteLine("Marhahús");
                Console.WriteLine("Vöröshagyma");
                Console.WriteLine("Olaj");
                Console.WriteLine("Pirospaprika");
            }

            

            Console.ReadLine();
        }
    }
}

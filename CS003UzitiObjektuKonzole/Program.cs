using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CS003UzitiObjektuKonzole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Nastavení titulku konzole pomocí vlastnosti";
            Console.WindowHeight = 20;
            Console.WindowWidth = 45;
            Console.WindowTop = 0;
            Console.WindowLeft = 0;

            Console.SetCursorPosition(20, 10);
            Console.WriteLine("Karel Hofman");
            Console.ReadKey();
            Console.Clear();
            Console.ReadKey();
        }
    }
}

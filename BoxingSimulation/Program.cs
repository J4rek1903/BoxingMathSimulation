using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter b1 = new Fighter("Mike Tyson", 1000, 150, 150);
            Fighter b2 = new Fighter("Evander Holyfield", 1000, 120, 200);

            Fight.StartFight(b1, b2);

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Космическая 13", 2, 3, 4);
            Console.WriteLine(building.Print());
            MultiBuilding multiBuilding = new MultiBuilding("Космическая 13", 2, 3, 4, 5);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}

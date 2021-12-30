using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    internal class Building
    {
        public string Address { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }
        public Building()
        {

        }
        public Building(string a, double l, double w, double h)
        {
            Address = a;
            Length = l;
            Width = w;
            Height = h;
        }
        public string Print()
        {
            MultiBuilding multiBuilding = new MultiBuilding("Космическа 13", 2, 3, 4, 5);
            return ($"{Address}\n{Length}\n{Width}\n{Height}\n{multiBuilding.Floor}");
        }
    }
    sealed class MultiBuilding : Building
    {
        public int Floor { get; set; }// добавляет параметр этажности
        public MultiBuilding(string a, double l, double w, double h, int f)
        {
            Floor = f;
        }
    }
}

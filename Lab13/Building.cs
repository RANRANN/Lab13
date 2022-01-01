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
        public Building(string a, double l, double w, double h)
        {
            Address = a;
            Length = l;
            Width = w;
            Height = h;
        }
        public string Print()
        {
            return $"адресс - {Address}\nдлина - {Length}\nширина - {Width}\nвысота - {Height}";
        }
    }
    sealed class MultiBuilding : Building
    {
        public int Floor { get; set; }// добавляет параметр этажности
        public MultiBuilding(string a, double l, double w, double h, byte f)
            : base(a, l, w, h)
        {
            Floor = f;
        }
        public string Print()
        {
            string itog = base.Print();
            itog += $"\nколичесвто этажей - {Floor}";
            return itog;
        }
    }
}

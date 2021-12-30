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
            #region
            //RegulTreugolnik regulTreugolnik = new RegulTreugolnik();
            //Treugolnik treugolnik = regulTreugolnik;
            //if (treugolnik is PrimTreugolnik)
            //{
            //    PrimTreugolnik primtreugolnik = (PrimTreugolnik)treugolnik;
            //}

            ////PrimTreugolnik primtreugolnik = new PrimTreugolnik(1,2);
            ////Treugolnik treugolnik = primtreugolnik;
            ////PrimTreugolnik primTreugolnik = (PrimTreugolnik)treugolnik;
            //Console.WriteLine(treugolnik.GetSquare());
            #endregion
            Building building = new Building("Космическа 13",2,3,4);
            Console.WriteLine(building.Print());
            Console.ReadKey();
        }
    }
    #region
    //class Treugolnik
    //{
    //    public double A { get; set; }
    //    public double B { get; set; }
    //    public double C { get; set; }
    //    public Treugolnik()
    //    {

    //    }
    //    public Treugolnik(double a, double b, double c)
    //    {
    //        A = a;
    //        B = b;
    //        C = c;
    //    }

    //    public double GetSquare()
    //    {
    //        double p = (A + B + C) / 2;
    //        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    //    }
    //}
    //class PrimTreugolnik : Treugolnik
    //{
    //    public PrimTreugolnik(double a, double b)
    //        : base(a, b, Math.Sqrt(a * a + b * b))
    //    {

    //    }
    //}
    //class RegulTreugolnik : Treugolnik
    //{

    //}
    #endregion
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri
{
    class Parallelogram : Square
    {
        private double angle;
        public Parallelogram(double Length, double Height, double Angel)
        {
            this.Height = Height;
            this.Length = Length;
            this.angle = Angel;
        }

        public static void arealParalelogram()
        {
            Parallelogram areal = new Parallelogram(0,0,0);

            Console.Write("Højden på dit parallogram: ");
            areal.Height = Double.Parse(Console.ReadLine());
            Console.Write("længden på dit parallogram: ");
            areal.Length = Double.Parse(Console.ReadLine());
            Console.Write("vinklen på den spidse vinkel: ");
            areal.angle = Double.Parse(Console.ReadLine());

            Console.WriteLine(Parallelogram.arealParallelogramUdregn(areal.Height, areal.Length, areal.angle));
        }

        public static double arealParallelogramUdregn(double height, double Length, double Angle)
        {
            return height * Length * Math.Sin(Angle);
        }
    }
}

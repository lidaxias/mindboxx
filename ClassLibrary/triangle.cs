using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shapes
{
    public class triangle : shape
    {
        private double sidea { get; }
        private double sideb { get; }
        private double sidec { get; }
        public double perim => sidea + sideb + sidec;
        // реализуем формулу Герона
        public override double Area => Math.Sqrt((perim / 2) * ((perim / 2) - sidea) * ((perim / 2) - sideb) * ((perim / 2) - sidec));
   
        public bool rightrian => ((Math.Pow(sidea, 2) + Math.Pow(sideb, 2) == Math.Pow(sidec, 2)) ||(Math.Pow(sidea, 2) + Math.Pow(sidec, 2) == Math.Pow(sideb, 2)) ||
                                (Math.Pow(sidec, 2)) + Math.Pow(sideb, 2) == Math.Pow(sidea, 2)) ? true : false;

        public triangle(double sidea, double sideb, double sidec)
        {
            if ((sidea<= 0 || sideb <= 0 || sidec <= 0))
            {
                throw new ArgumentException("Стороны треугольника не могут быть отрицательными");
            }
            else if ((sidea >= sideb + sidec) || (sideb >= sidea + sidec) || (sidec >= sidea + sideb))
            {
                throw new ArgumentException("Треугольник с такими сторонами не существует!");
            }

            this.sidea = sidea;
            this.sideb = sideb;
            this.sidec = sidec;
        }
    }
}
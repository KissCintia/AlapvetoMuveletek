using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haromszog
{
    public class HaromszogAdatai
    {
        public double SideA;
        public double SideB;
        public double SideC;

        public HaromszogAdatai(double SideA, double SideB, double SideC)
        {
            this.SideA = SideA;
            this.SideB = SideB;
            this.SideC = SideC;
        }

        public double Kerulet()
        {
            return (SideA + SideB + SideC);
        }
        public double Terulet()
        {
            double s = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class ScientificCalculator : IScientificCalculator
    {
        public int XtoY(int x, int y)
        {
            int result = 1;
            for (int i = 0; i < y; i++)
            {
                result *= x;
            }
            return result;

            //return (int)Math.Pow(x, y);
        }

        public int Square(int x)
        {
            return x * x;
        }

        public int Cube(int x)
        {
            return x * x * x;
        }

        public int Xto3(int x)
        {
            return x * x * x;
        }

        public int TenToX(int x)
        {
            int result = 1;
            for (int i = 0; i < x; i++)
            {
                result *= 10;
            }
            return result;
        }
    }
    
    
}

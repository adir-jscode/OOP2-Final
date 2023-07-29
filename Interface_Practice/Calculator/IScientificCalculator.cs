using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface IScientificCalculator
    {
        int XtoY(int x, int y);
        int Square(int x);
        int Cube(int x);
        int Xto3(int x);
        int TenToX(int x);
    }
}

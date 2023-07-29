using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public interface IBasicCalculator
    {
        int Sum(int x, int y);
        int Sub(int x, int y);
    }
}

using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test_Interface_1
{
    internal class Program
    {
       
        static void Main(string[] args)
        {

            //creating object of BasicCalculator class
            BasicCalculator basicCalculator = new BasicCalculator();
            Console.WriteLine("Sum: " + basicCalculator.Sum(10, 20));
            Console.WriteLine("Sub: " + basicCalculator.Sub(20, 10));

            //creating object of ScientificCalculator class
            ScientificCalculator scientificCalculator = new ScientificCalculator();
            Console.WriteLine("X to Y: " + scientificCalculator.XtoY(2, 3));
            Console.WriteLine("Square: " + scientificCalculator.Square(2));
            Console.WriteLine("Cube: " + scientificCalculator.Cube(2));
            Console.WriteLine("X to 3: " + scientificCalculator.Xto3(2));
            Console.WriteLine("10 to X: " + scientificCalculator.TenToX(2));

        }
    }
}
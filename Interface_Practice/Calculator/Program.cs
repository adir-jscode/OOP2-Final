using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Test_Interface_1
{
    internal class Program
    {

        interface IBasicCalculator
        {
            int Sum(int x, int y);
            int Sub(int x, int y);
        }

        //5 functions of Scientific Calculator interface
        interface IScientificCalculator
        {
            int XtoY(int x, int y);
            int Square(int x);
            int Cube(int x);
            int Xto3(int x);
            int TenToX(int x);
        }

        //Implementing both interfaces different classes
        public class BasicCalculator : IBasicCalculator
        {
            public int Sum(int x, int y)
            {
                return x + y;
            }

            public int Sub(int x, int y)
            {
                return x - y;
            }
        }

        //Implementing both interfaces different classes
        class ScientificCalculator : IScientificCalculator
        {
            public int XtoY(int x, int y)
            {
                int result = 1;
                for (int i = 0; i < y; i++)
                {
                    result *= x;
                }
                return result;
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
using System;

namespace Static_Method
{

    class Circle
    {
        static double _PI;
        int _radius;

        static Circle()
        {
            Console.WriteLine("Static Constructor Called");
            Circle._PI = 3.1416;
        }

        public Circle(int Radius)
        {
            Console.WriteLine("Instance Constructor Called");
            this._radius = Radius;
        }

        //Static Method

        public static void Display()
        {
            Console.WriteLine("Calling Static Method : Olleh");
        }
        public double Area()
        {
            return Circle._PI * this._radius * this._radius;
        }



    }
    class Program
    {


       


        static void Main(string[] args)
        {
            Circle c1 = new Circle(5);
            double Area = c1.Area();
            Console.WriteLine("Area : {0}", Area);

            Circle c2 = new Circle(4);
            double Area1 = c2.Area();
            Console.WriteLine("Area : {0}", Area1);

            //Calling Static Method 
            Circle.Display();
        }
    }
}

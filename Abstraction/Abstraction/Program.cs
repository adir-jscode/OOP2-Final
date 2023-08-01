using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    //main function
    class Program
    {
        static void Main(string[] args)
        {
           Developer developer1 = new Developer(10000);
            Driver driver1 = new Driver(5000);

            int devSalary, driverSalary;
            devSalary= developer1.getSalary();
            driverSalary= driver1.getSalary();

            Console.WriteLine("Developer Salary is: " + devSalary);
            Console.WriteLine("Driver Salary is: " + driverSalary);

           
           
        }
    }
}

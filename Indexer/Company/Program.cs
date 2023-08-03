
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace declaration
namespace Company
{
    class Program
    {
        public static void Main(string[] args)
        {
            Company company = new Company();
            Console.WriteLine("Name of Employee with ID = 2: " + company[2]);
            company[2] = "Adir";

             Console.WriteLine(" After Changes Name of Employee with ID = 2: " + company[2]);
            
        }
    }
}

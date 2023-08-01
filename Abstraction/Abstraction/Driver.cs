using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Driver : Employee
    {
        private int salary;

        public Driver(int salary)
        {
            this.salary = salary;
        }
        public override int getSalary()
        {
            return salary;
        }
    }
}

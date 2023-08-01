using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    class Developer : Employee
    {
        private int salary;

        public Developer(int salary)
        {
            this.salary = salary;
        }
        public override int getSalary()
        {
            return salary;
        }
    }
}

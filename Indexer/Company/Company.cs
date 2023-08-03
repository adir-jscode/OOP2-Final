using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    internal class Company
    {
        private List<Employee> listEmployee;

        public Company()
        {
            listEmployee= new List<Employee>();
            listEmployee.Add(new Employee() { EmployeeID = 1, Name = "John" });
            listEmployee.Add(new Employee() { EmployeeID = 2, Name = "Marry" });
            listEmployee.Add(new Employee() { EmployeeID = 3, Name = "Mike" });
            listEmployee.Add(new Employee() { EmployeeID = 4, Name = "Todd" });
        }

        public string this[int employeeID]
        {
            get
            {
                return listEmployee.FirstOrDefault(emp=>emp.EmployeeID == employeeID).Name;
            }
            set
            {
                listEmployee.FirstOrDefault(emp=> emp.EmployeeID == employeeID).Name = value;
            }
        }

    }
}

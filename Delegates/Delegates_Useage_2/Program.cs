using System;
using System.Security.Cryptography.X509Certificates;

namespace Delegates_Useage_2
{

    delegate bool IsPromoted(Employee emp);

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void Promoted(List<Employee> employeelist, IsPromoted isPromoted)
        {
            foreach(Employee employee in employeelist)
            {
                if(isPromoted(employee))
                {
                    Console.WriteLine(employee.Name  + " is Promoted And his salary is " + employee.Salary );
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee() { Id = 101, Name="Ali", Salary=7000, Experience=5});
            list.Add(new Employee() { Id = 102, Name = "Adir", Salary = 4000, Experience = 6 });
            list.Add(new Employee() { Id = 103, Name = "XYZ", Salary = 9000, Experience = 2 });
            list.Add(new Employee() { Id = 104, Name = "ABC", Salary = 8000, Experience = 7 });

            IsPromoted del = new IsPromoted(Promote);


            Employee.Promoted(list,del);
            //Using Lambda Expression 
            Employee.Promoted(list, list=>list.Experience >=5);

            
           
        }

        public static bool Promote(Employee emp)
        {
            if(emp.Experience >= 5)
            {
                return true;
            }
            return false;
        }
    }
}
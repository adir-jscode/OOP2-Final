using System;

namespace Delegates_Useage_1
{

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experience { get; set; }

        public static void Promoted(List<Employee> employeeList)
        {
            foreach(Employee emp in employeeList)
            {
                if(emp.Experience >= 5)
                {
                    Console.WriteLine(emp.Name + " Is Promoted");
                }
                
            }
        }
    }

    class Program
    {
        
        //main function
        static void Main(string[] args)
        {
           List<Employee> list = new List<Employee>();
            list.Add(new Employee() { Id= 101, Name = "Adir", Salary = 6000, Experience = 6});
            list.Add(new Employee() { Id = 102, Name = "Ali", Salary = 6000, Experience = 5 });
            list.Add(new Employee() { Id = 101, Name = "Sarafat", Salary = 6000, Experience = 3 });

            Employee.Promoted(list);

        }
    }
}
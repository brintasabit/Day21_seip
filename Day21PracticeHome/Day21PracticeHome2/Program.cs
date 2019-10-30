using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day21PracticeHome.Model.Model;

namespace Day21PracticeHome2
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee=new Employee();
            employee.Name = "Alice";
            employee.Address = "Las Vegas";
            employee.Id = 01;
            Console.WriteLine("ID: "+employee.Id+" "+"NAME: "+employee.Name+" "+"ADDRESS: "+employee.Address);
            Employee employee2 = new Employee(2,"Bob","NY");
            Console.WriteLine("ID: "+employee2.Id+" "+"NAME: "+employee2.Name+" "+"ADDRESS: "+employee2.Address);
            Employee employee3 = new Employee()
            {
                Id = 3,
                Name = "Carlos",
                Address = "CA",

            };
            Console.WriteLine("ID: "+employee3.Id+" "+"NAME: "+employee3.Name+" "+"ADDRESS: "+employee3.Address);
            List<Employee>employees=new List<Employee>()
            {
                employee3,
                new Employee(){Id = 4,Name = "David",Address = "CA"},
            };
            foreach (Employee emp in employees)
            {
                Console.WriteLine("ID: "+emp.Id+" "+"NAME: "+emp.Name+" "+"ADDRESS: "+emp.Address);
            }
            Console.Read();
        }
    }
}

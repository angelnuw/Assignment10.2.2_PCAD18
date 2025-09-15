using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment10._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Name = "Alice", Age = 25, Salary = 6000 },
                new Employee { Name = "Bob", Age = 32, Salary = 7000 },
                new Employee { Name = "Charlie", Age =28, Salary = 4500 },
                new Employee { Name = "David", Age = 27, Salary = 5200 },
                new Employee { Name = "Eve", Age = 29, Salary = 8000 }
            };

            var filteredEmployees = from emp in employees
                                    where emp.Salary > 5000 && emp.Age < 30
                                    select emp;

            Console.WriteLine("Employees with Salary > $5000 and Age < 30:");
            foreach (var emp in filteredEmployees)
            {
                Console.WriteLine($"Name: {emp.Name}, Age: {emp.Age}, Salary: {emp.Salary}");
            }
        }
    }
}

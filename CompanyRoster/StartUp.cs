using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyRoster
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Employee> listEmployees = new List<Employee>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputArgs = Console.ReadLine().Split();

                string name = inputArgs[0];
                decimal salary = decimal.Parse(inputArgs[1]);
                string position = inputArgs[2];
                string department = inputArgs[3];

                Employee employee = new Employee(name, salary, position, department);

                if (inputArgs.Length == 5)
                {
                    if (int.TryParse(inputArgs[4], out int result))
                    {
                        employee.Age = result;
                    }
                    else
                    {
                        employee.Email = inputArgs[4];
                    }
                }
                else if (inputArgs.Length == 6)
                {
                    int age = int.Parse(inputArgs[5]);
                    employee.Email = inputArgs[4];
                    employee.Age = age;
                }

                listEmployees.Add(employee);
            }

            var topDepartment = listEmployees.GroupBy(x => x.Department)
                                             .ToDictionary(x => x.Key, y => y.Select(s => s))
                                             .OrderByDescending(x => x.Value.Average(s => s.Salary))
                                             .FirstOrDefault();

            Console.WriteLine("Highest Average Salary: {0}",topDepartment.Key);

            foreach (var emp in topDepartment.Value.OrderByDescending(t => t.Salary))
            {
                Console.WriteLine("{0} {1:F2} {2} {3}",emp.Name, emp.Salary, emp.Email, emp.Age);
            }
        }
    }
}
